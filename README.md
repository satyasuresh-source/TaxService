# TaxService

Read Me
 

Technology Used ASP.NET Core WEB API 3.1, EF Core, SQL-2019
 
Below are the end points


1)  Created an API to Upload Tax Details for Municipalities (It will support two different formats of files CSV and EXCEL)

 /api/FileAccess/DocumentUpload
  

2) Created an API to View the Tax Details by Municipality Name and Date


/api/Tax/GetTaxDetails


3) Created an API to Save the Tax Details for a Municipality

/api/Tax/Save


4) Created an API to Update the Tax Details for a Municipality

/api/Tax/Update

To run this api need to do following

1)Run the database scripts from the following https://github.com/satyasuresh-source/SQLScripts

2)Database connection to be change in MunicipalityDataContext (Todo:need to move this to configuration file)


Assumptions

Created Middleware Component for exception handling

Serial Log for Logging 

Custom attribute for date validation

Filter used for Model Validations 

Used EF Core Code first approach


















