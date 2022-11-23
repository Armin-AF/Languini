import React from "react";
import { useAuth0 } from "@auth0/auth0-react";


const LoginButton = () => {
    const { loginWithRedirect } = useAuth0();

    return (
        <div className="grid grid-cols-1 sm:grid-cols-2 h-screen w-full">
            <div className="flex flex-col py-2">
                <button className="border w-full my-5 py-3 bg-violet-500 hover:bg-violet-400 text-white rounded-2xl font-semibold active:scale-[0.95] active:duration-75 transition-all"
                        type="submit" onClick={() => loginWithRedirect()}>Access</button>
            </div>
        </div>
    );
};

export default LoginButton;
