import CardComponent from "./CardComponent";

const CardList = ({searchResults}) => {
    const results = searchResults.map(event => <CardComponent language={event.language} location={event.location} date={event.date} />)
    const content = results?.length ? results : <article><p>No Matching Events</p></article>
    return (
        <main className="grid sm:grid-cols-1 md:grid-cols-2 lg:grid-cols-4 mt-10">{content}</main>
    )
}

export default CardList
