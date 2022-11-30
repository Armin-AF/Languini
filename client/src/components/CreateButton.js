import React from "react";
import CreateEvent from "../pages/CreateEvent";

const Modal = (props) => {
  const [showModal, setShowModal] = React.useState(false);

  const Close = () => {
    CloseModal();
  }

  const CloseModal = () => setShowModal(false);

  return (
    <>
      <button className="bg-cyan-500 hover:bg-cyan-400 text-white font-medium px-4 py-1 w-60 h-10 text-sm border border-gray-400 rounded-lg shadow active:scale-[0.95] active:duration-75 transition-all" type="button" onClick={() => setShowModal(true)}>Create Event</button>
      {showModal ? (
        <>
          <div
            className="justify-center items-center flex overflow-x-hidden overflow-y-auto fixed inset-0 z-50 outline-none focus:outline-none"
          >
            <div className="relative w-auto my-6 mx-auto max-w-3xl">
              <div className="border-0 rounded-lg shadow-lg relative flex flex-col w-full bg-white outline-none focus:outline-none">
                <div className="flex items-start justify-between p-5 border-b border-solid border-slate-200 rounded-t">
                  <h3 className="text-3xl font-semibold">
                    Create Event
                  </h3>
                </div>
                <div className="relative p-6 flex-auto">
                  <div className="my-4 text-slate-500 text-lg leading-relaxed">
                    <CreateEvent close={Close} reload2={props.reload1} />
                  </div>
                </div>
                <div className="flex items-center justify-end p-6 border-t border-solid border-slate-200 rounded-b">
                  <button
                    className="text-red-500 background-transparent font-bold uppercase px-6 py-2 text-sm outline-none focus:outline-none mr-1 mb-1 ease-linear transition-all duration-150"
                    type="button"
                    onClick={CloseModal}
                  >
                    Close
                  </button>
                </div>
              </div>
            </div>
          </div>
          <div className="opacity-25 fixed inset-0 z-40 bg-black"></div>
        </>
      ) : null}
    </>
  );
}

export default Modal;
