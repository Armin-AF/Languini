import React, {useRef} from "react";
import {useNavigate} from "react-router-dom";
import { useAuth0 } from "@auth0/auth0-react";

const CreateEvent = (props) => {
    const inputDate = useRef(null);
    const inputDescription = useRef(null);
    const inputLocation = useRef(null);
    const inputLanguage = useRef(null);
    const navigate = useNavigate();
    const { user } = useAuth0();

    const onButtonClick = () => {
        inputDate.current.focus();
        inputDescription.current.focus();
        inputLocation.current.focus();
        inputLanguage.current.focus();

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

        fetch('https://localhost:7057/api/Meeting', requestOptions)
            .then(response => {response.json()
                console.log(response)})
            .then(() => props.reload2());

        props.close();
    };

    return (
        <>
            <div className="grid grid-cols-1 mb-10 space-x-1 space-y-1">
                <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-80" ref={inputDate} type="datetime-local"/>
                <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-80" ref={inputDescription} type="text" placeholder="Description"/>
                <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-80" ref={inputLocation} type="text" placeholder="Location"/>
                <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-80" ref={inputLanguage} type="text" placeholder="Language"/>
            </div>
            <button className="bg-white hover:bg-gray-100 text-gray-800 font-semibold py-2 px-4 border border-gray-400 rounded shadow" onClick={onButtonClick}>Submit</button>
        </>
    );
}

export default CreateEvent;
