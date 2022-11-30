import React from "react";
import Footer from "../components/Footer/Footer";
import ItemContainer from "../components/Footer/ItemContainer";

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
                            <p className="mt-1 dark:text-gray-400">Lorem ipsum dolor, sit amet consectetur adipisicing elit. Ratione, fugit? Aspernatur, ullam enim, odit eaque quia rerum ipsum voluptatem consequatur ratione, doloremque debitis? Fuga labore omnis minima, quisquam delectus culpa!</p>
                        </div>
                        <div>
                            <h3 className="font-semi-bold text-black">Our Mission</h3>
                            <p className="mt-1 dark:text-gray-400">At Languini we are all about connecting people. Our mission is encouraging curios people to connect, enabling learning new languages and finding new friends! We hope you will have a great time using our services.</p>
                        </div>
                        <div>
                            <h3 className="font-semi-bold text-black">The Team</h3>
                            <p className="mt-1 dark:text-gray-400">Armin Afazeli, Dean Timmins,  Eric Rosén and Maximiliano Barrientos</p>
                        </div>
                        <div>
                            <h3 className="font-semi-bold text-black">Contact Us</h3>
                            <p className="mt-1 dark:text-gray-400">info@linguini.com</p>
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
