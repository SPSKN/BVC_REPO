import React, {Component} from 'react';
import './filtered-input.css';
import './rectangularbutton.css'
/*
Filtered Input textbox
initialvalue - set the initial value
filter - RegEx Filter   eww
ondone - callback function
*/
export class FilteredInput extends Component{
    constructor(props) {
		super(props);
		this.state = { newItem:"", list:[]}
	}

    OnClicked = () => {
		console.log("This button Was pressed... Do it again");
		//Get the callback function from props.
		const Callback = this.props.onpress;

        if(Callback) Callback();
        this.clearList();
		
	}
	
	
	OnBlur = (e) => {
		if (this.props.ondone) this.props.ondone(this.state.newItem);
		this.addItem();
	}

	/// keys
	updateInput(key,value){
		this.setState({
			[key]:value
		});
	}

	


	OnInput = (e) =>
	{
		//this.updateInput("newItem",e.target.value);
		let newItem = e.target.value;
		newItem = newItem.replace(/[^A-Za-z\s]/gi,"");
		this.setState({newItem})
	}


	

	addItem(){
		const newItem ={
			id: 1 + Math.random(),
			value: this.state.newItem.slice()
		};
		const list = [...this.state.list];

		list.push(newItem);

		this.setState({
			list,
			newItem:""
		});
	}


clearList=(e)=>
{
	this.setState({
		list:[]
	});
}


	///
	render() {
        const Caption = this.props.caption;
		return (
			<div>
				<input className="filtered-input-box"
				type="text"
				value={this.state.newItem}
				onChange={this.OnInput}
				onBlur={this.OnBlur}
			
				
				/>
				<button className="rectangular-button" onClick={this.OnClicked}>
			<div className="caption"> {Caption}</div>Clear
			</button>
				<ul>
					{this.state.list.map(item => {
						return(
							<li key={item.id}>
							{item.value}
							</li>
						)
					})}
				</ul>
				
			</div>
				

		);

	}
}
