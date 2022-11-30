import React, {useRef} from "react";
import { useAuth0 } from "@auth0/auth0-react";

const CreateEvent = (props) => {
    const inputDate = useRef(null);
    const inputDescription = useRef(null);
    const inputLocation = useRef(null);
    const inputLanguage = useRef(null);
    const { user } = useAuth0();

    const onButtonClick = () => {
        inputDate.current.focus();
        inputDescription.current.focus();
        inputLocation.current.focus();
        inputLanguage.current.focus();

        if( new Date(inputDate.current.value) < (Date.now() + 2*60*60*1000) )
        {
            return;
        }

        if (!(inputDate.current.value && inputDescription.current.value && inputLocation.current.value &&
         inputLanguage.current.value))
        {
            return;
        }

        const requestOptions = {
            headers: { 'Content-Type': 'application/json' },
            method: 'POST',
            body: JSON.stringify({
                date: inputDate.current.value,
                description: inputDescription.current.value,
                location: inputLocation.current.value,
                language: inputLanguage.current.value,
                creatorEmail: user.email
            })
        };

        fetch('https://lingofikaapi.azurewebsites.net/api/Meeting', requestOptions)
            .then(response => {response.json()
                console.log(response)})
            .then(() => props.reload2());

        props.close();
    };

    return (
        <>
            <div className="grid grid-cols-1 mb-10 space-x-1 space-y-1">

                <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-80 ml-1 peer border border-slate-400" placeholder="Date" ref={inputDate} type="datetime-local" required={true} />


                <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-80 peer border border-slate-400" ref={inputDescription} type="text" placeholder="Description" required={true} />

                <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-80 peer border border-slate-400" ref={inputLocation} type="text" placeholder="Location" required={true} />

                <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-80 peer border border-slate-400" ref={inputLanguage} type="text" placeholder="Language" required={true} />

                <p className="invisible peer-invalid:visible text-red-700 font-light font-thin text-sm">
                    All fields are required
                </p>
            </div>
            <button className="bg-cyan-500 hover:bg-cyan-400 text-white font-medium px-2 py-1 text-sm border border-gray-400 rounded shadow active:scale-[0.95] active:duration-75 transition-all h-8 w-full" onClick={onButtonClick}>Submit</button>
        </>
    );
}

export default CreateEvent;
