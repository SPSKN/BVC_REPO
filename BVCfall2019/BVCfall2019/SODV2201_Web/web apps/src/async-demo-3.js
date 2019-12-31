import React, { Component } from 'react';

/// AsyncDemo3
export class AsyncDemo3 extends Component {

	///
	async q() {

		/// Create a new promise (future return function).
		let P = new Promise((resolve, reject) => {

			// Using a timer, make the promise resolve (complete) after a time delay.  Note the closure.
			setTimeout( () => resolve("The time delay is over!"), 2000)

		});
	
		//
		return await P; 				// Wait until the promise P resolves (*).

	}

	///
	async componentDidMount() {
		let B = await this.q();
		alert(B);			 			// After calling the async "q" function!
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
