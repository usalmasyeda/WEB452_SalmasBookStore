
0300
WEB 452 003

Started Assignment 2 Creating a default ASP.NET MVC Application

0305
- Created README.txt File
- Created README.md File

Created the GitHub repo
- Reviewing the default application.
- Added the project discription in the README.md file. 

- In Startup.cs file on line 35 toggle blocked (options => options.SignIn.RequireConfirmedAccount = true)

2023-10-28
0924

SETTING UP THE PROJECT (PART 1) BOOTSTRAP

- Went to Bootswatch.com
- Selected a Theme called 'Lux - A touch of class'
- Downloaded bootstrap.css for this theme

- Went to wwwroot folder -> lib -> bootstrap -> dist -> css -> renamed the exisiting bootstrap to 'bootstrap(b)'
- Added the downloaded bootstrap.css file
- Went to wwwroot folder -> replaced the site.css file found in the main css folder with the given site.css in blackboard located in the Assignment 2 Files.
- Went to Views -> Shared -> _Layout.cshtml -> changed the file name from bootstrap.min.css to bootstrap.css.
- Changed the nav class from navbar-light to navbar dark
- Changed bg-white to bg-primary
- On Line 23 and 25 removed 'text-dark'
- Also added additional properties to the footer class
- In _LoginPartial.cshtml located in shared folder, removed the referneces to 'text-dark'
- Ran the project to review the changes. 

1046

- In the _Layout.cshtml page added the aditional stylesheets and scripts from the provided from the CSS_JS.txt file right after the footer tags.
- In Views/Shared/_Layout.cshtml I added a dropdown to the NavBar
- Ran the project to see the changes, looks good. 
- Changed the 'Dropdown' name to 'Content Management'
- Done everything works


2023-10-30
1237
ADDING PROJECTS AND MODIFYING

- Clone repo from github 
- Build the project, no errors

0215
- Added three new projects 
- Right-clicked Solution 'SalmasBookStore' -> Add -> New Project
> SalmasBook.DataAccess
> SalmasBook.Models
> SalmasBook.Utility

- Copied Data Folder and pasted it to the SalmasBook.DataAccess
- Deleted the original folder

0235

- Installed two packages 
> Microsoft.EntityFrameworkCore.Relational
> Microsoft.EntityFrameworkCore.SqlServer






