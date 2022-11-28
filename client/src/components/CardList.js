import CardComponent from "./CardComponent";

const CardList = ({searchResults}) => {
    const results = searchResults.map((event, index) => <div key={index}><CardComponent language={event.language} location={event.location} date={event.date} id={event.meetingId} creatorEmail={event.creatorEmail}/></div>)
    const content = results?.length ? results : <article><p>No Matching Events</p></article>
    return (
        <main >{content}</main>
    )
}

export default CardList
