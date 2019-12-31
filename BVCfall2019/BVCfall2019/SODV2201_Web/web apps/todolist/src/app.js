
/// Import modules required by this module.
import React, { Component } from 'react';
import {FilteredInput} from './filtered.js';
//import {RectangularButton} from './rectangularbutton.js';
//import {ItemList} from './list.js';
import './my-styles.css';

/// App
class App extends Component {
	OnThat = (Value) =>{ // On Blur
		console.log("This is the Value  " + Value);
	}
	AddItemList()
	{

	}
	render() {

		//var listItem = <li>{this.Value}</li>
		return(
			<div>
				<h2>ToDo List</h2>
				<FilteredInput initialvalue="" filter="[^\D]" ondone={this.OnThat} />
				
			</div>
		);
	}
}

export default App;
