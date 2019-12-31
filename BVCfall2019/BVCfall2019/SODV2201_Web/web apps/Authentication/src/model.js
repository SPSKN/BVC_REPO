import { observable } from 'mobx';

///
/// Model
///
export const Model = observable(
	
	{ EmailAddress:"", Password:"" }

);

//
// Login
//
Model.Login = async function() {

	try {

		// Endpoint.
		const Endpoint = "http://s28.ca/rest/bowspace/login";

		// Convert the payload to JSON.
		const ApiRequest = JSON.stringify(
			{
				EmailAddress:this.EmailAddress,
				Password:this.Password
			}
		);

		// Build out the request body.  The x-amz-* headers are required by AWS.
		let FetchData = { 
			method:'POST',
			mode:'cors', 
			cache:'no-cache', 
			credentials:'omit',
			headers: {
				'Content-Type': 'application/octet-stream',
				'Content-Length': ApiRequest.length,
			},
			body: ApiRequest
		};

		// Start the async call.
		//console.log("[model.js] Preparing to fetch/put, payload -->"); console.log(Endpoint); console.log(FetchData);
		let FetchReply = await fetch(Endpoint, FetchData);
		//console.log("Heard back from fetch/put --> "); console.log(FetchReply);

		// Extract the JSON API reply from the http response.  If the login is successful,
		// this reply will include a JWT which you need to decode.  Recall that a JWT contains 
		// three parts "header.payload.signature" and each part is encoded separately in base64.
		// Use string manipulation functions to split the string at the dots, and use the atob()
		// function to convert the payload from base64 (https://www.w3schools.com/jsref/met_win_atob.asp).
		let ApiReply = await FetchReply.json();
		//console.log("ApiReply --> "); console.log(ApiReply);
		let webToken = ApiReply.Jwt;
		//console.log("Web Token  "+localStorage.getItem("Courier"));
		localStorage.setItem("Courier",webToken);
		// Return true/false based on http status.
		return (FetchReply.status === 200);
		

	} catch(e) {

		console.log("Acess Denied"); console.log(e);
		
	}	

}

///
/// Reset
///
/// This method resets the model back to a known quiescent state.  It is often handy to have a reset 
/// function built-in to a model, since it relieves the view components from knowing what it means to
/// be reset -- instead, all they need to do is call this method.
/// 
Model.Reset = function() {

	this.EmailAddress = "";
	this.Password = "";

}

///
/// SetEmailAddress
///
Model.SetEmailAddress = function(newvalue) {
	this.EmailAddress = newvalue;
}

///
/// SetPassword
///
Model.SetPassword = function(newvalue) {
	this.Password = newvalue;
}

