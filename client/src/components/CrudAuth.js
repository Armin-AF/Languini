import {useAuth0} from "@auth0/auth0-react";
// import {useEffect, useState} from "react";

const GetUser = async () => {

  const {getAccessTokenSilently} = useAuth0();

  try {
    const accessToken = await getAccessTokenSilently({
      audience: `https://lingofikaapi.azurewebsites.net`,
    });

    const apiUrl = `https://lingofikaapi.azurewebsites.net/api/User`;

    const requestOptions = {
      method: 'GET',
      headers: {
        'Content-Type': 'application/json',
        Authorization: `Bearer ${accessToken}`,
      },
    };

    await fetch(apiUrl, requestOptions)
      .then(response => response.json())
  } catch (e) {
    console.log(e.message);
  }
}

const CreateUser = async () => {

  const {getAccessTokenSilently} = useAuth0();

  try {
    const accessToken = await getAccessTokenSilently({
      audience: `https://lingofikaapi.azurewebsites.net`,
    });

    const apiUrl = `https://lingofikaapi.azurewebsites.net/api/User`;

    const requestOptions = {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
        Authorization: `Bearer ${accessToken}`,
      },
      body: JSON.stringify({nota: 'ponemos lo que sea basado en el modelo'})
    };

    await fetch(apiUrl, requestOptions)
      .then(response => response.json())
  } catch (e) {
    console.log(e.message);
  }
}

const UpdateUser = async () => {

  const {getAccessTokenSilently} = useAuth0();

  try {
    const accessToken = await getAccessTokenSilently({
      audience: `https://lingofikaapi.azurewebsites.net`,
    });

    const apiUrl = `https://lingofikaapi.azurewebsites.net/api/User`;

    const requestOptions = {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json',
        Authorization: `Bearer ${accessToken}`,
      },
      body: JSON.stringify({nota: 'ponemos lo que sea basado en el modelo'})
    };

    await fetch(apiUrl, requestOptions)
      .then(response => response.json())
  } catch (e) {
    console.log(e.message);
  }
}

const DeleteUser = async (id) => {

  const {getAccessTokenSilently} = useAuth0();

  try {
    const accessToken = await getAccessTokenSilently({
      audience: `https://lingofikaapi.azurewebsites.net`,
    });

    const apiUrl = `https://lingofikaapi.azurewebsites.net/api/User/${id}`;

    const requestOptions = {
      method: 'DELETE',
      headers: {
        'Content-Type': 'application/json',
        Authorization: `Bearer ${accessToken}`,
      },
    };

    await fetch(apiUrl, requestOptions)
      .then(response => response.json())
  } catch (e) {
    console.log(e.message);
  }
}

/* const [userMetadata, setUserMetadata] = useState(null);
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

      setUserMetadata(allUsers);
    } catch (e) {
      console.log(e.message);
    }
  };

  getUserMetadata().then();
}, [getAccessTokenSilently, user?.sub]); */

export default {GetUser, CreateUser, UpdateUser, DeleteUser};
