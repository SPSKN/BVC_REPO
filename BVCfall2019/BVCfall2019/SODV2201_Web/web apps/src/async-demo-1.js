import React, { Component } from 'react';

/// AsyncDemo1
export class AsyncDemo1 extends Component {

	///
	async f() {							// async = encase return value in a promise.
		return "An async operation is now complete.";
	}

	///
	componentDidMount() {
		this.f().then(alert); 			// The hidden secret here is that the callback is called with the return value of f(), which is 1.
	}

	///
	render() {

		return (

			<main>
				<div className="x-centered-y-centered-column">
					NO CONTENT
				</div>
			</main>

		);

	}

}
