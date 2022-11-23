import React,{useState, useEffect} from "react";
import { useAuth0 } from "@auth0/auth0-react";
import LogOut from "../components/LogOut";
import CardComponent from "../components/CardComponent";
import Navbar from "../components/Navbar";
import Footer from "../components/Footer/Footer";

const UserProfile = () => {
    const { user, isAuthenticated,getAccessTokenSilently, isLoading } = useAuth0();
    const [userMetadata, setUserMetadata] = useState(null);
    const [posts, setPosts] = useState([])

    useEffect(() => {
        const getUserMetadata = async () => {

            try {
                const accessToken = await getAccessTokenSilently({
                    audience: `https://lingofikaapi.azurewebsites.net`,
                    scope: "read:messages",
                });
                console.log(accessToken + "accessToken")

                const userDetailsByIdUrl = `https://lingofikaapi.azurewebsites.net/api/User/private-scoped`;

                const metadataResponse = await fetch(userDetailsByIdUrl, {
                    headers: {
                        Authorization: `Bearer ${accessToken}`,
                    },
                });

                const { user_metadata } = await metadataResponse.json();

                setUserMetadata(user_metadata);
            } catch (e) {
                console.log(e.message);
            }
        };

        getUserMetadata()
            .then(r => console.log(r));
    }, [getAccessTokenSilently, user?.sub]);

    useEffect(() => {
        fetch('https://lingofikaapi.azurewebsites.net/api/Meeting')
            .then(response => response.json())
            .then(data => setPosts(data));

    }, [])


    if (isLoading) {
        return <div>Loading ...</div>;
    }

    return (
        isAuthenticated && (
            <div>
                <Navbar />
                <h1 className={"font-medium leading-tight text-8xl mt-0 mb-2 text-blue-900"}>LingoFika</h1>
                <h3 className={"font-medium text-2xl"}>Find Events</h3>
                <p>{posts.map((post) => (
                    <div>
                        <CardComponent language={post.language} location={post.location} date={post.date}/>
                    </div>
                ))}</p>

                <LogOut />
                <Footer />

            </div>
        )
    );
};


export default UserProfile;
