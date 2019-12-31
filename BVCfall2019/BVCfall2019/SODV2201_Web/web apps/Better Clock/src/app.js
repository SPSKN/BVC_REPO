// Import modules required by this module
// The {} means import a named component ( not the defualt one )
import React, { Component } from 'react';
import{ BetterClockMan} from './betterclock.js'




class App extends Component { //App class is main App



	 // Add a render method to render something.
	 render() {

        console.log("The render method executed");
        

        return (
			
			<div>
		
			{console.log("Render App.js")}
			<BetterClockMan/>
			
			
			</div>
        );
	}
}
export default App;
/*






















*/