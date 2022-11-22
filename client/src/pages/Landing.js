import React, { useState } from "react";
import loginImg from "../assets/learning1.jpg";

export const Landing = (props) => {
  const [email, setEmail] = useState("");
  const [pass, setPass] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log(email);
  };

  return (
    <div className="grid grid-cols-1 sm:grid-cols-2 h-screen w-full">
      <div className="hidden sm:block">
        <img
          className="w-full h-full object-cover opacity-50"
          src={loginImg}
          alt="people learning"
        />
      </div>
      <div className="bg-gray-100 flex flex-col justify-center">
        <form
          className="max-w-[400px] w-full mx-auto bg-white p-4 rounded-3xl"
          onSubmit={handleSubmit}
        >
          <h1 className="text-4xl font-semibold text-center py-6">Introducing App Name</h1>
          <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tristique in justo vel scelerisque. Aenean sed laoreet ante, in volutpat.</p>
          <button
            className="border w-full my-3 py-3 bg-violet-500 hover:bg-violet-400 text-white rounded-2xl font-semibold active:scale-[0.95] active:duration-75 transition-all"
            type="submit"
          >
            Log in
          </button>
          <button
            className="border w-full my-3 py-3 bg-violet-500 hover:bg-violet-400 text-white rounded-2xl font-semibold active:scale-[0.95] active:duration-75 transition-all"
            type="submit"
          >
            Sign up
          </button>
        </form>
      </div>
    </div>
  );
};
