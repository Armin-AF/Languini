import React from "react";
import { useAuth0 } from "@auth0/auth0-react";


const LoginButton = () => {
    const { loginWithRedirect } = useAuth0();

    return (
        <div>
                <button id='access' className= "bg-white hover:bg-gray-100 text-gray-800 font-semibold py-2 px-4 border border-gray-400 rounded shadow active:scale-[0.95] active:duration-75 transition-all"
                        type="submit" onClick={() => loginWithRedirect()}>Access</button>
        </div>
    );
};

export default LoginButton;
