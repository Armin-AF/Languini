import React from "react";
import './App.css';
import Events from "./pages/Events";
import {useAuth0} from "@auth0/auth0-react";
import {Landing} from "./pages/Landing";
import { Routes, Route } from 'react-router-dom';
import NavigationBar from "./components/NavigationBar";
import Profile from "./pages/Profile";
import About from "./pages/About";
import CreateEvent from "./pages/CreateEvent";
import Loading from "./components/Loading";
import EditEvent from "./pages/EditEvent";
import FaQ from "./pages/Faq";
import ContactPage from "./pages/ContactPage";
import background from './assets/white-gold-geometric-pattern-background-vector_53876-140726BL.jpg';

function App() {
  const { isAuthenticated, isLoading } = useAuth0();

  return (
      <div style={{ backgroundImage: `url(${background})`}}>
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
                    <Route path="/faq" element={<FaQ />} />
                    <Route path="/ContactPage" element={<ContactPage />} />

                </Routes>
            </div>}
      </div>
  );
}

export default App;
