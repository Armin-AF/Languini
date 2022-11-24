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
        <>
            <input ref={inputDate} type="datetime-local" />
            <input ref={inputDescription} type="text" />
            <input ref={inputLocation} type="text" />
            <input ref={inputLanguage} type="text" />
            <button onClick={onButtonClick}>Submit</button>
        </>
    );
}

export default CreateEvent;
