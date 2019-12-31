///
/// FaqPage
///

import React, { Component } from 'react'

///
/// Props:
/// history - the page history list (added by <BrowserRouter>).
///
export class FaqPage extends Component {

	///
	OnClickDoneButton = () => {
		//this.props.history.push("/");
		this.props.history.goBack();
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
