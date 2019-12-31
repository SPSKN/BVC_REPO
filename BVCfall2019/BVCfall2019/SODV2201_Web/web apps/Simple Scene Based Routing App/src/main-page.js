///
/// MainPage
///

import React, { Component } from 'react'

///
/// Props:
/// navigate - callback function to advise parent that a navigation is requested.
///
export class MainPage extends Component {

	///
	OnClickFaqButton = () => {
		if (this.props.navigate) this.props.navigate("faq");
	}

	///
	render() {

		return (

			<div>

				<h1>This is the main page (scene) of the application.</h1>

				<button className="rectangular" onClick={this.OnClickFaqButton}>FAQ</button>

			</div>

		);

	}

}
