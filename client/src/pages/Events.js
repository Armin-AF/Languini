import React,{useState, useEffect} from "react";
import { useAuth0 } from "@auth0/auth0-react";
import Footer from "../components/Footer/Footer";
import SearchBar from "../components/Search";
import CardList from "../components/CardList";

const Events = () => {
    const { isAuthenticated, isLoading } = useAuth0();
    const [posts, setPosts] = useState([])
    const [searchResults, setSearchResults] = useState([])



    useEffect(() => {
        fetch('https://lingofikaapi.azurewebsites.net/api/Meeting')
            .then(response => response.json())
            .then(data => {setPosts(data)
                setSearchResults(data)})}, [])


    if (isLoading) {
        return <div>Loading ...</div>;
    }

    return (
        isAuthenticated && (
            <div>
                <h1 className="font-medium leading-tight text-8xl mt-0 mb-2 text-blue-900">LingoFika</h1>
                <h3 className="font-medium text-2xl mt-10">Find Events</h3>
                <div className="mt-5">
                <SearchBar posts={posts} setSearchResults={setSearchResults} />
                </div>
                <div className="mt-10">
                <CardList searchResults={searchResults} />
                </div>
                <Footer />

            </div>
        )
    );
};


export default Events;
