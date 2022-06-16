import React from "react";
// import ReactDom from "react-dom"
// import { connect } from "react-redux";

import gobletFire from "./goblet-fire.gif";

export default class GobletFire extends React.Component {
    render() {
        return (
            <div>
                <img className="gobletFireImage" src={gobletFire} alt="leave me alone pls"></img>
            </div>
        );
    }
}