import React, { Component } from 'react';
import { HeadClass } from './header.js';
import {CardsClass} from './cards.js';
import './index.css'
class App extends Component { //App class is main App
	
	 render() {

		//console.log("The render method executed");
		//Put the components here
		// add them into the main
        return (		
			<main>
				<HeadClass />
				<CardsClass />
				
			</main>
        );
	}
}
export default App;
