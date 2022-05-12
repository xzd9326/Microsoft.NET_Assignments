MVC -> Model 
View 
Controller -> a C# class that inherits from Controller class
			-> Many Action methods

return View() will return the view with the same name as action method name
return View("someviewname") also

Views in MVC are called Razor view with cshtml extension -> combine C# and HTML code

HTTP Requests ->
GET => top 30 movies, get user by id, get movies for genre is 3
POST => Register User, Login
PUT => Edit Profile
DELETE => Delet account

Get User Info
GET https://localhost:7211/user/details/1
1. UserController -> Controllers
2. Create Details action method -> GET
3. User folder inside Views
4. Create details.cshtml

Organize our code properly
Code should be reusable code and easily testable

Entities represents your Database tables
Movie table => Movie class columns will be mapped with properties
Genre => Genre class

Models/ViewModels/DTO (Data Transfer Objects) => Views
Home Page => MovieCardModel => PosterUrl, Id, Title
You create model classes based on the requirement of the view
(model used for view, entity used for database)

Repositories classes/interfaces they deal with Entity classes
Services classes/interfaces they deal with Model classes