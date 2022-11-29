import React, { useState, useEffect } from "react";
import Moment from 'react-moment';
import { useAuth0 } from "@auth0/auth0-react";
import FormEditMeeting from "./FormEditMeeting";

const CardComponent = (props) => {
    const { user } = useAuth0();
    const [participants, setParticipants] = useState([]);
    const [openEditForm, setOpenEditForm] = useState(false);
    const [show, setShow] = useState(false);

    const OnEditButtonClick = () => {
        if (openEditForm) {
            setOpenEditForm(false);
        }
        else {
            setOpenEditForm(true);
        }
    }

    useEffect(() => {
        const getParticipants = async () => {
            try {
                await fetch(`https://localhost:7057/api/Participant/${props.id}`)
                    .then(response => response.json())
                    .then(data => setParticipants(data))
            } catch (e) {
                console.log(e.message);
            }
        }
        getParticipants().then();
    }, [])

    const HandleClick = async () => {
        try {
            const requestOptions = {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    participantEmail: user.email,
                    meetingId: props.id
                })
            };
            await fetch('https://localhost:7057/api/Participant', requestOptions)
                .then(response => response.json())

            await fetch(`https://localhost:7057/api/Participant/${props.id}`)
                .then(response => response.json())
                .then(data => setParticipants(data))

        } catch (e) {
            console.log(e.message);
        }
    }

    const OnDelete = async () => {
        try {
            const requestOptions = {
                method: 'DELETE',
                headers: { 'Content-Type': 'application/json' },
            };
            await fetch(`https://localhost:7057/api/Meeting/${props.id}`, requestOptions)
            props.reload1();

        } catch (e) {
            console.log(e.message);
        }
    }

    const HandleRemove = async () => {
        try {

            await fetch(`https://localhost:7057/api/Participant?participantEmail=${user.email}&meetingId=${props.id}`, { method: 'DELETE' })

            await fetch(`https://localhost:7057/api/Participant/${props.id}`)
                .then(response => response.json())
                .then(data => setParticipants(data))

        } catch (e) {
            console.log(e.message);
        }
    }

    let arrayEmail = [];
    participants?.map(element => arrayEmail.push(element.participantEmail))

    return (
        <div className="flex flex-col justify-center my-10">
            {!show && < div className="w-full relative flex flex-col hover:bg-gray-100 md:flex-row md:space-x-5 space-y-3 md:space-y-0 rounded-xl shadow-lg p-3 max-w-xs md:max-w-3xl mx-auto border border-white bg-white" onClick={() => setShow(true)}>
                <Moment format="MMM Do YYYY, h:mm a">{props.date}</Moment>
                <div>{props.location}</div>
                <div>{props.language}</div>
                <div>+</div>
            </div>}
            {show && <div
                className="relative flex flex-col md:flex-row md:space-x-5 space-y-3 md:space-y-0 rounded-xl shadow-lg p-3 max-w-xs md:max-w-3xl mx-auto border border-white bg-white" onClick={() => setShow(false)}>
                <div className="w-full md:w-1/3 bg-white grid place-items-center">
                    <img src="https://i.picsum.photos/id/42/3456/2304.jpg?hmac=dhQvd1Qp19zg26MEwYMnfz34eLnGv8meGk_lFNAJR3g" alt="venue" className="rounded-xl object-top" />
                </div>
                <div className="w-full md:w-2/3 bg-white flex flex-col space-y-2 p-3">
                    <div className="flex justify-between item-center">

                        <p className="text-gray-600 font-bold text-sm md:block">📍{props.location}</p>


                        <div className="flex items-center">
                            <p className="
                            text-gray-600 font-bold text-sm ml-1">
                                <Moment format="MMM Do YYYY, h:mm a">{props.date}</Moment>
                            </p>
                        </div>
                    </div>
                    <div className="border p-6">
                        <h3 className="font-black text-gray-800 md:text-2xl text-xl">{props.language}</h3>
                        <p className="md:text-lg text-gray-500 text-base">{props.description}</p>
                        <p className="text-gray-600 font-bold text-xs md:block">Created by: {props.creatorEmail}</p>
                    </div>
                    <div>
                        {arrayEmail?.includes(user.email) ? <button className="bg-red-500 hover:bg-red-400 text-white font-medium px-2 py-1 text-sm border border-gray-400 rounded shadow active:scale-[0.95] active:duration-75 transition-all w-24" onClick={HandleRemove}>Leave</button>
                            : arrayEmail.length < 5 ? <button className="bg-cyan-500 hover:bg-cyan-400 text-white font-medium px-2 py-1 text-sm border border-gray-400 rounded shadow active:scale-[0.95] active:duration-75 transition-all w-24" onClick={HandleClick}>Join</button> : <button></button>}
                        {user.email === props.creatorEmail && <button className="bg-transparent-400 px-3 py-1 rounded-full text-md font-medium text-gray-800 ml-3 active:scale-[0.95] active:duration-75 transition-all" onClick={OnDelete}>🗑</button>}
                        {user.email === props.creatorEmail && user.email === props.creatorEmail && <button className="bg-transparent-400 px-3 py-1 rounded-full text-md font-medium text-gray-800 active:scale-[0.95] active:duration-75 transition-all" onClick={OnEditButtonClick}>✎</button>}
                        {participants?.map((participant, index) => (
                            <p className="text-gray-600 font-thin text-sm mt-2" key={index}>{participant.participantEmail}</p>
                        ))}
                    </div>
                    {openEditForm && <FormEditMeeting id={props.id} date={props.date} description={props.description} location={props.location} language={props.language} creatorEmail={props.creatorEmail} />}

                </div>
            </div>}
        </div>
    );
};
export default CardComponent;
