import React from "react";
import { useAuth0 } from "@auth0/auth0-react";

const LogOut = () => {
    const { logout } = useAuth0();

    return (
        <button className={"bg-blue-500 hover:bg-blue-400 text-white font-bold py-2 px-4 border-b-4 border-blue-700 hover:border-blue-500 rounded"} onClick={() => logout({ returnTo: window.location.origin })}>
            Log Out
        </button>
    );
};

export default LogOut;
