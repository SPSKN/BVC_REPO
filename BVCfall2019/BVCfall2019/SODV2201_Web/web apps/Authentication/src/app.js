import { BrowserRouter as Router, Route } from "react-router-dom";
import React, { Component } from 'react';
import { observer } from 'mobx-react';
import {Login} from "./login.js";
import  CourierApp  from './courier-page';
///
/// App
///
/// We create and export a constant named "App" which is the return value of a mobx function called "observer".
/// This function, in turn, is wrapping around our class named "BasePage", which represents the outermost
/// container of our application.  We won't render BasePage directly, because we want the mobx wrapper
/// function so that our page can watch our model for changes.  All of this is done more easily with
/// @decorator syntax, but that is not presently working in VS Code and I don't have time to sort it out :(
/// You can use the approach below *or* decorator syntax if you can get it working.
///
export const App = observer(

	class BasePage extends Component {

		/// 
		

		///
		render() {

			// Sample the current state.
			

			// Render JSX to visualize sampled state.
			return (

				<main>

					<Router>
						<Route exact path="/" render={props => <Login model={this.props.model}{...props}/>}/>
						<Route exact path="/courier" render={ props => <CourierApp model={this.props.model} {...props} /> } />
					</Router>

				</main>

			);

		}

	}

);
