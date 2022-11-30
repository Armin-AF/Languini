import React, { useState, useEffect } from "react";
import { useAuth0 } from "@auth0/auth0-react";
import Footer from "../components/Footer/Footer";
import SearchBar from "../components/Search";
import CardList from "../components/CardList";
import Loading from "../components/Loading";
import { Link } from "react-router-dom";
import CreateButton from "../components/CreateButton";
import ChangingText from "../components/ChangingText";

const Events = () => {
  const { isAuthenticated } = useAuth0();
  const [posts, setPosts] = useState([]);
  const [searchResults, setSearchResults] = useState([]);
  const [loading, setLoading] = useState(true);


  useEffect(() => {
      try {
        fetch('https://localhost:7057/api/Meeting')
          .then(response => response.json())
          .then(data => {
            setPosts(data)
            setSearchResults(data)
          })
      } catch (e) {
        console.log(e.message);
      }
      setLoading(false);

  }, [])

  const Reload = async () => {
    try {
      await fetch('https://localhost:7057/api/Meeting')
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

  return (
    isAuthenticated && (
      <div>
          <div className={"mt-10"}><ChangingText /></div>
        <h1 className="text-gray-500 text-sm sm:text-sm text-center font-bold uppercase flex flex-col justify-around mt-8">Search for a language to begin. Can't find a suitable event? Simply create your own!</h1>
        <div className="flex justify-center my-10 space-x-40">
        <CreateButton reload1={Reload}/>
          <SearchBar posts={posts} setSearchResults={setSearchResults} />
        </div>

        {loading ? <div>< Loading /></div> :
          <CardList searchResults={searchResults} reload={Reload} />}
        <Footer />

      </div>
    )
  );
};
export default Events;
