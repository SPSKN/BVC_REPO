import React, {Component} from 'react';


export class ItemList extends Component {
constructor(prop)
{
 super(prop)
 this.state = {Value:this.props.children}
}


    render(){
        
        return(
            <div>
                <ul>
                    
                </ul>
            </div>
            

        );
    }
}