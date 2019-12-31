
/// Import modules required by this module.
import React, { Component } from 'react';

/// App
class App extends Component {

	/// Add a component constructor.
	constructor(props) {
		super(props);
		this.state = { Count:0 };
		this.OnTimerExpired = this.OnTimerExpired.bind(this);
	}

	/// In this lifecycle method, initialize a timer.
	componentDidMount() {
		console.log("The componentDidMount method executed.");
		setInterval(this.OnTimerExpired, 1000);
	}

	/// This method is the callback for the interval timer.
	OnTimerExpired() {

		console.log("The OnTimerExpired method executed.  Oh, and by the way, here's 'this':");
		console.log(this);

		//this.state.Count += 1;   WRONG

		// Sample the current state and increment the count.
		let NewCount = this.state.Count + 1;

		// And use the React method setState to update it.
		this.setState({
			Count:NewCount
		});

	}

	/// Add a render method to render something for this component.
	render() {

		console.log("The render method executed.");

		/// Sample the state.
		let CurrentCount = this.state.Count;

		/// Build the markup.
		return(
			<div>
				{CurrentCount}
			</div>
		);

	}

}

export default App;
