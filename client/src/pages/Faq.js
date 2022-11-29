
import React from 'react'
import { Disclosure } from '@headlessui/react'
import Footer from "../components/Footer/Footer";





const Faq = () => {

    const faq = [
        {
            number: 1,
            question: "What is Languini?",
            answer: "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Neque veritatis deserunt, praesentium impedit provident amet laudantium quibusdam a saepe atque odio, quidem quia eos ab aperiam quos! Officia, ducimus temporibus!"
        },
        {
            number: 2,
            question: "How to use Languini?",
            answer: "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Neque veritatis deserunt, praesentium impedit provident amet laudantium quibusdam a saepe atque odio, quidem quia eos ab aperiam quos! Officia, ducimus temporibus!"
        },
        {
            number: 3,
            question: "Is Languini free?",
            answer: "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Neque veritatis deserunt, praesentium impedit provident amet laudantium quibusdam a saepe atque odio, quidem quia eos ab aperiam quos! Officia, ducimus temporibus!"
        },
        {
            number: 4,
            question: "How to sign up on Languini?",
            answer: "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Neque veritatis deserunt, praesentium impedit provident amet laudantium quibusdam a saepe atque odio, quidem quia eos ab aperiam quos! Officia, ducimus temporibus!"
        },
        {
            number: 5,
            question: "Can I contribute to the project?",
            answer: "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Neque veritatis deserunt, praesentium impedit provident amet laudantium quibusdam a saepe atque odio, quidem quia eos ab aperiam quos! Officia, ducimus temporibus!"
        }
    ]

    return (
        <div className="w-full">

            {/* :TITLE & IMAGE */}
            <div className="my-8 mx-auto max-w-4xl flex flex-col items-center">
                <img src="https://fancytailwind.com/static/faq1-8ef2a6c2addbed9f838eea20b9ad21b6.png" alt="Frequently Asked Questions" className="w-full h-full" />
                <h2 className="text-center text-2xl sm:text-4xl text-gray-600 tracking-widest">Frequently Asked Questions</h2>
            </div>

            {/* :FAQ */}
            <dl className="mx-auto mb-10 p-2 max-w-4xl flex flex-col items-center">
                {/* ::Accordion Panel */}
                {
                    faq.map(faq => (
                        <Disclosure key={faq.number} >
                            {({ open }) => (
                                <>
                                    {/* Question */}
                                    <dt className={`group w-full text-xl border-b-2 border-gray-50 font-bold text-black hover:bg-gray-200 hover:text-black rounded-xl hover:rounded-lg ${open && "text-white"}`}>
                                        <Disclosure.Button className="py-5 px-3 w-full flex justify-between items-center">
                                            <span className="text-lg md:text-xl text-left font-semi-bold">{faq.question}</span>
                                        </Disclosure.Button>
                                    </dt>
                                    {/* Answer */}
                                    <dd className="w-full text-base text-gray-500">
                                        <Disclosure.Panel className="px-4 pt-4 pb-2">
                                            {faq.answer}
                                        </Disclosure.Panel>
                                    </dd>
                                </>
                            )}
                        </Disclosure>
                    ))
                }
            </dl>
            <Footer />

        </div>
    )
}

export default Faq
