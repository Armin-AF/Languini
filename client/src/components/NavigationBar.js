import { NavLink } from 'react-router-dom';
import LogOut from "./LogOut";
import logo from '../assets/logo_transparent_favicon.png';
import brand from '../assets/BrandName_Only.png';

const NavigationBar = () => {
    return (
        <div className='bg-white shadow'>
            <div className='container mx-auto px-4'>
                <div className='flex items-center justify-between py-4'>
                    <div className='w-10 h-10'>
                        <img src={logo} />
                    </div>
                    <div className='hidden sm:flex sm:items-center'>
                        <nav>
                            <NavLink to="/events" className="text-gray-800 text-sm font-semibold hover:text-cyan-600 mr-4" >Events</NavLink>
                            <NavLink to="/profile" className="text-gray-800 text-sm font-semibold hover:text-cyan-600 mr-4">Profile</NavLink>
                            <NavLink to="/about" className="text-gray-800 text-sm font-semibold hover:text-cyan-600 mr-4">About</NavLink>
                            <NavLink to="/create_event" className="text-gray-800 text-sm font-semibold hover:text-cyan-600 mr-4">Create Event</NavLink>
                        </nav>
                        <div>
                            <LogOut />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default NavigationBar;

