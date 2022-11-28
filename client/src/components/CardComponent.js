
import React, {useState, useEffect} from "react";
import Moment from 'react-moment';
import {useAuth0} from "@auth0/auth0-react";

const CardComponent = (props) => {
    const {user} = useAuth0();
    const [participants, setParticipants] = useState([]);
    const [createParticipant, setCreateParticipant] = useState(false);

    useEffect(() => {
        const getParticipants = async () => {
            try {
                await fetch(`https://lingofikaapi.azurewebsites.net/api/Participant/${props.id}`)
                    .then(response => response.json())
                    .then(data => setParticipants(data))
            } catch (e) {
                console.log(e.message);
            }
        }
        getParticipants().then();
    }, [props.id])

    const HandleClick = async () => {
        try {
            if (!createParticipant) {
                const requestOptions = {
                    method: 'POST',
                    headers: {'Content-Type': 'application/json'},
                    body: JSON.stringify({
                        participantEmail: user.email,
                        meetingId: props.id
                    })
                };
                await fetch('https://lingofikaapi.azurewebsites.net/api/Participant', requestOptions)
                    .then(response => response.json())
                setCreateParticipant(true)
            }
        } catch (e) {
            console.log(e.message);
        }
    }


    return (
        <div className="flex flex-col justify-center my-10">
            <div
                className="relative flex flex-col md:flex-row md:space-x-5 space-y-3 md:space-y-0 rounded-xl shadow-lg p-3 max-w-xs md:max-w-3xl mx-auto border border-white bg-white">
                <div className="w-full md:w-1/3 bg-white grid place-items-center">
                    <img src="https://i.picsum.photos/id/192/2352/2352.jpg?hmac=jN5UExysObV7_BrOYLdxoDKzm_c_lRM6QkaInKT_1Go" alt="venue" class="rounded-xl" />
                </div>
                <div className="w-full md:w-2/3 bg-white flex flex-col space-y-2 p-3">
                    <div className="flex justify-between item-center">
                        <p className="text-gray-600 font-bold md:block">{props.location}</p>
                        <div className="flex items-center">
                            <p className="
                            text-gray-600 font-bold text-sm ml-1">
                                <Moment format="dddd MMMM Do YYYY, h:mm a">{props.date}</Moment>
                            </p>
                        </div>
                        <button className="bg-cyan-400 px-3 py-1 rounded-full text-xs font-medium text-gray-800 md:block lg:w-20" onClick={HandleClick}>Join</button>
                    </div>
                    <h3 className="font-black text-gray-800 md:text-2xl text-xl">{props.language}</h3>
                    <div className="mb-2 leading-normal">
                    {participants?.map((participant) => (
                        <p key={participant.id}>{participant.participantEmail}</p>
                    ))}
                </div>
                    <p className="md:text-lg text-gray-500 text-base">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis bibendum tortor id arcu iaculis, eu posuere arcu posuere. Aliquam non.</p>
                </div>
            </div>
        </div>
    );
};
export default CardComponent;
