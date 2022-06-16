import * as React from 'react';
import { connect } from 'react-redux';
import GameSection from './GameSection';

const Home = () => (
  <div>
        <h1 className="title">DAMNATION ONLINE!</h1>
        <GameSection/>
  </div>
);

export default connect()(Home);
