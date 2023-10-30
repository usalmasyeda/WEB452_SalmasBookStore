
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
> Microsoft.EntityFrameworkCore.Relational Version (5.0.11)
> Microsoft.EntityFrameworkCore.SqlServer Version (5.0.11)

- Deleted the Migrations Folder 

- Clicked Tool > NuGet Package Manager > Brower
- Installed (Identity.EntityFramework.Core) version (5.0.2)
- I am starting to see ERRORS!!! in the console.


- Installed the wrong Identity.EntityFramework.Core!! thats why I was seeing errors. 
- Installed the right one now: (Microsoft.AspNetCore.Identity.EntityFrameworkCore) Version (5.0.2)
- Errors went away! Thank god.
- Commited to Git Repo

0537
- Cloned repo from github
- Modified the namespace to reflect the project 
- Went to ApplicationDbContext.cs in SalmasBook.DataAccess -> changed the namespace to:
> namespace SalmasBookStore.DataAccess.Data
- Deleted all the default Class1.cs files from all the prjects: 
> SalmasBook.DataAccess
> SalmasBook.Models
> SalmasBook.Utility

- When I tried to build my project there is an 3 error!

Error Message: The type or namespace name 'Data' doesn't exist.

- Moved Models folder in to SalmasBook.Models Project.
- Deleted the original Models folder
- Modified Views -> Shared -> Error.cshtml
- Right-Clicked on SalmasBookStore.sln project -> Add -> Project Reference
- Ticked .DataAccess and .Models -> the OK
- Renamed Models folder to 'ViewModels' inside SalmasBook.Models
- Changed the ErrorViewModels.cs namespace .Models.ViewModels
- Build Project -> GETTING SO MANY ERRORS!

Going to contiune cannot commit to github while having errors. Going to try to fix the errors
- Modified Startup.cs file, added a using statement at the top "using SalmasBookStore.Data;"
- Building the project and NO cannot build due to errors
- Reviewing the errors
- Removed the using statement "using SalmasBookStore.Data;" from the ErrorViewModel.cs
- Went to Error.cshtml and changed the @model
>@model SalmasBookStore.Models.ViewModels.ErrorViewModel

- Also went to the startup.cs file and added the using statement 'using SalmasBookStore.DataAccess.Data
- Also went to the HomeController.cs and added the using statement 'using SalmasBookStore.Models.ViewModels

--- I RESOLVED ALL THE ERRORS!!! ---
- Build the project! A success!
