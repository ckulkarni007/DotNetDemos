Create 3    collections with following details

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

Have a look on the requirements below, then populate the data in the above collections.

Implement following conditionss using suitable Linq functions - 

City requirements - 
1. Get First 2 cities where their area is greater that 30000 
2. Get All the cities whicha are the metrocities.
3. Get a city whose Id is "x"
4. Get a name of the city whose population is highest.
5. Get a name of a city who has maximum tourist places.
6. Get a city who do not have any airport.

State requirements - 
1. Get the name of a state where Id = "x"
2. Get first state where Population > 2000000
3. Get name and id of the state which has Maximum genderEqualityRatio
4. Get the single state which has maximum population
5. Get a state which does not have any river.
6. Select all the rivers from a state where name = "x"

Country requirements - 
1. Select a country where a currency = "rupee"
2. Select a capital of a country whose population > 10000000 and DevelopmentStatus = "Developing"
3. Get a list of all the developed countries
4. Get a country whose has highest equityCapital
5. Sort the countries by descending order based on their population
6. Get the first 3 states who has highest area.
