import React from 'react'


const ChangingText = () => {
    return (
        <div className="text-gray-500 text-4xl text-center font-bold uppercase flex flex-col justify-around">
            <span>Welcome to</span>
            <div className="overflow-hidden h-14">
                <div className="animate-slide"><span className="inline-block text-white py-1 px-3 mt-1 mb-11 bg-cyan-600">Languini</span></div>
                <div><span className="inline-block text-white py-1 px-3 mb-11 bg-cyan-500">Languini</span></div>
                <div><span className="inline-block text-white py-1 px-3 mb-11 bg-cyan-400">Languini</span></div>
            </div>
            <span></span>
        </div>
    )
}

export default ChangingText
