///
/// MainPage
//import {Data} from './Data';
import { HeadClass } from './header.js';
import CardsClass from './cards.js';
import './index.css';
import React, { Component } from 'react';
//import {toJS} from 'mobx';
//import {App} from './app';
///
/// Props:
/// navigate - callback function to advise parent that a navigation is requested.
///
export class MainPage extends Component {

//ignore this
	constructor(props){
		super(props);
		this.props ={newItem:"", list:[]};
		//this.state = {Data: JSON.parse(Data)};
	}
	/*
	OnClickFaqButton = () => {
		if (this.props.navigate) this.props.navigate("faq");
	}
*/
	///

	async fetchRating() {
		const ApiEndpoint = 'http://s28.ca/sodv2201/instructor/ratings';
		const ApiRequest={};
	
		let ApiResponse = await fetch(ApiEndpoint,{method:'POST',body:JSON.stringify(ApiRequest)});
		let Reply = await ApiResponse.json();
		console.log(Reply);
		//console.log(this.ApiResponse);
	}
	/*
	async componentDidMount()
	{
		await this.GetListings();
	}
	*/
	componentDidMount()
	{
		this.fetchRating();
	}
	render() {


	//let ApiResponse =

		// const mapFun = Data.Map();
		//console.log(mapFun);
		//console.log(Data);
		//let {Data} = this.state;
		//console.log("Data Test"+Data);
		//let Inst = toJS(this.props.model.Instruc);
		console.log(this.props.model.Instruc);
		
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
