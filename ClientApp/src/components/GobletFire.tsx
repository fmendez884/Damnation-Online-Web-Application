import React from "react";
// import ReactDom from "react-dom"
// import { connect } from "react-redux";

import gobletFire from "./goblet-fire.gif";

export default class GobletFire extends React.Component {
    render() {
        return (
            <div>
                <img className="gobletFireImage" src={gobletFire} alt="leave me the fuck alone pls for the love of god pls"></img>
            </div>
        );
    }
}