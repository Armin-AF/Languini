import React, {useState} from "react";
import { useAuth0 } from "@auth0/auth0-react";


const EditEvent = (props) => {
    const { user } = useAuth0();
    const [description, setDescription] = useState(props.description);


    const OnSubmit = async () => {
        try {
            const requestOptions = {
                method: 'PATCH',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    meetingId: props.id,
                    date: props.date,
                    description: description,
                    location: props.location,
                    language: props.language,
                    creatorEmail: user.email
                })
            };
            await fetch(`https://lingofikaapi.azurewebsites.net/api/Meeting` , requestOptions)
        } catch (e) {
            console.log(e.message);
        }
    }

  return (
      <div className="grid grid-cols-1 mb-10 space-x-1 space-y-1">
        <h1>Edit Event {props.language}</h1>
        <form onSubmit={OnSubmit} className={"flex flex-col justify-center bg-gray-50 border border-gray-300"}>
                Description:
                <input type="text" name="description" value={props.description} onChange={e => setDescription(e.target.value)} />
            <input type="submit" value="Submit" />
        </form>
    </div>
  );
}

export default EditEvent;
