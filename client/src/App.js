import React, { useState } from "react";
import './App.css';
import { Landing } from "./pages/Landing";

function App() {
  const [currentForm, setCurrentForm] = useState('login');

  const toggleForm = (formName) => {
    setCurrentForm(formName);
  }

  return (
    <div className="App">
      {
        <>
        <Landing />
        </>
      }
    </div>
  );
}

export default App;
