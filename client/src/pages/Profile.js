import Footer from "../components/Footer/Footer";

const Profile = () => {
    return (
<<<<<<< Updated upstream
        <div>

            <h1>Profile</h1>
            <Footer />
        </div>
=======
        isAuthenticated && (
            <div>
                <h1 className={"font-medium leading-tight text-8xl mt-0 mb-2 text-blue-900"}>LingoFika</h1>
                <h3 className={"font-medium text-2xl"}>Profile</h3>
                <div className={"font-medium text-2xl"}>{userMetadata}</div>
                <div>First Name: {user.given_name}</div>
                <div>Family Name: {user.family_name}</div>
                <div>Email: {user.email}</div>
                <div>NickName: {user.nickname}</div>
                <div>Language: {user.locale}</div>
                <div><img src={user.picture} alt="Profile" /></div>

                <Footer />
            </div>
        )
>>>>>>> Stashed changes
    );
}

export default Profile;
