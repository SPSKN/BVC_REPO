///
/// message-page.js
///

import React, { Component } from 'react'

export class MessagePage extends Component {

	///
	render() {

		const Message = this.props.message;

		return (

			<div className="x-center-y-center-column" style={{ padding:'2.0rem', textAlign:'center' }}>

				{Message}

			</div>
	
		);

	}

}
