import React,{useState, useEffect} from "react";
import { useAuth0 } from "@auth0/auth0-react";
import CardComponent from "../components/CardComponent";
import Navbar from "../components/Navbar";
import Footer from "../components/Footer/Footer";
import SearchBar from "../components/Search";
import CardList from "../components/CardList";

const UserProfile = () => {
    const { user, isAuthenticated,getAccessTokenSilently, isLoading } = useAuth0();
    const [userMetadata, setUserMetadata] = useState(null);
    const [posts, setPosts] = useState([])
    const [searchResults, setSearchResults] = useState([])

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

                const { user_metadata } = await metadataResponse.json().then(j => {
                    console.log(j)
                    setUserMetadata(j)
                });
                console.log(user_metadata)
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
            .then(data => {setPosts(data)
                setSearchResults(data)})}, [])


    if (isLoading) {
        return <div>Loading ...</div>;
    }

    const usersApi = JSON.stringify(userMetadata)
    console.log(usersApi)

    return (
        isAuthenticated && (
            <div>
                <Navbar />
                <h1 className={"font-medium leading-tight text-8xl mt-0 mb-2 text-blue-900"}>LingoFika</h1>
                <h3 className={"font-medium text-2xl"}>Find Events</h3>
                <SearchBar posts={posts} setSearchResults={setSearchResults} />
                <CardList searchResults={searchResults} />
                <Footer />

            </div>
        )
    );
};


export default UserProfile;
