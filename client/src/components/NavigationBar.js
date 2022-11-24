import {NavLink} from 'react-router-dom';
import LogOut from "./LogOut";
import logo from '../assets/logo_transparent_favicon.png';

const NavigationBar = () => {
    return (
        <nav className='flex justify-end gap-5 mr-5'>
            <NavLink to="/events" className="pt-2" >Events</NavLink>
            <NavLink to="/profile" className="pt-2">Profile</NavLink>
            <NavLink to="/about" className="pt-2">About</NavLink>
            <NavLink to="/create_event" className="pt-2">Create Event</NavLink>
            <LogOut />
            <img className='h-10' src={logo} alt='logo'/>
        </nav>
    );
};

export default NavigationBar;
