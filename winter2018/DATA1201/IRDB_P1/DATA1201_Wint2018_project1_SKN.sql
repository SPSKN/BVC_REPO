/*Course code : DATA1201
Term/Year : Winter 2018
Assignment code: GLA_2
Author : Scott Patterson
BVC username : s.patterson528
Date created : 2018-02-13
Description : GLA_2 SQL FILE
*/


/*EX1 */
SELECT people.first_name, people.state, states.division FROM people 
JOIN states ON people.state = states.state_abbrev;

/*EX2*/
SELECT * FROM people LEFT OUTER JOIN states on people.state=states.state_abbrev;

/*EX3*/
SELECT * FROM states LEFT OUTER JOIN people ON people.state = states.state_abbrev;

/*EX4*/
SELECT * FROM people LEFT OUTER JOIN states ON people.state=states.state_abbrev
UNION
SELECT * FROM states LEFT OUTER JOIN people ON people.state=states.state_abbrev

/*EX5a*/
SELECT first_name||", "|| last_name AS "full_name", states.state_name
FROM people
JOIN states ON people.state=states.state_abbrev

/*EX5b*/
SELECT first_name||", "|| last_name AS "full_name", states.state_name
FROM people
JOIN states ON people.state=states.state_abbrev
ORDER BY states.state_name


/*EX5c*/
SELECT DISTINCT states.state_name,states.state_abbrev,people.city
FROM people
JOIN states ON states.state_abbrev=people.state

/*EX5d*/
SELECT states.state_abbrev
FROM states
intersect
SELECT people.state
FROM people

/*EX5e*/
SELECT states.state_abbrev
FROM states
EXCEPT
SELECT people.state
FROM people 

/*EX5f*/
SELECT state_abbrev, state_name, region, 's' AS origin FROM states
UNION
SELECT state, city, region, 'p' AS origin FROM people
JOIN states
ON people.state = states.state_abbrev
ORDER BY state_abbrev;

