import React,{useState} from "react";
import { useAuth0 } from "@auth0/auth0-react";

const FormEditMeeting = (props) => {

    const { user } = useAuth0();
    const [state, setState] = useState(props.description);


    let onChange = (e) => {
        let oldValue = state;
        let newValue = e.target.value;
        setState(newValue)
        // your logic
    };

    const OnEdit = async () => {
        try {
            const requestOptions = {
                method: 'PATCH',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    meetingId: props.id,
                    date: props.date,
                    description: state,
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
                <input className="border-2 border-gray-300 p-2 my-2" type="text" placeholder="Description" value={state} onChange={onChange} />
                <button className="bg-white hover:bg-gray-100 text-gray-800 font-semibold py-2 px-4 border border-gray-400 rounded shadow" onClick={OnEdit}>
                    <span>Submit</span>
                </button>
            </form>
        </div>
    );
}

export default FormEditMeeting;
