import React, { Component } from 'react';
import {Data} from './Data';
export class CardsClass extends Component {
   
    constructor(props)
    {
        super(props);
        this.state = {Data: JSON.parse(Data)};
    }
    
   OnClicked = () => {
    console.log("This button Was pressed");
    //Get the callback function from props.
    const Callback = this.props.onpress;
    var likeCounter = 0;
    likeCounter+=1;
    console.log(likeCounter);
    if(Callback) Callback();

   // console.log(this.likeCounter);
}

    

render(){
  //var likeCounter =this.props.likeCounter;
    let {Data} = this.state;
    let instructors = Data.Instructors;
    let school = Data.Schools;
    let rating = Data.Ratings;
    //console.log("The Whole Data: "+Data);
    //console.log("Instructors: "+instructors);
    //console.log("Schools: "+school);
    console.log(rating);
/*
let sample = rating.map(e =>
<p>key = (e.Schools)</p>
);
*/


var i;
/*foreach( i in rating)
{
    let intName = Ratings.InstructorSid;
    let SchlName = Ratings.SchoolSid;
    let rate = Ratings.Rating;
}
*/
return(
    <span className="main-card">
    <div className="card-container">
        <p>Name</p>
        <p>School</p>
        <p>* * * * *</p>
        <div className="footer-card" >
            <button onClick={this.OnClicked}>Likes{this.likeCounter}</button>
            <button>Reviews</button>
        </div>
    </div>
    </span>
);

}

}