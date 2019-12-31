///
/// ProductPage
///

import React, { Component } from 'react'

///
/// Props:
/// history - the page history list (added by <BrowserRouter>).
///
export class ProductPage extends Component {

	///
	OnClickDoneButton = () => {
		this.props.history.goBack();
	}
	
	///
	render() {

		const { id } = this.props.match.params;

		return (

			<div>

				<h1>Here is information on product {id}.</h1>

				<button className="rectangular" onClick={this.OnClickDoneButton}>Done</button>

			</div>

		);

	}

}
