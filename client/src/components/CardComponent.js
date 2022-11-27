import React from "react";
import Moment from 'react-moment';

const CardComponent = (props) => {
    return (
        <div className="w-full p-2 rounded-lg shadow-xl ">
            <img
                className="object-cover w-full mx-auto max-w-md rounded-lg"
                src="https://i.picsum.photos/id/192/2352/2352.jpg?hmac=jN5UExysObV7_BrOYLdxoDKzm_c_lRM6QkaInKT_1Go"
                alt="LOCATION"
            />
            <div className="pl-2">
                <h4 className="text-xl font-semibold tracking-tight text-blue-600">
                    {props.language}
                </h4>
                <p className="mb-2 leading-normal">
                    {props.location}
                </p>
                <p className="mb-2 leading-normal">
                  <Moment format="dddd MMMM Do YYYY, h:mm a">{props.date}</Moment>
                </p>
                <button className="px-4 py-2 text-sm text-blue-100 bg-blue-500 rounded shadow">
                    Join
                </button>
            </div>
        </div>
    );
}

export default CardComponent;
