import React from "react";
import Footer from "../components/Footer/Footer";

const About = () => {

  return (
    <div>
        <div>
            <section className="text-gray-500">
                <div className="container flex flex-col justify-center p-4 mx-auto md:p-8 mt-20 mb-40">
                    <h2 className="mb-12 text-4xl font-bold leading-none text-center sm:text-5xl text-black">About Us</h2>
                    <p className="p-2 text-sm font-medium tracking-wider text-center uppercase mb-20"> We are a Stockholm based scale up, started at Salt, school of applied technology. We are currently a
                        small core team of four people.</p>
                    <div className="grid gap-10 md:gap-8 sm:p-3 md:grid-cols-2 lg:px-12 xl:px-32">
                        <div>
                            <h3 className="font-semi-bold text-black">History of Sc#ripted Away</h3>
                            <p className="mt-1 dark:text-gray-400">We are a group of four, joined up in the same mob at the .Net Bootcamp at SALT, in Stockholm. The name is derived from the amazing anime Spirited Away, by Hayao Miyazaki.</p>
                        </div>
                        <div>
                            <h3 className="font-semi-bold text-black">Our Mission</h3>
                            <p className="mt-1 dark:text-gray-400">At Sc#ripted Away we are all about connecting people. Our mission is encouraging curious people to connect, enabling learning new languages and finding new friends! We hope you will have a great time using our services.</p>
                        </div>
                        <div>
                            <h3 className="font-semi-bold text-black">The Team</h3>
                            <p className="mt-1 dark:text-gray-400">Armin Afazeli, Dean Timmins,  Eric Rosén and Maximiliano Barrientos</p>
                        </div>
                        <div>
                            <h3 className="font-semi-bold text-black">LinkedIn</h3>
                            <p className="mt-1 dark:text-gray-400"><a href= "https://www.linkedin.com/in/arminafazeli/" target="_blank" rel="noreferrer">Armin Afazeli</a></p>
                            <p className="mt-1 dark:text-gray-400"><a href= "https://www.linkedin.com/in/dean-timmins/" target="_blank" rel="noreferrer">Dean Timmins</a></p>
                            <p className="mt-1 dark:text-gray-400"><a href= "https://www.linkedin.com/in/eric-ros%C3%A9n-58789151/" target="_blank" rel="noreferrer">Eric Rosén</a></p>
                            <p className="mt-1 dark:text-gray-400"><a href= "https://www.linkedin.com/in/maximiliano-barrientos-nunez-964b03a7/" target="_blank" rel="noreferrer">Maximiliano Barrientos</a></p>

                        </div>
                    </div>
                </div>
            </section>
            <Footer />
        </div>
    </div>
  );
}

export default About;
