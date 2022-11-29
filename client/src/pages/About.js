import Footer from "../components/Footer/Footer";

const About = () => {
  return (
    <div>
      <section className="relative z-10 overflow-hidden bg-white py-20 lg:py-[120px]">
        <div className="container mx-auto">
          <div className="-mx-4 flex flex-wrap lg:justify-between">
            <div className="w-full px-4 lg:w-1/2 xl:w-6/12">
              <div className="mb-12 max-w-[570px] lg:mb-0">
                
                
                
                
                <h1 className="text-dark mb-1 text-xl font-bold">About Us</h1>

                <p className="text-body-color mb-9 text-base leading-relaxed">
                  We are a Stockholm based scale up, started at Salt, school of applied technology. We are currently a
                  small core team of four people.
                </p>
                <div className="mb-8 flex w-full max-w-[370px]">
                  <div
                    className="bg-primary text-primary mr-6 flex h-[60px] w-full max-w-[60px] items-center justify-center overflow-hidden rounded bg-opacity-5 sm:h-[70px] sm:max-w-[70px]"
                  >

                  </div>
                  <div className="w-full">
                    <h4 className="text-dark mb-1 text-xl font-bold">Our Mission</h4>
                    <p className="text-body-color text-base">
                      At Languini we are all about connecting people. Our mission is encouraging curios people to
                      connect, enabling learning new languages and finding new friends!
                      We hope you will have a great time using our services.

                    </p>
                  </div>
                </div>
                <div className="mb-8 flex w-full max-w-[370px]">
                  <div
                    className="bg-primary text-primary mr-6 flex h-[60px] w-full max-w-[60px] items-center justify-center overflow-hidden rounded bg-opacity-5 sm:h-[70px] sm:max-w-[70px]"
                  >

                  </div>
                  <div className="w-full">
                    <h4 className="text-dark mb-1 text-xl font-bold">The Team</h4>
                    <p className="text-body-color text-base">
                      Maximiliano Barrientos, Eric Rosén, Dean Timmins and Armin Afazeli.

                    </p>
                  </div>
                </div>
                <div className="mb-8 flex w-full max-w-[370px]">
                  <div
                    className="bg-primary text-primary mr-6 flex h-[60px] w-full max-w-[60px] items-center justify-center overflow-hidden rounded bg-opacity-5 sm:h-[70px] sm:max-w-[70px]"
                  >

                  </div>
                  <div className="w-full">
                    <h4 className="text-dark mb-1 text-xl font-bold">Contact Us</h4>
                    <p className="text-body-color text-base">info@linguini.com</p>
                  </div>
                </div>
              </div>
            </div>
         
          </div>
        </div>
      </section> 
      <Footer/>

    </div>
  );
}

export default About;
