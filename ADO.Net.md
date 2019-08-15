Create 3 Tables in the database with following details. You can choose any database as per your requirement.
1. Country
	- Id
	- Name
	- Area
	- Population
	- EquityCapital
	- Capital
	- Currency
	- List of States present in a country
	- DevelopmentStatus (UnderDeveloped, Developing, Developed)

2. State 
	- Id
	- Name
	- Area
	- Population
	- GenderEqualityRatio
	- List Cities present in a state
	- Rivers

3. City
	- Id
	- Name
	- Area
	- Population
	- IsMetroCity
	- IsAirportPresent	
	- Tourist Places

	Write ADO.Net connection for following requirements.-
	
- Write a method to get all the records from country table.
- Update an country record whose capital is ""
- Write a method to insert a new record in the state

- Write get all the records of country where the state population is not more that 1000000 and state's gender equality ratio is less than 40% and equity capital exceeds 500000000. (Use stored procedure)

Fetch all the cities and states from database using ADO.NET or linq to Sql and write LINQ for it
1. Get all the countries where the states have rivers and do not have any tourist places.
2. Get all the states with the list of cities present in it.
3. Group by the countries based on the their developmentStatus and EquityCapital
4. Find the common rivers present in different states.
5. Get the list of capital and population for each country.



