import Footer from "../components/Footer/Footer";
import ItemContainer from "../components/Footer/ItemContainer";

const About = () => {
  return (
    <div>
      <section className="bg-white py-20 lg:py-[150px] grid place-items-center">
       
              <div className="mb-12 max-w-[570px] lg:mb-0">



                <div className="mb-8 flex w-full max-w-[400px]">

                   <div className="w-full">
                    <h4 className="text-dark mb-1 text-xl font-bold ">About Us</h4>
                    <p className="text-body-color text-base text-sm text-gray-500">
                      We are a Stockholm based scale up, started at Salt, school of applied technology. We are currently a
                      small core team of four people.
                    </p>
                  </div>
                </div>




                <div className="mb-8 flex w-full max-w-[400px]">

                   <div className="w-full">
                    <h4 className="text-dark mb-1 text-xl font-bold ">Our Mission</h4>
                    <p className="text-body-color text-base text-sm text-gray-500">
                      At Languini we are all about connecting people. Our mission is encouraging curios people to
                      connect, enabling learning new languages and finding new friends!
                      We hope you will have a great time using our services.
                    </p>
                  </div>
                </div>


                <div className="mb-8 flex w-full max-w-[400px]">

                   <div className="w-full">
                    <h4 className="text-dark mb-1 text-xl font-bold ">The Team</h4>
                    <p className="text-body-color text-base text-sm text-gray-500">
                       Maximiliano Barrientos, Eric Rosén, Dean Timmins and Armin Afazeli.
                    </p>
                  </div>
                </div>


                <div className="flex w-full max-w-[400px]">

                   <div className="w-full">
                    <h4 className="text-dark mb-1 text-xl font-bold ">Contact Us</h4>
                    <p className="text-body-color text-base text-sm text-gray-500">
                        info@linguini.com
                    </p>
                  </div>
                </div>



            
        </div>
        <div className="mt-10"> <ItemContainer />  </div>
      </section>
      <Footer/>

    </div>
  );
}

export default About;
