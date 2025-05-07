import React from 'react';
import { createRoot } from 'react-dom/client';
import App from './App';
import Partners from './WhoWeServe/Partners';
import WhomWeServe from './WhoWeServe/WhomWeServe';
import WhyChooseUS from './AboutUS/WhyChooseUs';
import ContactInfo from './Contacts/ContactInfo';
import Mission from './AboutUs/Mission';
import Expertise from './WhatWeDo/Expertise'
import Delivery from './WhatWeDo/Deliver';

const container = document.getElementById('react-root');
if (container) {
    const root = createRoot(container);
    root.render(<App />);
}

// Render for mission page
const missionContainer = document.getElementById('mission-root');
if (missionContainer) {
    const missionroot = createRoot(missionContainer);
    missionroot.render(<Mission />);
}

// Render for WhyChooseUs page
const whyusContainer = document.getElementById('whyus-root');
if (whyusContainer) {
    const whyusroot = createRoot(whyusContainer);
    whyusroot.render(<WhyChooseUS />);

}

// Render for ContactInfo page

const contactContainer = document.getElementById('contact-root');
if (contactContainer) {
    const contactroot = createRoot(contactContainer);
    contactroot.render(<ContactInfo />);
}

// Render for Delivery page
const deliveryContainer = document.getElementById('delivery-root');
if (deliveryContainer) {
    const deliveryroot = createRoot(deliveryContainer);
    deliveryroot.render(<Delivery />);

}

// Render for expertise page
const expertiseContainer = document.getElementById('expertise-root');
if (expertiseContainer) {
    const expertiseroot = createRoot(expertiseContainer);
    expertiseroot.render(<Expertise />);
}


// Render for Partners page
const partnersContainer = document.getElementById('partners-root');
if (partnersContainer) {
    const partnersroot = createRoot(partnersContainer);
    partnersroot.render(<Partners />);
}

// Render for WhomWeServe page
const serveContainer = document.getElementById('WhomWeServe-root');
if (serveContainer) {
    const whomweserveroot = createRoot(serveContainer);
    whomweserveroot.render(<WhomWeServe />);
}








