import React, { Component} from 'react';
//import './rectangularbutton.css';



/*
*
* Rectangular Button
* Props --
* onclick: a callback function that the component uses to signal parent.\
* caption: the label of the button
* 
*/

export class rectangleButton extends Component{
//
    OnClicked = () =>{
        console.log("Stop it");

        const Callback= this.props.onpress;
        if(Callback) Callback();
    }

    render(){
const Caption = this.props.caption;


        return(
            <button className="rectangular-button" onClick={this.OnClicked}>
            <div className="caption">{Caption}</div>
            </button>
        );
    }

}