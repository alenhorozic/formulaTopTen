
Formula1 Top 10 Drivers
There are 2 solution in this project, databases in SQLserver and project consuming "public API" 
******formulaTopTen           backEnd       
******formulaFrontEnd         frontEnd
******databases   SQLserver   formula
******public API              http://ergast.com/api/f1/drivers/peterson 

* Drivers table will have comment driverId, name, surName,
* Comment table will have comment comentId, description, driverId,

we will print a list of those ten drivers on the page
where the client clicks on one of the drivers will get additional information from http://ergast.com/api/f1/drivers/peterson
and use info about races constructors and comment from our database api call. All Races For Driver. All Constructors For Driver. All Coment For Driver.
 
technology vi are using is .NET entytiFreamwork WebApplication Using RezorPages

// dependency injection using in driverController and comentController
// memoryCache using in driverController
// exception   using in driverController

// async function using in formulaFrontend driverController when vi cool on API and await response using if() statement

//dataBase SqlServer using and exempel are in formulaTopTen solution in fail fotmulaDatabase.sql