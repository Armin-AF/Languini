import Footer from "../components/Footer/Footer";
import {useAuth0} from "@auth0/auth0-react";
import Loading from "../components/Loading";

const Profile = () => {

  const {user, isAuthenticated, isLoading } = useAuth0();

  return (
    isAuthenticated && (
      <>
        {isLoading ? <div><Loading/></div> :
          
          <div className="my-40 w-96 h-96 pt-6 mx-auto space-y-5 flex flex-col items-center rounded overflow-hidden shadow-lg ">
              <img className="w-24 h-24 mb-3 rounded-full shadow-lg" src={user.picture} alt="PROFILE"/>
              <h5 className="text-lg text-gray-500 dark:text-darkgray-400">{user.given_name} {user.family_name}</h5>
              <span className="text-sm text-gray-500 dark:text-darkgray-400">{user.email}</span>
              <span className="text-sm text-gray-500 dark:text-darkgray-400">Username: {user.nickname}</span>
              <span className="text-sm text-gray-500 dark:text-darkgray-400">Language: {user.locale}</span>
                            
          </div>}
          
        <Footer/>
      </>
    )
  );
};

export default Profile;
