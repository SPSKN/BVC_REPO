import React, {Component} from 'react';
/// import './filtered-input.css';


/*
Filtered Input textbox

initialvalue - set the initial value
filter - RegEx Filter   eww
ondone - callback function
*/
export class FilteredInput extends Component{

constructor(props){
    super(props);
    this.state = {Value:this.props.initialvalue}
}
OnInput = (e) =>{
    let InputValue = e.target.value;

    var Filter = this.props.filter;
    var Regex = new RegExp(Filter, 'g');
    InputValue = InputValue.replace(Regex, "");
    
    this.setState({Value:InputValue});
}
OnBlur = (e) =>{
    if(this.props.ondone) this.props.ondone(this.state.Value)
}
render(){
    return(
        <input className="filtered-input-box" type="text"
        onInput={this.OnInput}
        onBlur={this.OnBlur}
        value={this.state.Value} />
        
       

    );
}
//End of render
}
//End of filtered