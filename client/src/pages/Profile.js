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
                <div className={"font-medium text-2xl"}>First Name: {user.given_name}</div>
                <div className={"font-medium text-2xl"}>Family Name: {user.family_name}</div>
                <div className={"font-medium text-2xl"}>Email: {user.email}</div>
                <div className={"font-medium text-2xl"}>Username: {user.nickname}</div>
                <div className={"font-medium text-2xl"}>Language: {user.locale}</div>
                <div className={"flex flex-wrap justify-center"}><img className={"max-w-full h-auto rounded-lg"} src={user.picture} alt="Profile" /></div>

                <Footer />
            </div>
        )
    );
};

export default Profile;
