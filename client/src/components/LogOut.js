import React from "react";
import { useAuth0 } from "@auth0/auth0-react";

const LogOut = () => {
    const { logout } = useAuth0();

    return (
        <button className="text-gray-800 text-sm font-semibold hover:text-cyan-600 mr-4" onClick={() => logout({ returnTo: window.location.origin })}>
            Log Out
        </button>
    );
};

export default LogOut;
