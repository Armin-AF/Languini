import React,{useState, useEffect} from "react";
import { useAuth0 } from "@auth0/auth0-react";
import Footer from "../components/Footer/Footer";
import SearchBar from "../components/Search";
import CardList from "../components/CardList";
import brandname from "../assets/BrandName_Only.png";
import Loading from "../components/Loading";

const Events = () => {
    const { isAuthenticated } = useAuth0();
    const [posts, setPosts] = useState([]);
    const [searchResults, setSearchResults] = useState([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
       const getEvent = async () => {
         try {
           await fetch('https://lingofikaapi.azurewebsites.net/api/Meeting')
             .then(response => response.json())
             .then(data => {setPosts(data)
               setSearchResults(data)})
         } catch (e) {
           console.log(e.message);
         }
         setLoading(false);
       }
      getEvent().then();
    }, [])

    return (
        isAuthenticated && (
            <div>
                <div className="flex justify-center h-20 w-76 mt-10">
                <img
                src={brandname} alt='brand name'
                />
                </div>
                {/* <h1 className="font-medium leading-tight text-6xl mb-2 text-blue-900 mt-10">Languini</h1> */}
                <h3 className="font-medium text-2xl mt-10">Find Events</h3>
                <SearchBar posts={posts} setSearchResults={setSearchResults} />
                { loading ? <div>< Loading /></div> :
                <CardList searchResults={searchResults} />}
                <Footer />

            </div>
        )
    );
};


export default Events;
