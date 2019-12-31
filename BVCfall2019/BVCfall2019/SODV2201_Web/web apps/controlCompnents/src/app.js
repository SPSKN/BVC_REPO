// Import modules required by this module
// The {} means import a named component ( not the defualt one )
import React, { Component } from 'react';
import { rectangleButton } from './rButton.js';
class App extends Component { //App class is main App
	 // Add a render method to render something.
	ButtonPressed = () =>
{
	console.log("I hear you pressed me");
	
}


	 render() {

        console.log("The render method executed");
        return (		
			<div>
				<p> This page demonstrates a "Controlled" component.</p>
				<rectangleButton caption="Dont press it" onpress={this.ButtonPressed}/>
			</div>
        );
	}
}
export default App;
