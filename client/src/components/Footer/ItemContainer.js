import Item from "./Item";
import {LINKEDIN} from "./Menus";
const ItemsContainer = () => {
    return (
        <div className="grid grid-cols-1 gap-10 pt-10 pb-10 ">

            <Item Links={LINKEDIN} title="LINKEDIN" />
        </div>
    );
};

export default ItemsContainer;
