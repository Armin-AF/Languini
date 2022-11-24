import {NavLink} from 'react-router-dom';
import LogOut from "./LogOut";

const NavigationBar = () => {
    return (
        <nav className='flex justify-end gap-5 mr-5'>
            <NavLink to="/events">Events</NavLink>
            <NavLink to="/profile">Profile</NavLink>
            <NavLink to="/about">About</NavLink>
            <NavLink to="/create_event">Create Event</NavLink>
            <LogOut />
        </nav>
    );
};

export default NavigationBar;
