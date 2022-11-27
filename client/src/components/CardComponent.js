import React, {useState, useEffect} from "react";
import Moment from 'react-moment';
import {useAuth0} from "@auth0/auth0-react";

const CardComponent = (props) => {
    const {user} = useAuth0();
    const [participants, setParticipants] = useState([]);
    const [createParticipant, setCreateParticipant] = useState(false);

    const HandleClick = async () => {
        try {
            if (!createParticipant) {
                const requestOptions = {
                    method: 'POST',
                    headers: {'Content-Type': 'application/json'},
                    body: JSON.stringify({
                        meetingId: props.id,
                        userId: user.sub
                    })
                };
                await fetch('https://lingofikaapi.azurewebsites.net/api/Participant', requestOptions)
                    .then(response => response.json())
                setCreateParticipant(true)
            } else {
                const requestOptions = {
                    method: 'DELETE',
                    headers: {'Content-Type': 'application/json'},
                };
                await fetch(`https://lingofikaapi.azurewebsites.net/api/Participant/${user.email}`, requestOptions)
                    .then(response => response.json())
                setCreateParticipant(false)
            }
        } catch (e) {
            console.log(e.message);
        }
    }

    useEffect(() => {
        const getEvent = async () => {
            try {
                await fetch('https://lingofikaapi.azurewebsites.net/api/Participant/' + props.id)
                    .then(response => response.json())
                    .then(data => setParticipants(data))
            } catch (e) {
                console.log(e.message);
            }
            console.log((props.id + " =id"))
        }
    getEvent().then();
    }, [props.id])


    return (
        <div className="w-full p-2 rounded-lg shadow-xl ">
            <img
                className="object-cover w-full mx-auto max-w-md rounded-lg"
                src="https://i.picsum.photos/id/192/2352/2352.jpg?hmac=jN5UExysObV7_BrOYLdxoDKzm_c_lRM6QkaInKT_1Go"
                alt="LOCATION"
            />
            <div className="pl-2">
                <h4 className="text-xl font-semibold tracking-tight text-blue-600">
                    {props.language}
                </h4>
                <p className="mb-2 leading-normal">
                    {props.location}
                </p>
                <p className="mb-2 leading-normal">
                  <Moment format="dddd MMMM Do YYYY, h:mm a">{props.date}</Moment>
                </p>
                <button className="px-4 py-2 text-sm text-blue-100 bg-blue-500 rounded shadow" onClick={HandleClick}>
                    Join
                </button>
                <p className="mb-2 leading-normal">
                    {participants.map((participant) => (
                        <p>{participant.participantId}</p>
                    ))}
                </p>
            </div>
        </div>
    );
}

export default CardComponent;
