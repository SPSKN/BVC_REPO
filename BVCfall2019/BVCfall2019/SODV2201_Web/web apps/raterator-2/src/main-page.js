///
/// MainPage
///
import { HeadClass } from './header.js';
import CardsClass from './cards.js';
import React, { Component } from 'react'
import './index.css';

///
/// Props:
/// history - the page history list (added by <BrowserRouter>).
///
export class MainPage extends Component {

	///
	async fetchRating() {
		const ApiEndpoint = 'http://s28.ca/sodv2201/instructor/ratings';
		const ApiRequest={};
	
		let ApiResponse = await fetch(ApiEndpoint,{method:'POST',body:JSON.stringify(ApiRequest)});
		let Reply = await ApiResponse.json();
		console.log(Reply);
		//console.log(this.ApiResponse);
	}
	componentDidMount()
	{
		this.fetchRating();
	}
	///
	render() {

		return (

			<div>

				<HeadClass/>
			
				{this.props.model.Instruc.map(e=>(
					<CardsClass 
					model={this.props.model}
					I= {e.Instructor}
					ID= {e.InstructorSid}
					/>

				))}
				

			</div>

		);

	}

}
