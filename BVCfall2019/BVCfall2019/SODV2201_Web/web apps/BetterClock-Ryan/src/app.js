
/// Import modules required by this module.
/// The { } means import a named component (not the default one).
import React, { Component } from 'react';
import { BetterClock } from './betterclock.js';

/// App
export class App extends Component {

	///
	render() {

		console.log("[App] Render");

		return (

			<div className="app">

				<h1>THIS IS A WAY BETTER CLOCK -- IT EVEN LIVES IN IT'S OWN JAVASCRIPT MODULE!</h1>

				<BetterClock />
				<BetterClock />

			</div>

		);

	}

}

//export default App;
