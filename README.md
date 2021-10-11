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
2. Unzip all projects folders under root folder
3. Merge extracted contents for packages-1.zip and packages-2.zip to folder 'packages'. (it has splitted due to file size constraints)
4. Browse to dbcontactsScript.sql file located at root folder
5. execute the script to SQL database
6. Launch the solution *.sln
7. Change database connection string to select the above database (as initially the database was created with code first EF core and later same is used and data seeding logic have not included in the project).  
8. Make sure we have selected two projects as startup projects
9. Those are -
 
  a. OnionContactManagementSolution.WebAPI
  
  b. OnionContactManagementSolution.UI
  
10. Once above set up is done, run the project
11. It will open, one web API project with swagger UI
12. and UI project, where we will be able to do - add new contact, edit or DeActivate the selected contact.

