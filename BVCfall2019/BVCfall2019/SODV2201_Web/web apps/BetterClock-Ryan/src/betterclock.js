/// Import modules required by this module.
/// The { } means import a named component (not the default one).
import React, { Component } from 'react';

/// BetterClock
/// Create an independent class to represent a better clock component.  Note we use "export"
/// to make this component available to the the world (for $15).
export class BetterClock extends Component {

	///
	constructor(props) {
		super(props);
		this.state = { CurrentTime:null };
	}

	///
	componentDidMount() {
		console.log("[BetterClock] The componentDidMount method executed.");
		setInterval(this.OnTimerExpired, 1000);
	}

	/// This method is the callback for the interval timer.
	OnTimerExpired = () => {

		console.log("[BetterClock] The OnTimerExpired method executed.");

		//this.state.CurrentTime = ...   // WRONG -- React will not react to this state change.

		// Sample the current time.
		let CurrentTime = (new Date()).toLocaleString();

		// ...and use the React setState method to update state.
		this.setState({
			CurrentTime:CurrentTime
		});

	}

	/// All React components have a render method which must return something.
	render() {

		console.log("[BetterClock] Render.");

		// Sample the current time as recorded in the component's state.
		const Now = this.state.CurrentTime;

		// Form markup to display the state.  THERE MUST BE ONLY ONE ROOT ELEMENT.
		return(
			<div>
				{Now}
			</div>
		)

	}

}
