import React, { Component } from 'react';
import { observer} from 'mobx-react';


const card = observer(class CardsClass extends Component { 
  
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
  

    let N = this.props.I;


    let s = this.props.model.GetSchool(this.props.ID);
    let l = this.props.model.GetLike(this.props.ID);
    let r = this.props.model.GetRating(this.props.ID);

return(
  
    <div className="card-container">
        <span>
            {N}
        </span>
        <br/>
        <span>
            {s}
        </span>
        <br/>
        <span>
            {r}
        </span>
        <div className="footer-card" >
            <button onClick={()=>this.props.model.AddLike(this.props.ID)}>Likes{this.likeCounter}</button>{l}
            <button>Reviews</button>
        </div>
    </div>
    
);

}

}) 
export default card;