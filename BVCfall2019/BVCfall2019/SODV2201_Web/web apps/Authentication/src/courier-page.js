import React, { Component } from 'react';
import { observer,inject } from "mobx-react";


const CourierApp = observer ( class  CourierApp extends Component{
    
    searchHandler=(e)=>{
        this.props.model.searchQuery= e.target.value;
        
    }


    addList=async ()=>{
        await this.props.model.ListAdd(); 
        
    }

  //     this.props.model.searchQuery= e.target.value;
  HomeButton = () =>{
    this.props.history.push("/")
}
    

    ///
	OnClickDoneButton = () => {
		this.props.history.push('');
    }

    ///
    ///
    ///
    ///
    CourierLogIn = (e) => {

        this.props.model.CourierListToday(e.target.value);
    }
    ///
    ///
    ///
    GetDeliveries = (e) => {

        this.props.model.AddDeliveryClick(e.target.value);
        console.log();
    }


    ///
    ///
    ///
    ///
    getList=async ()=>{
        await this.props.model.WarehouseLoad(); 
        console.log("Data Load");
    }

    
    ///
    ///
    ///
    ///
    /*
        addList=async ()=>{
        await this.props.model.GetWarehouseDeliveries(); 
        
        console.log("Data Load");
    }
    */
   
    ///
    ///
    ///
    ///
    WarehouseClick  = () => {

        const Load =  this.props.model.Deliveries;
        this.props.model.WarehouseLoad(Load);

    }

    ///
    ///
    ///
    ///
    OnSaveClick = (e) => {


        /*
            Note this works but Doesnot override old info just yet


        */  
        let Key = "userData.json";

        //
        this.props.model.PutToAwsBucket(Key);


   }

    
    ///Component lifecycles
    render(){
       ///JS to render
       let CouriersList 
       let WarehouseList 
       
        return(
             
            <div>
                <h2>TrackingPage</h2>  
                <button onClick={this.HomeButton}>Home</button>
                <button className="AddButton"  onClick={this.WarehouseClick}>
                                    Load Deliveries
                </button>  
                    <div className="MainContainer">

                        <input className=""
                            name="Search"
                            onChange={this.CourierLogIn}
                            placeholder=" Your ID" />
                        <input className=""
                                name="Search"
                                onChange={this.searchHandler}
                                placeholder="Delivery ID"/>
                        <button 
                                className=""
                                type="submit"
                                value = "Search"
                                onClick={this.addList}>
                                    Add
                        </button>
                    </div>  
                <div className="List container">
                    

                    <p>List Display</p>
                    <h2>{this.props.model.blankString}</h2>
                  
                    <button className="AddButton"  onClick={this.OnSaveClick}>
                                    Send
                        </button>  
                </div>
                
            </div>
        );
    }
    
})

/**
 * 
 * Couriers can add packages to a list
 * list is saved in dataset
 * Couriers can remove packages from the list and using a camera, they can have proof of delivery
 * 
 */
export default CourierApp;

    