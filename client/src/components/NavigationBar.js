import { NavLink } from 'react-router-dom';
import LogOut from "./LogOut";
import logo from '../assets/BrandNameAndLogoHorisonal.png';
import logomobile from '../assets/logo_transparent_favicon.png';
import { useAuth0 } from "@auth0/auth0-react";

const NavigationBar = () => {

    const { user } = useAuth0();

    return (
        <div className='bg-gray-800 shadow'>
            <div className="mx-auto max-w-7xl px-2 sm:px-6 lg:px-8">
                <div className="relative flex h-16 items-center justify-between">

                    <div className="flex flex-shrink-0 items-center">
                        <img
                            className="block h-8 w-auto lg:hidden"
                            src={logomobile}
                            alt="Your Company"
                        />
                        <img
                            className="hidden h-8 w-auto lg:block"
                            src={logo}
                            alt="Your Company"
                        />
                    </div>
                    <div className='hidden sm:flex sm:items-center'>
                        <nav>
                            <NavLink to="/events" className="text-white text-sm font-semibold hover:text-cyan-600 mr-4" >Events</NavLink>
                            <NavLink to="/about" className="text-white text-sm font-semibold hover:text-cyan-600 mr-4">About</NavLink>
                            <NavLink to={"/faq"} className="text-white text-sm font-semibold hover:text-cyan-600 mr-4">FAQ</NavLink>
                            <NavLink to={"/contactpage"} className="text-white text-sm font-semibold hover:text-cyan-600 mr-4">Contact</NavLink>
                        </nav>

                        <div>
                            <NavLink to="/profile">
                                <span className="relative inline-block border-2 border-green-500 rounded-full" aria-label="avatar">
                                    <img src={user.picture} alt="" className="w-10 h-10 rounded-full" />
                                    <span className="absolute top-0 right-2 w-2 h-2 rounded-full bg-green-500 ring-2 ring-gray-50" />
                                    <span className="absolute top-0 right-2 w-2 h-2 rounded-full bg-green-500 animate-ping" />
                                </span>
                            </NavLink>
                        </div>
                    </div>

                    <nav className='lg:hidden md:hidden sm:flex justify-center content-center space-x-7'>
                        <NavLink to="/events" className="text-white text-sm font-medium hover:text-cyan-600" >Events</NavLink>
                        <NavLink to="/about" className="text-white text-sm font-medium hover:text-cyan-600">About</NavLink>
                        <NavLink to={"/faq"} className="text-white text-sm font-medium hover:text-cyan-600">FAQ</NavLink>
                        <NavLink to={"/contactpage"} className="text-white text-sm font-medium hover:text-cyan-600">Contact</NavLink>
                    </nav>
                    <NavLink to="/profile" className="lg:hidden md:hidden">
                            <span className="relative inline-block border-2 border-green-500 rounded-full" aria-label="avatar">
                                <img src={user.picture} alt="" className="w-auto h-8 rounded-full" />
                                <span className="absolute top-0 right-2 w-2 h-2 rounded-full bg-green-500 ring-2 ring-gray-50" />
                                <span className="absolute top-0 right-2 w-2 h-2 rounded-full bg-green-500 animate-ping" />
                            </span>
                        </NavLink>
                </div>
            </div>
        </div>
    );
};

export default NavigationBar;

