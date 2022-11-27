import CardComponent from "./CardComponent";

const CardList = ({searchResults}) => {
    const results = searchResults.map((event, index) => <div key={index}><CardComponent language={event.language} location={event.location} date={event.date} id={event.meetingId}/></div>)
    const content = results?.length ? results : <article><p>No Matching Events</p></article>
    return (
        <main className="grid sm:grid-cols-1 md:grid-cols-2 lg:grid-cols-4 mt-10">{content}</main>
    )
}

export default CardList
