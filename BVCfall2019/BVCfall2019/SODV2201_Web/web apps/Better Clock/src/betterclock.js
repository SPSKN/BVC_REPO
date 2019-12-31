import React, { Component } from 'react';
import moment from 'moment';

export class BetterClockMan extends Component
    
{
    constructor(props) 
	{ 
		super(props); 
		this.state = { Clock: new Date().toLocaleTimeString() }; // the state that i wanna Update 
		//this.OnTimerExpired  = this.OnTimerExpired.bind(this); // The Timer // dont need this if you use fat arrow

	} 
	/*onClick()
	{
		console.log("Button pressed");
	}
*/
	
    componentDidMount() 
	{ 
		// console.log("componentDidMount()"); //
		setInterval(this.OnTimerExpired , 1000); //Runner as a timer
	} 

	OnTimerExpired = () => 
	// fat arrow
	{ 
        let NewClock = new Date().toLocaleTimeString();
        this.setState({
           Clock:NewClock
        });
	}
render()
{
	
	//let CurrentDate = Date().toDateString();
	let LocalTime = this.state.Clock; // get local time
	var Utc = moment().utc().format('LTS');//get utc


	var EasternTz = moment().utc().subtract(4, 'h').format('LTS'); //get Eastern Time

	var PacificTz = moment().utc().subtract(7, 'h').format('LTS'); // get Pacific Time
	//var CentralTz = LocalTime;

	/*
			
			
			<div>{CentralTz} Central Time</div>
	*/
	return(
		<div>
			
			<h2>Local/UTC/Pacific/Eastern Times</h2>
			<div><h3>{LocalTime} Local Time</h3></div>
			<br />
			<div><h3>{Utc} UTC</h3></div>
			<br />
			<div><h3>{PacificTz} Pacific Time</h3></div>
			<br />
			<div><h3>{EasternTz} Eastern Time</h3></div>
			<br />
			{console.log("utc-clock returned")}
			<button class="buttonClass">Button</button>
			
			</div>
	)
		

	

}

}
