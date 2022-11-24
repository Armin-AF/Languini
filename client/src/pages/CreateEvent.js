import React, {useRef} from "react";

const CreateEvent = () => {
    const inputDate = useRef(null);
    const inputDescription = useRef(null);
    const inputLocation = useRef(null);
    const inputLanguage = useRef(null);
    const onButtonClick = () => {
        inputDate.current.focus();
        inputDescription.current.focus();
        inputLocation.current.focus();
        inputLanguage.current.focus();
        //inputLanguage.current.value.clear()


        const requestOptions = {
            headers: { 'Content-Type': 'application/json' },
            method: 'POST',
            body: JSON.stringify({
                date: inputDate.current.value,
                description: inputDescription.current.value,
                location: inputLocation.current.value,
                language: inputLanguage.current.value
            })
        };
        console.log(requestOptions)
        fetch('https://lingofikaapi.azurewebsites.net/api/Meeting', requestOptions)
            .then(response => {response.json()
                console.log(response)});
    };


    return (
        <div className="grid gap-6 mb-6 grid-cols-1 mt-20">
            <h1 className={"justify-center"}> Create a new event ☕️</h1>
            <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-1/2" ref={inputDate} type="datetime-local"/>
            <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-1/2" ref={inputDescription} type="text" placeholder="Description"/>
            <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-1/2" ref={inputLocation} type="text" placeholder="Location"/>
            <input className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 w-1/2" ref={inputLanguage} type="text" placeholder="Language"/>
            <button className="bg-gray-300 hover:bg-gray-400 text-gray-800 font-bold py-2 px-4 inline-flex items-center w-1/2 justify-center rounded-lg" onClick={onButtonClick}>Submit</button>
        </div>
    );
}

export default CreateEvent;
