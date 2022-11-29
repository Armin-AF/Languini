import { NavLink } from 'react-router-dom';
import LogOut from "./LogOut";
import logo from '../assets/BrandNameAndLogoHorisonal.png';

const NavigationBar = () => {
    return (
        <div className='bg-white shadow'>
            <div className='container mx-auto px-4'>
                <div className='flex items-center justify-between py-4'>
                    <div>
                        <img className='w-50 h-10' src={logo}  alt={"Remember dean"}/>
                    </div>
                    <div className='hidden sm:flex sm:items-center'>
                        <nav>
                            <NavLink to="/events" className="text-gray-800 text-sm font-semibold hover:text-cyan-600 mr-4" >Events</NavLink>
                            <NavLink to="/profile" className="text-gray-800 text-sm font-semibold hover:text-cyan-600 mr-4">Profile</NavLink>
                            <NavLink to="/about" className="text-gray-800 text-sm font-semibold hover:text-cyan-600 mr-4">About</NavLink>
                            <NavLink to={"/faq"} className="text-gray-800 text-sm font-semibold hover:text-cyan-600 mr-4">FAQ</NavLink>
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

