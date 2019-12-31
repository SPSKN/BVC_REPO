import React, { Component } from 'react';

/// AsyncDemo4
export class AsyncDemo4 extends Component {

	///
	async GetListings() {

		// Define the API endpoint (what server and what service are we going to call?).
		const ApiEndpoint = "http://s28.ca/sodv1201/coworking/listings";

		// Build the API request (what filters will we send with the request?).
		const ApiRequest = {
			ListingId: 0,		// Filter on any listing.
			OwnerId: 0,			// Any owner.
			CityName:'',		// Any city.
			ListingType:'',		// Any listing type.
			Available:1,		// Available or rented.
			MaxPrice:0,			// No maximum price.
			Amenities:''		// Any set of amenities.
		}

		// Send a POST request to the API endpoint, including the API request data.  This starts 
		// a "promise" -- which is a guarantee to return later with some information.  The promise
		// is complete when the API call finishes (or when it hits an error).
		let ApiResponse = await fetch(ApiEndpoint, { method:'POST', body:JSON.stringify(ApiRequest) });

		// When the promise resolves, convert the HTTP reply from JSON to a JS object and log it.
		let Reply = await ApiResponse.json();

		// Let's have a look...
		console.log(Reply);

	};

	///
	async componentDidMount() {
		await this.GetListings();
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
