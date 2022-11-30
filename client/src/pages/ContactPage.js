import React from "react";
import Footer from "../components/Footer/Footer";

const ContactPage = () => {
  return (
    <div>
      <div>
      <link rel="stylesheet" href="https://cdn.tailgrids.com/tailgrids-fallback.css" />

<section className="xl:py-[120px]  sm:pt-[5px] overflow-hidden relative z-10 ">
   <div className="container ">
      <div className="flex flex-wrap lg:justify-between -mx-4 ">
         <div className="w-full lg:w-1/2 xl:w-6/12 px-4 ">
            <div className="max-w-[570px] mb-12 lg:mb-0">

               <h2
                  className="text-dark mb-1 text-xl font-bold pt-20"
                  >
                  GET IN TOUCH WITH US
               </h2>
               <p className="text-base text-body-color leading-relaxed mb-9 text-sm text-gray-500">
                  At Languini we are all about connecting people. Do you need to come in contact with us, please fill out the form!
               </p>

            </div>
         </div>
         <div className="w-full lg:w-1/2 xl:w-5/12 px-4">
            <div className="bg-white relative rounded-lg p-8 sm:p-12 shadow-lg">
               <form>
                  <div className="mb-6">
                     <input
                        type="text"
                        placeholder="Your Name"
                        className="
                        w-full
                        rounded
                        py-3
                        px-[14px]
                        text-body-color text-base
                        border border-[f0f0f0]
                        outline-none
                        focus-visible:shadow-none
                        focus:border-cyan-500
                        "
                        />
                  </div>
                  <div className="mb-6">
                     <input
                        type="email"
                        placeholder="Your Email"
                        className="
                        w-full
                        rounded
                        py-3
                        px-[14px]
                        text-body-color text-base
                        border border-[f0f0f0]
                        outline-none
                        focus-visible:shadow-none
                        focus:border-cyan-500
                        "
                        />
                  </div>
                  <div className="mb-6">
                     <input
                        type="text"
                        placeholder="Your Phone"
                        class="
                        w-full
                        rounded
                        py-3
                        px-[14px]
                        text-body-color text-base
                        border border-[f0f0f0]
                        outline-none
                        focus-visible:shadow-none
                        focus:border-cyan-500
                        "
                        />
                  </div>
                  <div className="mb-6">
                     <textarea
                        rows="6"
                        placeholder="Your Message"
                        className="
                        w-full
                        rounded
                        py-3
                        px-[14px]
                        text-body-color text-base
                        border border-[f0f0f0]
                        resize-none
                        outline-none
                        focus-visible:shadow-none
                        focus:border-cyan-500
                        "
                        ></textarea>
                  </div>
                  <div>
                     <button
                        type="submit"
                        className=" w-full
                        text-white
                        bg-cyan-500
                        rounded
                        color
                        border border-cyan-500
                        p-3
                        transition
                        hover:bg-opacity-90 "

                        >
                     Send Message
                     </button>
                  </div>
               </form>
               <div>
                  <span className="absolute -top-10 -right-9 z-[-1]">
                     <svg
                        width="100"
                        height="100"
                        viewBox="0 0 100 100"
                        fill="none"
                        >
                        <path
                           fillRule="evenodd"
                           clipRule="evenodd"
                           d="M0 100C0 44.7715 0 0 0 0C55.2285 0 100 44.7715 100 100C100 100 100 100 0 100Z"
                           fill="#37b5d8"
                           />
                     </svg>
                  </span>

               </div>
            </div>
         </div>
      </div>
   </div>
</section>
      </div>
      <Footer/>
    </div>
  );
}

export default ContactPage;
