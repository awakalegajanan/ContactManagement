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
2. Browse to dbcontactsScript.sql file located at root folder
3. execute the script to SQL database
4. Launch the solution *.sln
5. Make sure we have selected two projects as startup projects
6. Those are -
 
  a. OnionContactManagementSolution.WebAPI
  
  b. OnionContactManagementSolution.UI
  
7. Once above set up is done, run the project
8. It will open, one web API project with swagger UI
9. and UI project, where we will be able to do - add new contact, edit or DeActivate the selected contact.

