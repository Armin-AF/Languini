import {NavLink} from 'react-router-dom';
import LogOut from "./LogOut";

const NavigationBar = () => {
    return (
        <nav>
            <NavLink to="/events">Events</NavLink>
            <NavLink to="/profile">Profile</NavLink>
            <NavLink to="/about">About</NavLink>
            <LogOut />
        </nav>
    );
};

export default NavigationBar;
