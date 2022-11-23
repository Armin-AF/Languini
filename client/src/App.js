import React from "react";
import './App.css';
import AccessComponent from "./components/AccessComponent";
import UserProfile from "./pages/UserProfile";
import {useAuth0} from "@auth0/auth0-react";
import {Landing} from "./pages/Landing";

function App() {
  const { isAuthenticated } = useAuth0();

  return (
      <div className="App">
        {!isAuthenticated ? (
                <div>
                    <Landing />
                  <AccessComponent />
                </div>
            ) :
            <div>

              <UserProfile />
            </div>}
      </div>
  );
}

export default App;
