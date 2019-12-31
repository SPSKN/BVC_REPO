
import React, { Component } from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import { MessagePage } from './message-page.js';
//npmimport { ProductPage } from './product-page.js';
import { SplashPage } from './splash-page.js';
import { MainPage } from './main-page.js';
import './index.css';
import {toJS} from 'mobx';
import {observer} from 'mobx-react';
//import { FaqPage } from './faq-page.js';

/// App
const app = observer( class App extends Component { //App class is main App

	constructor(props) {
		super(props);
		this.SplashPageTimer = null;
	}
	componentDidMount() {

		// Create a timer to switch scenes after a short delay.
		//this.AppMountTimer = setTimeout(this.OnAppMountedTimeout, 2000);
		this.props.model.fetchRating();
		this.SplashPageTimer = setTimeout(this.OnSplashPageTimeout, 2000);

	}
	componentWillUnmount() {
		this.SplashPageTimer = null;		// Remove the reference to the timer to GC can deallocate it.
	}

	///


	///

	render() {

		
		console.log(toJS(this.Rating));
		console.log(toJS(this.Like));
		console.log(toJS(this.Instruc));
		console.log(toJS(this.School));

		return (

			<main>


				<BrowserRouter>

					<Switch>

						<Route exact path="/" render={ props => <SplashPage {...props} /> } />

						

					

						<Route exact path="/main" render={ props => <MainPage model={this.props.model}{...props} /> } />

						<Route render={ props => <MessagePage message="We could not find that page (404)." {...props} /> } />

						{/* <Route exact path="/" render={ props => !IsLoggedIn ? <Redirect to="/authentication" /> : <MainPage store={AppState} {...props} /> } /> */}

					</Switch>

				</BrowserRouter> 

			</main>

		);

	}

})
export default app;
