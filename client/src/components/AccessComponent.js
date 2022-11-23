import React from "react";
import { useAuth0 } from "@auth0/auth0-react";


const LoginButton = () => {
    const { loginWithRedirect } = useAuth0();

    return (
        <div>
                <button className= "border w-full my-3 py-3 bg-violet-500 hover:bg-violet-400 text-white rounded-2xl font-semibold active:scale-[0.95] active:duration-75 transition-all"
                        type="submit" onClick={() => loginWithRedirect()}>Access</button>
        </div>
    );
};

export default LoginButton;
