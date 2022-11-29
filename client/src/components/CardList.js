import CardComponent from "./CardComponent";

const CardList = (props) => {
    props.searchResults.sort((a,b) => { return new Date(a.date) - new Date(b.date)})
    const results = props.searchResults.map((event, index) => <div key={index}><CardComponent language={event.language} location={event.location} date={event.date} id={event.meetingId} creatorEmail={event.creatorEmail} description={event.description} reload1={props.reload}/></div>)
    const content = results?.length ? results : <article><p>No Matching Events</p></article>
    return (
        <main >{content}</main>
    )
}

export default CardList
