import React, { Component } from 'react';
import { observer } from 'mobx-react';

export class Login extends Component{
		///
        OnLogin = (e) => {
            try{
                this.props.model.Login();
                
            }catch(e){
                console.log("Login Failed");
            }
			finally{
                if(localStorage.getItem("Courier")!=="undefined")
                {
                    this.props.history.push("/courier");
                }
            }

		}

		///
		OnChangeEmailAddress = (e) => {

			// Extract value from the event object.
			const NewValue = e.target.value;
			
			// Update the model *directly* using a model method.
			this.props.model.SetEmailAddress(NewValue);

		}

		///
		OnChangePassword = (e) => {

			// Extract value from the event object.
			const NewValue = e.target.value;
			
			// Update the model *directly* using a model method.
			this.props.model.SetPassword(NewValue);

		}

render(){
    const EmailAddress = this.props.model.EmailAddress;
    const Password = this.props.model.Password;
    
    return(
        <div>
            <div className="x-centered-y-centered-column">
                <input type="text" name="EmailAddress" onChange={this.OnChangeEmailAddress} />
                <input type="text" name="Password" onChange={this.OnChangePassword} />
            </div>
            <div style={{ marginTop:3 + "rem" }}>
                <button className="rectangular" onClick={this.OnLogin} >Login</button>
            </div>
        </div>
    );

}

}