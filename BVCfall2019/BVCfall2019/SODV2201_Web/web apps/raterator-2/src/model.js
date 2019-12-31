///
/// An independent model representing the application under a mutable state design.
///

import { observable,toJS } from 'mobx';

export let Model = observable({

	Rating:[],Like:[],Instruc:[],School:[]


});
Model.AddLike = (iSid) =>
{
	Model.Like.forEach(e =>{
		if(iSid=== e.InstructorSid)
		{
			e.Likes += 1;
			console.log("Blah")
		}
	});

}
Model.GetLike = (iSid) =>
{
	let likeCount = 0;
	Model.Like.forEach(e =>{
		if(iSid === e.InstructorSid)
		{
			likeCount = e.Likes;
		}

	});
	return likeCount;
}
Model.GetRating=(iSid) =>{
	let avgRating =0;
	let count = 0;
	Model.Rating.forEach(e =>{
		if(iSid === e.InstructorSid)
		{
			avgRating += e.Rating;
			count++;
		}

	});
	let retrunAvg =Math.round( avgRating / count);
	if(!retrunAvg)
	{
		return "No Rating Here";
	}
	return retrunAvg;
	

}

Model.GetSchool = (w) => {
let SchoolId = 0;
let RId = "";
Model.Rating.forEach(e => {
	if(w === e.InstructorSid)
	{
		SchoolId = e.SchoolSid;

	}
	else{
		RId ="No School Found";
	}
});
	Model.School.forEach(x=>{
	if(SchoolId === x.SchoolSid)
	{
		RId = x.Name;
	}
	
});
return RId;

}


Model.fetchRating = async function() {
	const ApiEndpoint = 'http://s28.ca/sodv2201/instructor/ratings';
		const ApiRequest={};
	
		let ApiResponse = await fetch(ApiEndpoint,{method:'POST',body:JSON.stringify(ApiRequest)});
		let Reply = await ApiResponse.json();
		//console.log(Reply);
		let Rating= Reply.Ratings;
		this.Rating = Rating.Ratings;
		this.Like = Rating.Likes;
		this.Instruc = Rating.Instructors;
		this.School = Rating.Schools;

		console.log(toJS(this.Rating));
		console.log(toJS(this.Like));
		console.log(toJS(this.Instruc));
		console.log(toJS(this.School));


}
