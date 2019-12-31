import React, { Component } from 'react';

/// AsyncDemo2
export class AsyncDemo2 extends Component {

	///
	async f() {							// async = encase return value in a promise.
		return "An async operation is now complete.";
	}

	///
	async componentDidMount() {
		let A = await this.f();
		alert(A);			 			// No hidden secret required!  This code is much easier to follow.
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
