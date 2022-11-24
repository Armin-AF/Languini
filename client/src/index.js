import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import { Auth0Provider } from "@auth0/auth0-react";
import {BrowserRouter} from "react-router-dom";

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
    <Auth0Provider
        domain="dev-c8roe23ts7o24plt.us.auth0.com"
        clientId="i8742sIwgn1eDwgmqMcycWqg863Vccw5"
        redirectUri={window.location.origin}
    >
        <BrowserRouter>
        <App />
        </BrowserRouter>
    </Auth0Provider>
);


