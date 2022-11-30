import React,{useState} from "react";
import { useAuth0 } from "@auth0/auth0-react";

const FormEditMeeting = (props) => {

    const { user } = useAuth0();
    const [state, setState] = useState(props.description);


    let onChange = (e) => {
        let newValue = e.target.value;
        setState(newValue)
    };

    const OnEdit = async (e) => {
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
            await fetch(`https://lingofikaapi.azurewebsites.net/api/Meeting` , requestOptions)
              .then(props.reloadEdit)
              .then(props.close)
              .then(e.preventDefault())
        } catch (e) {
            console.log(e.message);
        }
    }

    return (
        <div>
            <form className="flex flex-col justify-center my-10">
                <input className="border-2 border-gray-300 p-2 my-2 text-gray-500 text-sm" type="text" placeholder="Description" value={state} onChange={onChange} />
                <button className="bg-cyan-500 hover:bg-cyan-400 text-white font-medium px-2 py-1 text-sm border border-gray-400 rounded shadow active:scale-[0.95] active:duration-75 transition-all h-8" onClick={OnEdit}>
                    <span>Submit</span>
                </button>
            </form>
        </div>
    );
}

export default FormEditMeeting;
