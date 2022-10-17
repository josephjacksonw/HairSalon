# _Eau Claire's Salon_
 
#### By _**Joseph Jackson**_
 
#### _Program to add and remove stylists and their respective clients_
 
## Technologies Used
 
* _C#_
* _.NET 5.0 Framework_
* _MySQLWorkbench_

 
## Description
 
_Using C#, this program will ask the user if they would like to add a stylist to the Salon. Once a stylist is added, the user can add more stylists, or clients to assign to an existing stylist. Data is stored using MySQL and built from MySQLWorkbench._

 
## Setup/Installation Requirements
 
* _Open up your terminal and navigate to the desired landing folder_
* _In terminal enter, ' "git clone https://github.com/JosephJacksonw/HairSalon '_
* _In terminal enter 'code .' to open files in Visual Studio Code_
* _In VS Code terminal navigate to the HairSalon/HairSalon folder_
* _Configure files by first running '$ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0'_
* _Then run '$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2'_
* _Run '$ dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0' to install Lazy Loading_
* _Run '$ dotnet restore'_
* _Create a file titled 'appsettings.json'_
* _Enter the following into the file_
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=joseph_jackson;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* _To setup the database you open up MySQL and under 'Administration' select 'Data Import'_
* _Check the 'Import from self contained file' option and enter the file path of the Database within HairSalon, then start Import_
* _Enter '$ dotnet run to start program'_

## Known Bugs
 
* _No known bugs_

## License

_[MIT](https://en.wikipedia.org/wiki/MIT_License)_ 

Copyright (c) _2022_ _Joseph Jackson_