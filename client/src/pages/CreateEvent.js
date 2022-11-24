import React,{useRef} from "react";

const CreateEvent = () => {
    const inputDate = useRef(null);
    const inputDescription = useRef(null);
    const inputLocation = useRef(null);
    const inputLanguage = useRef(null);
    const onButtonClick = () => {
        inputDate.current.focus();
        console.log(inputDate.current.value);
        //inputEl.current.value.clear()
    };

    return (
        <>
            <input ref={inputDate} type="date" />
            <input ref={inputDescription} type="text" />
            <input ref={inputLocation} type="text" />
            <input ref={inputLanguage} type="text" />
            <button onClick={onButtonClick}>Submit</button>
        </>
    );
}

export default CreateEvent;
