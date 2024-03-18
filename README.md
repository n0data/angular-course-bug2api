In  file  appsettings.Development.json  You need to enter YOUR SERVER NAME for default connection so you can create database of movies

First time setting DB from Visual Studio 2019 you need to run a command from package manager console: Add-Migration Initial 


if you are using VS CLI run a command: dotnet ef migrations add Initial


to update database in your Package Manager Console run: Update-Database     



Here i used Nuget packages:
Microsoft.EntityFrameworkCore.SqlServer v5.0.1
and Microsoft.EntityFrameworkCore.Tools v5.0.1

Development in
vs2019
and SqlServer 2008 R2
