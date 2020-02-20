/*
Course Code: DATA1201
Term/Year: Winter 2018
Assignment code: GLA 1
Author: Scott Patterson
BVC username: s.patterson528
Date Created: 2018-01-23
Description: First GLA in DATA1201
*/



--EX1a
select * from people where state = 'CA';
/*Selecting from table people from the state CA */

--EX1b
select * from people where state = 'WA';
/*Selecting from table people from the state WA*/

--EX2
select first_name, last_name from people where state='CA' and shirt_or_hat='shirt';
/*Selecting First and last name from table people with shirt_or_hat is shirt*/

--EX3a
select first_name, last_name, team from people where state='CA' and shirt_or_hat='shirt' and team='blue';
/*Selecting First, last names and from table people where the state is CA and shirt_or_hat is shirt and the team is blue */

--EX3b
select first_name, last_name, team from people where state='CA' and shirt_or_hat='shirt' and team<>'blue';
/*Selecting first name last name team where the state is CA and shirt_or_hat is shirt and the team is not blue*/

--EX4
select first_name, last_name, state from people where state like 'C%';
/*Selecting first name last name state from people where the state has a 'C' in the first position*/

--EX5
select first_name, last_name from people where state='FL' order by first_name ;
/*Selecting first name, last name from people shere the state is FL and order by first name*/

--EX6a
select first_name|| ", " || last_name as 'Full Name', quiz_points,team from people WHERE team='red';
/*Selecting first and last name as Full name, selecting quiz_points, team from people with team as red*/

--EX6b
select first_name|| ", " || last_name as 'Full Name',quiz_points from people where quiz_points > '30';
/*Selecting first and last name as Full name, quiz_points from people where the quiz points are greater than 30*/

--EX6c
select first_name|| ", " || last_name as 'Full Name',quiz_points from people where quiz_points between '10' and '40';
/*Selecting first last name as Full Name, quiz_point from people with the quiz point between 10 and 40*/

--EX6d
select company from people where company is null 
/*Selecting company where company is null from table people*/

