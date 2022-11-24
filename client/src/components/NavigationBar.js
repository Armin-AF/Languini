import {NavLink} from 'react-router-dom';
import LogOut from "./LogOut";
import logo from '../assets/logo_transparent_favicon.png';

const NavigationBar = () => {
    return (
        <nav className='flex justify-end gap-5 mr-5'>
            <NavLink to="/events">Events</NavLink>
            <NavLink to="/profile">Profile</NavLink>
            <NavLink to="/about">About</NavLink>
            <LogOut />
            <img className='h-10' src={logo} alt='logo'
            />
        </nav>
    );
};

export default NavigationBar;
