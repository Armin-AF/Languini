import Footer from "../components/Footer/Footer";
import React, {useEffect, useState} from "react";
import {useAuth0} from "@auth0/auth0-react";

const Profile = () => {

    const [userMetadata, setUserMetadata] = useState(null);
    const { user, isAuthenticated,getAccessTokenSilently, isLoading } = useAuth0();

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
            <div>
                <h1 className={"font-medium leading-tight text-8xl mt-0 mb-2 text-blue-900"}>LingoFika</h1>
                <h3 className={"font-medium text-2xl"}>Profile</h3>
                <div className={"font-medium text-2xl"}>{userMetadata}</div>
                <Footer />
            </div>
        )
    );
};

export default Profile;
