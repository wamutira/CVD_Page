
 import React from 'react';
    import Mission from './AboutUs/Mission';
    import Expertise from './WhatWeDo/Expertise';
    import Partners from './WhoWeServe/Partners';
    import ContactInfo from './Contacts/ContactInfo';
   

    export default function App() {
        return (
            <div>
                
                <h1>Welcome to CVD</h1>

                <section>
                    <h2>About Us</h2>
                    <Mission />
                </section>

                <section>
                    <h2>What We Do</h2>
                    <Expertise />
                </section>

                <section>
                    <h2>Partners</h2>
                    <Partners />
                </section>

                <section>
                    <h2>Contacts</h2>
                    <ContactInfo />
                </section>
            </div>
        );
    }


