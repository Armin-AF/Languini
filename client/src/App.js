import React, { useState } from "react";
import './App.css';
import { Landing } from "./pages/Landing";
import { Register } from "./components/Register";

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
        <Events />
        </>
      }
    </div>
  );
}

export default App;
