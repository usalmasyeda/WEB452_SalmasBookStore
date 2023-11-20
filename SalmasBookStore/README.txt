2023-10-28
0300
WEB 452 003

Started Assignment 2 Creating a default ASP.NET MVC Application

Application: Using Visual Studio 2019
- Created New Project ASP.NET Core Web Application (MVC)
Project Name: SalmasBookStore
- Chnaged Authentication to Individual User Accounts
- Enabled Razor runtime compilation
- Created the application ready to code, working in the solutions folder.


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


0630
- In the Utility project I created a static details class called SD.cs
- Right-Clicked on .Utility -> Add -> Class
- Named it SD.cs
- Modified the properties of the class, 'public static class SD'
- Right-Clicked on SalmasBookStore -> Add -> Project Reference -> Ticked on .Utility -> OK
- Right-Clicked on .DataAccess -> Add -> Project Reference -> Ticked on .Models and .Utility -> OK
- Right Clicked on Areas -> Add -> Area -> MVC Area -> Named it 'Customer' -> Add
- Went to startup.cs file and changed the pattern for the route: (pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");)
- Moved the HomeController.cs to the Area -> Customer -> Controller folder and I deleted the Data and Models folder.
- Edited the HomeController.cs by adding [Area("Customer")] after the namespace
- Moved Home folder from the Views -> to the Views folder in Areas
- Modified the HomeController namespace to: (namespace SalmasBookStore.Area.Customer.Controllers)
- Ran the application successfull. Views are not in the ares and the master page is defined in _ViewStart
- Copied _ViewImport and _ViewStart to Customer Area
- Modified the _ViewStart.cshtml to reflect the new path > (Layout = "~/Views/Shared/_Layout.cshtml";)
- Ran the application and success!
- Commited to GitHub

0716
- Added a new Admin area in Areas
- Right Clicked on Areas -> Add -> Area -> MVC Area -> Named it 'Admin' -> Add
- Copy and pasted the _ViewImports.cshtml and _ViewStart.cshtml -> Admin Views folder.
- Deleted the Data and Models folder from the Admin folder
- Deleted the Controllers folder from SalmasBookStore application
- Updated the GitHub repo

-------- THE END OF PART 1 -------------

2023-10-31
0243

STARTING PART 2 OF THIS PROJECT

- Rebuild the application and there are no errors!
- Went to appsettings.json file and modifided the database name to (Database=SalmasBookStore;)
- Used the NuGet Package Manager Console to add the migration.
- Ran this in the console : (add-migration AddDefaultIdentityMigration)
- Getting errors! Need to change the Default Project name to (SalmasBook.DataAccess)
- Ran (add-migration AddDefaultIdentityMigration) again, was a success!
- This was the migration file added: [20231031185332_AddDefaultIdentityMigration.cs]
- Ran update-database in the console, was successfull!
- Ran the applciation to check if there are any errors, no errors!
- Build was a success.
- Commited to Git Repo

- Created a new class file named Category.cs in the SalmasBook.Models folder
- Modified and made changes inside the Category.cs file -> Added public class
- This is the code: 

public class Category
    {
        [Key]
        public int  Id { get; set; }

        [Display(Name="Category Name")]
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }
    }
}

- Made changes in the ApplicationDbContext.cs folder
- Need to run the migration again
- Deleted the Migration that was created previously 
- Made a new migration and it was successful!
- Updated the Database
- Commited to Github

2023-11-6
0113

2.2 REPOSITORY

- Rebuild the application and there are no errors!
- Created a new folder named 'Repository' in .DataAccess
- Created another folder inside the Repository folder named IRepository
- Modified it so it can be used on the Category class to do all the CRUD operations. 
- Created a new class file Repository.cs -> Repository folder.
- Got the code from assignment 2 folder.
- Created individual repos for catrgory
 - CategoryRepository.cs
 - ICategoryRepository.cs

- Modified CategoryRepository 
- Made adjustments in the code
- Reviwed and modified the error in CategoryRepository.cs
- Commited to GitHub

0237

- Implemented a stored procedure repository 
- Added a new interface in the IRepository folder - ISP_Call.cs that extends IDisposable
- Installed the NuGet package for Dapper
- Implemented a new class in the Repository folder
- Added a new class called (SP_Call.cs)
- Commited to GitHub
- Added the using statements in the SP_Call.cs file

0503

- Added a connection to the database
- Updated the implementation of the ISP_Call interface
- Added the wrapper for Unit of Work
- Added a new interface (IUnitOfWork) to the IRepository folder
- Updated the code.
- Added a class
- Modified the code making sure the public class implements the interface- UnitOfWork: IUnitOfWork
- Registered it to Startup.cs in the ConfigureServices method
- Added the using statements
- GETTING ERRORS!!! FIXING THE ERRORS!!
- Fixed the errors.
- Commit to github.

0618

2.3 CATEGORY CRUD
- Added a new MVC Controller-Empty inside Areas/Admin
- Named it CategoryController.cs
- Modified the code to use the IUnitOfWork from the .DataAccess project
- Added the using statements
- Commited to GitHub

0653
- Created a new folder in the Areas/View 
- Named as the Controller -> Category
- Added the folder -> Areas -> Admin -> Views
- Added a new Index view to the folder and modified the code
- Used the code given the Assignment 2 folder - files folder
- Save and run  the application
- No errors!! Everything works good.
- Committed to Github!

0707
- In _Layout.cshtml moved the 'Category' link to the Content Management drop-down
- Made some changes in the _Layout.cshtml page for the navigation
- Commited to GitHub

0733
- Modified the Index.cshtml to add the icons in the Category section
- Deleted it and added the JavaScript from the Assignment 2 files folder 
- wwwroot/js folder
- In Index.cshtml added the @section call to the category.js script and ran the project
- The project ran successfully
- Modified the CategoryController.cs file
- Added a Razor View
- Created A partial View 
- Created A partial View _CreateAndBackToListButton.cshtml
- Added the asp-action
- Created another partial view _EditAndBackToListButton
- Modified the Upsert.cshtml 
- Added the asp-action to the index.cshtml and ran the application
- Created a new Category file
- Added the @section call to script to validate input on the client side
- Added the save method
- Added API call for HTTPDelete in the CategoryController.cs
- Implemented the HTTPDelete with a delete method in category.js to add functionality to the application and call the API
- Added the delete functionality to category.js and onclick event to the delete function
- Added the function delete (url) at the end of the page
- The delete button is not working
- MY PROBLEM WAS THERE WAS NO SPACE BEFORE CLASS FOR THE DELETE BUTTON!!!! I FIXED THE PROBLEM BY ADDING SPACE!

-------- THE END OF PART 2 -------------

2023-11-14
0325

STARTING PART 3 (SECTION 1) OF THIS PROJECT

- Clean Solution
- Built Solution
- update-database (The application runs successfully)

- Created a new table to the DB by creating a CoverType model 
- Added a new class file to the .Models project 
- Added the migration via the PM Console (add-migration AddCoverTypeToDb)
- Migration (20231117222000_AddCoverTypeToDb)
- Updated the Database
- Commited to GitHub

2023-11-17
0534

- Clean Solution
- Built Solution
- update-database

- Added the CoverType.cs to the ApplicationDbContext file.
- public DbSet<CoverType> CoverType {get; set; }
- Created a new folder named CoverTypeRepository
- Another folder inside the CoverTypeRepository called ICoverTypeRepository
- Created a new item of type interface to the folder ICoverTypeRepository.cs
- Modified the ICoverTypeRepository.cs file, to use for CRUD
- Added required using statements 
- Created a new class in CoverTypeRepository folder
- Added the public interface and modified the code to create the constructors and 
dependency injection (Assignment 2 folder Repository)

2023-11-18
0124

- Deleted the CoverTypeRepository folder because later I create a covertype file again
which will cause a problem
- Added CoverType to the Repository
- Added CoverTypeRepository Class
- Added ICoverTypeRepository Interface
- Built solution, no errors
- Added the code for CoverType to both UnitOfWork and IUnitOfWork
- Created a new MVC Controller-Empty inside Areas/Admin
- Named the controller: CoverTypeController.cs
- Created a new folder in the Areas/View named it CoverType
- Modified the IUnitOfWork from the .DataAccess 
- Added the required using statements
- Created a new folder named CoverType inside Views folder
- Added a new Index Razor view inside the CoverType folder
- Added the covertype in the _layout.cshtml page
- Ran the application, no errors!

- THE MIGRATION DIDNT WORK AND THE DATABASE WAS NOT SHOWING
- SOMETHINGS WENT WRONG
- DELETED ALL THE FOLDER AND FILES RELATED TO THE CoverType
(STARTING OVER)

2023-11-19
0924

- Cleaned solution
- Build solution
- Database-updated
- Application runs successfully

- Created a new class file in the models folder named CoverType.cs
- Updated ApplicationDbContext.cs file
- Added migration (20231120023703_AddCoverTypeToDb)
- updated the database
- The table was successfully made.
- Commited to github

- Added CoverType to the Repository Folder
- Added CoverTypeRepository Class
- Added ICoverTypeRepository Interface 
- Added CoverType to UnitOfWork and IUnitOfWork
- Pushed CoverType to database by updating database
- Commited to github

- Added CoverType to NavBar
- Added CoverType Controller
- Created new CoverType Folder inside Views
- Created CoverType Index View inside the CoverType Folder
- Created the CoverType Upsert View and updated CoverType
- Added the delete funtion as well

1059

- Creating a new products folder
- Created Product Class
- Modified the product class
- Added it to the ApplicationDbContext.cs file
- Added migration
- TIMESTAMP: 20231120045758_AddProductToDb
- Updated Database

- Added [Required] to title, ISBN and Authors in Product.cs class file
- updated-database
- Added new migration
- updated database


1110

- Added Product to the Repository
- Added IProductRepository Interface
- Added ProductRepository Class and made modifications
- Updated Database
- Added Product to UnitOfWork and IUnitOfWork
- Clean solution and built solution
