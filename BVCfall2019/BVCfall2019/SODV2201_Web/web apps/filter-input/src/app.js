
/// Import modules required by this module.
import React, { Component } from 'react';
import {FilteredInput} from './filtered.js';

/// App
class App extends Component {
	OnThat = (Value) =>{
		console.log("App Value " + Value);
	}

	render() {
//Filter [^\D] filters out numbers
		return(
			<div>
				<h2>Filtered Input</h2>
				<FilteredInput initialvalue="" filter="[^\D]" ondone={this.OnThat}/>

			</div>
		);

	}

}

export default App;
