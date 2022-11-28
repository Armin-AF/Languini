import React,{useState} from "react";
import { useAuth0 } from "@auth0/auth0-react";

const FormEditMeeting = (props) => {

    const { user } = useAuth0();
    const [meetingDescription, setMeetingDescription] = useState(props.description);

    const OnEdit = async () => {
        try {
            const requestOptions = {
                method: 'PATCH',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    meetingId: props.id,
                    date: props.date,
                    description: meetingDescription,
                    location: props.location,
                    language: props.language,
                    creatorEmail: user.email
                })
            };
            await fetch(`https://localhost:7057/api/Meeting` , requestOptions)
        } catch (e) {
            console.log(e.message);
        }
    }

    return (
        <div>
            <form className="flex flex-col justify-center my-10">
                <label className="text-2xl font-bold text-center">Edit Description</label>
                <input className="border-2 border-gray-300 p-2 my-2" type="text" placeholder="Description" onChange={(e) => setMeetingDescription(e.target.value)} />
                <button className="bg-cyan-400 hover:bg-cyan-300 text-gray-800 font-bold py-2 px-4 inline-flex items-center w-40 justify-center rounded-lg" onClick={OnEdit}>
                    <span>Submit</span>
                </button>
            </form>
        </div>
    );
}

export default FormEditMeeting;
