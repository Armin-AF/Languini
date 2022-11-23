import React from "react";
import ItemsContainer from "./ItemContainer";

const Footer = () => {
    return (
        <footer className="bg-gray-900 text-white">

            <ItemsContainer />
            <div
                className="flex justify-center gap-40 px-10 pb-10"
            >
                <span>© 2022 School of Applied Technology. All rights reserved.</span>

            </div>
        </footer>
    );
};

export default Footer;
