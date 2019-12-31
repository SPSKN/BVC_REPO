///
/// MainPage
///

import React, { Component } from 'react'

///
/// Props:
/// history - the page history list (added by <BrowserRouter>).
///
export class MainPage extends Component {

	///
	OnClickFaqButton = () => {
		this.props.history.push("/faq");
	}

	///
	render() {

		return (

			<div>

				<h1>This is the main page of the application.</h1>

				<button className="rectangular" onClick={this.OnClickFaqButton}>FAQ</button>

			</div>

		);

	}

}
