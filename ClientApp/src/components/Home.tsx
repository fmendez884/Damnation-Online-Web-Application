import * as React from 'react';
import { connect } from 'react-redux';
import GameSection from './GameSection';

const Home = () => (
  <div>
        <h1>DAMNATION ONLINE!</h1>
        <h1> the ol testerooni </h1>
        <GameSection/>
  </div>
);

export default connect()(Home);
