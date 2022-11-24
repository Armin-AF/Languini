import Footer from "../components/Footer/Footer";
import React, { useEffect, useState } from "react";
import { useAuth0 } from "@auth0/auth0-react";

const Profile = () => {

    const [userMetadata, setUserMetadata] = useState(null);
    const { user, isAuthenticated, getAccessTokenSilently, isLoading } = useAuth0();

    useEffect(() => {
        const getUserMetadata = async () => {

            try {
                const accessToken = await getAccessTokenSilently({
                    audience: `https://lingofikaapi.azurewebsites.net`,
                });
                console.log(accessToken + "accessToken")

                const userDetailsByIdUrl = `https://lingofikaapi.azurewebsites.net/api/User`;

                const metadataResponse = await fetch(userDetailsByIdUrl, {
                    headers: {
                        Authorization: `Bearer ${accessToken}`,
                    },
                });

                const allUsers = await metadataResponse.json();

                const firstName = allUsers[1].firstName;
                setUserMetadata(firstName);
            } catch (e) {
                console.log(e.message);
            }
        };

        getUserMetadata();
    }, [getAccessTokenSilently, user?.sub]);

    if (isLoading) {
        return <div>Loading ...</div>;
    }


    return (
        isAuthenticated && (
            <>
                <div className="mt-40 mb-40 space-y-5 flex flex-col items-center pb-10">
                    <img className="w-24 h-24 mb-3 rounded-full shadow-lg" src={user.picture} alt="PROFILE image"/>
                    <h5 className="text-lg text-gray-500 dark:text-darkgray-400">{user.given_name} {user.family_name}</h5>
                    <span className="text-sm text-gray-500 dark:text-darkgray-400">{user.email}</span>
                    <span className="text-sm text-gray-500 dark:text-darkgray-400">{user.nickname}</span>
                    <span className="text-sm text-gray-500 dark:text-darkgray-400">{user.locale}</span>
                    <div className="flex mt-4 space-x-3 md:mt-6">
                        <a href="#"
                           className="inline-flex items-center px-4 py-2 text-sm font-medium text-center text-white bg-blue-700 rounded-lg hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">
                            Edit</a>
                    </div>
                </div>
            <Footer />
            </>
        )
    );
};

export default Profile;
