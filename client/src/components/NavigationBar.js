import { NavLink } from 'react-router-dom';
import LogOut from "./LogOut";
import logo from '../assets/BrandNameAndLogoHorisonal.png';
import {useAuth0} from "@auth0/auth0-react";

const NavigationBar = () => {

    const { user } = useAuth0();

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
                            <NavLink to="/about" className="text-gray-800 text-sm font-semibold hover:text-cyan-600 mr-4">About</NavLink>
                            <NavLink to={"/faq"} className="text-gray-800 text-sm font-semibold hover:text-cyan-600 mr-4">FAQ</NavLink>
                            <NavLink to={"/contactpage"} className="text-gray-800 text-sm font-semibold hover:text-cyan-600 mr-4">Contact</NavLink>


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
                </div>
            </div>
        </div>
    );
};

export default NavigationBar;

