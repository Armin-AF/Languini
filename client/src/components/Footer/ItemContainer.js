import Item from "./Item";
import { GITHUB, LINKEDIN, COMPANY } from "./Menus";
const ItemsContainer = () => {
    return (
        <div className="grid  grid-cols-1 sm:grid-cols-1 md:grid-cols-3 lg:grid-cols-3 gap-2 sm:px-8 px-5 py-16">

            <Item Links={GITHUB} title="GITHUB" />
            <Item Links={LINKEDIN} title="LINKEDIN" />
            <Item Links={COMPANY} title="COMPANY" />
        </div>
    );
};

export default ItemsContainer;
