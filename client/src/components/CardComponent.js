import React from "react";
const CardComponent = (props) => {
    return (
        <div class="flex flex-col justify-center my-10">
            <div
                class="relative flex flex-col md:flex-row md:space-x-5 space-y-3 md:space-y-0 rounded-xl shadow-lg p-3 max-w-xs md:max-w-3xl mx-auto border border-white bg-white">
                <div class="w-full md:w-1/3 bg-white grid place-items-center">
                    <img src="https://i.picsum.photos/id/192/2352/2352.jpg?hmac=jN5UExysObV7_BrOYLdxoDKzm_c_lRM6QkaInKT_1Go" alt="venue" class="rounded-xl" />
                </div>
                <div class="w-full md:w-2/3 bg-white flex flex-col space-y-2 p-3">
                    <div class="flex justify-between item-center">
                        <p class="text-gray-600 font-bold md:block">{props.location}</p>
                        <div class="flex items-center">
                            <p class="text-gray-600 font-bold text-sm ml-1">
                                {props.date}
                            </p>
                        </div>
                        <button class="bg-cyan-400 px-3 py-1 rounded-full text-xs font-medium text-gray-800 md:block lg:w-20">Join</button>
                    </div>
                    <h3 class="font-black text-gray-800 md:text-2xl text-xl">{props.language}</h3>
                    <p class="md:text-lg text-gray-500 text-base">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis bibendum tortor id arcu iaculis, eu posuere arcu posuere. Aliquam non.</p>

                </div>
            </div>
        </div>
    );
};
export default CardComponent;
