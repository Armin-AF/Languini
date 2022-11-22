import React from "react";

const CardComponent = (props) => {
    return (
        <div className="w-full p-2 rounded-lg shadow-xl lg:flex lg:max-w-lg">
            <img
                className="object-cover w-full lg:w-40 lg:h-40"
                src="https://i.picsum.photos/id/192/2352/2352.jpg?hmac=jN5UExysObV7_BrOYLdxoDKzm_c_lRM6QkaInKT_1Go"
                alt="image"
            />
            <div className="pl-2">
                <h4 className="text-xl font-semibold tracking-tight text-blue-600">
                    Language
                </h4>
                <p className="mb-2 leading-normal">
                    lorem ipsum dolor sit amet, consectetur adipiscing elit.
                </p>
                <button className="px-4 py-2 text-sm text-blue-100 bg-blue-500 rounded shadow">
                    Join
                </button>
            </div>
        </div>
    );
}

export default CardComponent;
