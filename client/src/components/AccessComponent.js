import React from "react";
import { useAuth0 } from "@auth0/auth0-react";


const LoginButton = () => {
    const { loginWithRedirect } = useAuth0();

    return (
        <div>
            <button id='access' className="w-full bg-cyan-500 hover:bg-cyan-400 text-white font-semibold py-2 px-4 border border-gray-400 rounded shadow active:scale-[0.95] active:duration-75 transition-all mb-20"
                type="submit" onClick={() => loginWithRedirect()}>Access</button>
        </div>
    );
};

export default LoginButton;
