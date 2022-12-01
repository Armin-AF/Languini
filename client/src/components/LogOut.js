import React from "react";
import { useAuth0 } from "@auth0/auth0-react";

const LogOut = () => {
    const { logout } = useAuth0();

    return (
        <button className="bg-red-500 hover:bg-red-800 text-white font-medium px-2 py-1 text-sm border border-gray-400 rounded shadow active:scale-[0.95] active:duration-75 transition-all w-24" onClick={() => logout({ returnTo: window.location.origin })}>
            Log Out
        </button>
    );
};

export default LogOut;
