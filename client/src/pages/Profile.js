import Footer from "../components/Footer/Footer";
import React, { useEffect, useState } from "react";
import { useAuth0 } from "@auth0/auth0-react";
import CardComponent from "../components/CardComponent";

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
            <div className="mt-14 mb-12 space-y-5 font-medium text-1xl">
                <div className={"flex flex-wrap justify-center"}><img className={"max-w-full h-auto rounded-full"} src={user.picture} alt="Profile" /></div>
                <div>First Name: {user.given_name}</div>
                <div>Family Name: {user.family_name}</div>
                <div>Email: {user.email}</div>
                <div>Username: {user.nickname}</div>
                <div>Language: {user.locale}</div>
            </div>
            <Footer />
            </>
        )
    );
};

export default Profile;
