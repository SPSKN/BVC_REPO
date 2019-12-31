
import React, { Component } from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import { MessagePage } from './message-page.js';
import { ProductPage } from './product-page.js';
import { SplashPage } from './splash-page.js';
import { MainPage } from './main-page.js';
import { FaqPage } from './faq-page.js';

/// App
export class App extends Component {

	///
	render() {

		return (

			<main>

				<header>
					SUPER APP!
				</header>

				<BrowserRouter>

					<Switch>

						<Route exact path="/splash" render={ props => <SplashPage {...props} /> } />

						<Route exact path="/faq" render={ props => <FaqPage {...props} /> } />

						<Route exact path="/product/:id" render={ props => <ProductPage {...props} /> } />

						<Route exact path="/" render={ props => <MainPage {...props} /> } />

						<Route render={ props => <MessagePage message="We could not find that page (404)." {...props} /> } />

						{/* <Route exact path="/" render={ props => !IsLoggedIn ? <Redirect to="/authentication" /> : <MainPage store={AppState} {...props} /> } /> */}

					</Switch>

				</BrowserRouter> 

			</main>

		);

	}

}
