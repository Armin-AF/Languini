import React, { useState } from "react";
import loginImg from "../assets/learning1.jpg";

export const Register = (props) => {
  const [email, setEmail] = useState("");
  const [pass, setPass] = useState("");
  const [name] = useState("");

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
          <h2 className="text-4xl font-bold text-center py-6">App Name</h2>

          <div className="flex flex-col py-2">
            <label className="font-semibold">Full Name</label>
            <input
              className="border p-2 rounded-2xl"
              type="text"
              placeholder="Email"
              id="email"
              name="email"
            />
          </div>
          <div className="flex flex-col py-2">
            <label className="font-semibold">Email</label>
            <input
              className="border p-2 rounded-2xl"
              value={name}
              onChange={(e) => setEmail(e.target.value)}
              type="text"
              placeholder="Full Name"
              id="name"
              name="name"
            />
          </div>
          <div className="flex flex-col py-2">
            <label className="font-semibold">Password</label>
            <input
              className="border p-2 rounded-2xl"
              value={pass}
              onChange={(e) => setPass(e.target.value)}
              type="password"
              placeholder="Password"
              id="password"
              name="password"
            />
          </div>
          <button
            className="border w-full my-5 py-3 bg-violet-500 hover:bg-violet-400 text-white rounded-2xl font-semibold active:scale-[0.95] active:duration-75 transition-all"
            type="submit"
          >
            Submit
          </button>
          <button className="font-semibold" onClick={() => props.onFormSwitch("login")}>
            Back to login
          </button>
        </form>
      </div>
    </div>
  );
};
