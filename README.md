# MiriamsStore-Test-ASP.NET<br>

Student Exercise Creating a Web Application in ASP.NET.<br>
Credit for exercise belongs to: [Adam Freeman](https://www.apress.com/gp/book/9781484254394)
<br>
<br>
**Step 1:**<br>
Code used to create project:<br>
```dotnet new globaljson --sdk-version 5.0.103 --output MiriamsStoreSln
dotnet new web --no-https --output MiriamsStoreSln --framework net5.0
dotnet new sln -o MiriamsStoreSln
dotnet sln BobsStoreSln add MiriamsStoreSln
dotnet new xunit -o MiriamsStoreSln.Tests --framework net5.0
dotnet sln MiriamsStoreSln add MiriamsStoreSln.Tests 
dotnet add MiriamsStoreSln.Tests reference MiriamsStoreSln 
```

<br>
**Step 2:**<br>
Unsured project is running as expected, initial push created.<br>
![Image](Prog1.jpeg "Link Doesnt work lmao")<br>

**Step 3:**<br>
*What is Entity Framework?*
```
Enity Framework is Microsofts Object to relational mapping (ORM) framework. It is used to link databases and web applications together.
```
*What is a Connection String?*
```

```
*What is a Database Context?*
```

```
*What is a Model Repository?*
```

```
*Migration vs Scaffolding?*
```

```
*Seeding the database*
