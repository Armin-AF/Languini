
import React, { useState, useEffect } from "react";
import Moment from 'react-moment';
import { useAuth0 } from "@auth0/auth0-react";

const CardComponent = (props) => {
    const { user } = useAuth0();
    const [participants, setParticipants] = useState([]);

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
    }, [participants, props.id, user])

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
            await fetch(`https://localhost:7057/api/Meeting/${props.id}` , requestOptions)
        } catch (e) {
            console.log(e.message);
        }
    }

    const OnEdit = async () => {
        try {
            const requestOptions = {
                method: 'PUT',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    id: props.id,
                    title: props.title,
                    description: props.description,
                    date: props.date,
                    time: props.time,
                    language: props.language,
                    location: props.location,
                    hostEmail: props.hostEmail,
                })
            };
            await fetch(`https://localhost:7057/api/Meeting/${props.id}` , requestOptions)
        } catch (e) {
            console.log(e.message);
        }
    }

    const HandleRemove = async () => {
        try {

            await fetch(`https://localhost:7057/api/Participant?participantEmail=${user.email}&meetingId=${props.id}`, { method: 'DELETE' })

        } catch (e) {
            console.log(e.message);
        }
    }

    return (
        <div className="flex flex-col justify-center my-10">
            <div
                className="relative flex flex-col md:flex-row md:space-x-5 space-y-3 md:space-y-0 rounded-xl shadow-lg p-3 max-w-xs md:max-w-3xl mx-auto border border-white bg-white">
                <div className="w-full md:w-1/3 bg-white grid place-items-center">
                    <img src="https://i.picsum.photos/id/192/2352/2352.jpg?hmac=jN5UExysObV7_BrOYLdxoDKzm_c_lRM6QkaInKT_1Go" alt="venue" className="rounded-xl" />
                </div>
                <div className="w-full md:w-2/3 bg-white flex flex-col space-y-2 p-3">
                    <div className="flex justify-between item-center">
                        <p className="text-gray-600 font-bold text-sm md:block">{props.location}</p>
                        <p className="text-gray-600 font-bold text-sm md:block">{props.creatorEmail}</p>
                        <div className="flex items-center">
                            <p className="
                            text-gray-600 font-bold text-sm ml-1">
                                <Moment format="MMM Do YYYY, h:mm a">{props.date}</Moment>
                            </p>
                        </div>
                    </div>
                    <h3 className="font-black text-gray-800 md:text-2xl text-xl">{props.language}</h3>
                    <p className="md:text-lg text-gray-500 text-base">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis bibendum tortor id arcu iaculis, eu posuere arcu posuere. Aliquam non.</p>
                    <div>
                        <button className="bg-cyan-400 px-3 py-1 rounded-full text-xs font-medium text-gray-800 lg:w-20" onClick={HandleClick}>Join</button>
                        <button className="bg-red-400 px-3 py-1 rounded-full text-xs font-medium text-gray-800 lg:w-20" onClick={HandleRemove}>Remove</button>
                        {participants?.map((participant, index) => (
                            <p className="text-gray-600 font-thin text-sm mt-2" key={index}>{participant.participantEmail}</p>
                        ))}
                    </div>
                    {user.email === props.creatorEmail && <button className="bg-red-400 px-3 py-1 rounded-full text-xs font-medium text-gray-800 lg:w-20" onClick={OnDelete}>Delete Event</button>}
                    <button className="bg-cyan-400 px-3 py-1 rounded-full text-xs font-medium text-gray-800 lg:w-20" onClick={OnEdit}>Edit Description</button>
                </div>
            </div>
        </div>
    );
};
export default CardComponent;
