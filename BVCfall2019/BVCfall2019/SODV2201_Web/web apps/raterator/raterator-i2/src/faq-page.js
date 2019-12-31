///
/// FaqPage
///

import React, { Component } from 'react'

///
/// Props:
/// navigate - callback function to advise parent that a navigation is requested.
///
export class FaqPage extends Component {

	///
	OnClickDoneButton = () => {
		if (this.props.navigate) this.props.navigate("main");
	}
	
	///
	render() {

		return (

			<div>

				<h1>Got questions?  We have answers!</h1>

				<button className="rectangular" onClick={this.OnClickDoneButton}>Done</button>

			</div>

		);

	}

}
