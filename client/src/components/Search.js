import React from 'react'
import { useState } from 'react'

const SearchBar = ({ posts, setSearchResults }) => {

    const [searchTerm, setSearchTerm] = useState('')

    const handleSubmit = (e) => e.preventDefault()

    const handleSearchChange = (e) => {
        setSearchTerm(e.target.value)

        if (!e.target.value) return setSearchResults(posts)

        const resultsArray = posts.filter(post => post.language.toLowerCase().includes(e.target.value.toLowerCase()))

        setSearchResults(resultsArray)
    }

    return (
        <div className="pt-2 relative mx-auto text-gray-600">
            <form onSubmit={handleSubmit}>
                <input className="border-2 border-gray-300 bg-white h-10 px-5 pr-16 rounded-lg text-sm focus:outline-none"
                    type="search" name="search" placeholder="Enter language" value={searchTerm} onChange={handleSearchChange} />
                <button type="submit" className="absolute right-0 top-0 mt-5 mr-4">
                </button>
            </form>
        </div>
    )
}

export default SearchBar

