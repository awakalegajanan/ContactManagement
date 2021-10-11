# ContactManagement
Contact Management solution design

This is developed using Microsoft.Net technology stack - C#, Asp.Net MVC, Asp.Net Core Web API, SQL Server.

**Design** - 
  I have designed the solution architecture based on Onion architecture design concept.
where all class libraries are added as .Net Standard, so that those can be used later either with .Net Framework or .Net Core applications.
Web API is designed using Asp.Net Core and UI is designed using Asp.Net MVC.
For database I choose SQL Server, considering it would store moderate data (it may not be as much as less or as much as large, with SQL Express edition we get sufficient storage to store only customer data)

**How to Run the application ?**

To run the project follow below steps,
1. Navigate to folder - ContactManagement/compressed projects/
1. Unzip all projects folders under root folder
2. Merge extracted contents for packages-1.zip and packages-2.zip to folder 'packages'. (it has splitted due to file size constraints)
3. Browse to dbcontactsScript.sql file located at root folder
4. execute the script to SQL database
5. Launch the solution *.sln
6. Change database connection string to select the above database (as initially the database was created with code first EF core and later same is used and data seeding logic have not included in the project).  
7. Make sure we have selected two projects as startup projects
8. Those are -
 
  a. OnionContactManagementSolution.WebAPI
  
  b. OnionContactManagementSolution.UI
  
7. Once above set up is done, run the project
8. It will open, one web API project with swagger UI
9. and UI project, where we will be able to do - add new contact, edit or DeActivate the selected contact.

