import React, { Component } from 'react';
import { SplashPage } from './splash-page.js';
import { MainPage } from './main-page.js';
//import {CardClass} from './cards.js';
//import {Model} from './model.js';
import './index.css';
import {toJS} from 'mobx';
import {observer} from 'mobx-react';


///    http://s28.ca/sodv2201/instructor/ratings
///    the api call

const app = observer( class App extends Component { //App class is main App
	constructor(props) {
		super(props);
		this.state = { Scene:"splash-page" };
		this.AppMountTimer = null;
	}

	componentDidMount() {

		// Create a timer to switch scenes after a short delay.
		this.AppMountTimer = setTimeout(this.OnAppMountedTimeout, 2000);
		this.props.model.fetchRating();
	}

	///
	componentWillUnmount() {
		this.AppMountTimer = null;		// Remove the reference to the timer to GC can deallocate it.
	}

	///
	OnAppMountedTimeout = () => {
		this.setState({ Scene:"main-page" });
	}
	
	OnNavigate = (destination) => {

		switch (destination) {
			case "main": 
				this.setState({ Scene:"main-page" });
				break;
			default: 
				break;
		}
	}
	 render() {

		//console.log("The render method executed");
		//Put the components here
		// add them into the main

				// Sample the current state.
				const Scene = this.state.Scene;
				console.log(toJS(this.Rating));
				console.log(toJS(this.Like));
				console.log(toJS(this.Instruc));
				console.log(toJS(this.School));
				// Figure out what top-level scene component we should display.
				const IsShowingSplashPage = Scene === "splash-page";
				const IsShowingMainPage = Scene === "main-page";
        return (		
			<main>


				{IsShowingSplashPage && <SplashPage /> }
				{IsShowingMainPage && <MainPage model={this.props.model} navigate={this.OnNavigate} /> }
				
				
			</main>
        );
	}
})
export default app;