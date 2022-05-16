import React from "react";
// import ReactDom from "react-dom"
// import { connect } from "react-redux";

// import DamnationWebPlayer from "./DamnationWebPlayer";
import GobletFire from "./GobletFire";
import GameContainer from "./GameContainer";


export default class GameSection extends React.Component {
    render() {
        return (
            <div className="GameSection">
                <GobletFire></GobletFire>
                <GameContainer></GameContainer>
                {/* <DamnationWebPlayer></DamnationWebPlayer> */}
                <GobletFire></GobletFire>
            </div>
        );
    }
}