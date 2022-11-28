import React, { useState, useEffect } from "react";
import { useAuth0 } from "@auth0/auth0-react";
import Footer from "../components/Footer/Footer";
import SearchBar from "../components/Search";
import CardList from "../components/CardList";
import Loading from "../components/Loading";
import { Link } from "react-router-dom";

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
          .then(data => {
            setPosts(data)
            setSearchResults(data)
          })
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
        <h1 className="text-3xl text-center font-bold text-gray-800 mt-10">Welcome to Languini</h1>
        <h1 className="text-1xl text-center font-bold text-gray-800 mt-10">Search for a language to begin. Can't find a suitable event? Simply create your own!</h1>
        <div className="flex justify-center my-10 align-middle">
          <SearchBar posts={posts} setSearchResults={setSearchResults} />
          <Link to="/create_event">
          <button className="bg-cyan-400 px-3 py-1 rounded-lg text-xs font-medium text-gray-800 lg:w-20 h-10 mt-5 ml-5 modal">Create</button>
          </Link>
        </div>
        {loading ? <div>< Loading /></div> :
          <CardList searchResults={searchResults} />}
        <Footer />

      </div>
    )
  );
};
export default Events;
