import React, {useRef} from "react";
import Footer from "../components/Footer/Footer";
import {useNavigate} from "react-router-dom";
import { useAuth0 } from "@auth0/auth0-react";


const CreateEvent = () => {
    const { user } = useAuth0();
    const inputDate = useRef(null);
    const inputDescription = useRef(null);
    const inputLocation = useRef(null);
    const inputLanguage = useRef(null);
    const navigate = useNavigate();

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

        fetch('https://lingofikaapi.azurewebsites.net/api/Meeting', requestOptions)
            .then(response => {response.json()
                console.log(response)})
            .then(() => navigate('/events'));
    };

    return (
        <>
            <h1 className={"justify-center mt-20 font-medium"}> Create a new event ☕️</h1>
            <div className="mt-40 mb-10 space-x-1 space-y-1">
                <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-80 inline-flex" ref={inputDate} type="datetime-local"/>
                <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-80 inline-flex" ref={inputDescription} type="text" placeholder="Description"/>
                <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-80 inline-flex" ref={inputLocation} type="text" placeholder="Location"/>
                <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-80 inline-flex" ref={inputLanguage} type="text" placeholder="Language"/>
            </div>
            <button className="bg-gray-300 hover:bg-gray-400 text-gray-800 font-bold py-2 px-4 inline-flex items-center w-40 justify-center rounded-lg mb-40" onClick={onButtonClick}>Submit</button>
            <Footer />
        </>
    );
}

export default CreateEvent;
