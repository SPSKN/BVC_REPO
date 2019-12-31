
import React, { Component } from 'react';
import { SplashPage } from './splash-page.js';
import { MainPage } from './main-page.js';
import { FaqPage } from './faq-page.js';

/// App
export class App extends Component {

	///
	constructor(props) {
		super(props);
		this.state = { Scene:"splash-page" };
		this.AppMountTimer = null;
	}

	///
	componentDidMount() {

		// Create a timer to switch scenes after a short delay.
		this.AppMountTimer = setTimeout(this.OnAppMountedTimeout, 2000);

	}

	///
	componentWillUnmount() {
		this.AppMountTimer = null;		// Remove the reference to the timer to GC can deallocate it.
	}

	///
	OnAppMountedTimeout = () => {
		this.setState({ Scene:"main-page" });
	}

	///
	OnNavigate = (destination) => {

		switch (destination) {
			case "faq": 
				this.setState({ Scene:"faq-page" });
				break;
			case "main": 
				this.setState({ Scene:"main-page" });
				break;
			default: 
				break;
		}

	}

	///
	render() {

		// Sample the current state.
		const Scene = this.state.Scene;

		// Figure out what top-level scene component we should display.
		const IsShowingSplashPage = Scene === "splash-page";
		const IsShowingMainPage = Scene === "main-page";
		const IsShowingFaqPage = Scene === "faq-page";

		// Render the correct scene.
		return (

			<main>

				<header>
					SUPER APP!
				</header>

				{IsShowingSplashPage && <SplashPage /> }
				{IsShowingMainPage && <MainPage navigate={this.OnNavigate} /> }
				{IsShowingFaqPage && <FaqPage navigate={this.OnNavigate} /> }

			</main>

		);

	}

}
