import React, { useState } from "react";
import loginImg from "../assets/learning1.jpg";
import AccessComponent from "../components/AccessComponent";

export const Landing = (props) => {
  const [email, setEmail] = useState("");

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
          <h1 className="text-6xl font-semibold text-center py-8">Introducing LINDER</h1>
          <p>"Learn a second language" and find new friends 🍆💦</p>
          <AccessComponent />
        </form>
      </div>
    </div>
  );
};
