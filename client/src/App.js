import React from "react";
import './App.css';
import Events from "./pages/Events";
import {useAuth0} from "@auth0/auth0-react";
import {Landing} from "./pages/Landing";
import { Routes, Route, Link } from 'react-router-dom';
import NavigationBar from "./components/NavigationBar";
import Profile from "./pages/Profile";
import About from "./pages/About";
import CreateEvent from "./pages/CreateEvent";
import Loading from "./components/Loading";
import EditEvent from "./pages/EditEvent";

function App() {
  const { isAuthenticated, isLoading } = useAuth0();

  return (
      <div className="App">
        { isLoading? <Loading /> : !isAuthenticated ? (
                <div>
                    <Landing />
                </div>
            ) :
            <div>
                <NavigationBar />
                <Routes>
                    <Route path="/" element={<Events />} />
                    <Route path="/events" element={<Events />} />
                    <Route path="/profile" element={<Profile />} />
                    <Route path="/about" element={<About />} />
                    <Route path="/create_event" element={<CreateEvent />} />
                    <Route path="/edit_event/:id" element={<EditEvent />} />

                </Routes>
            </div>}
      </div>
  );
}

export default App;
