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


Every View before rendering, it will inherit view start and => Layout

MovieCard view in multiple views
Home/index -> MovieCard
User/purchases => MovieCard
User/Favorites => MovieCard

Partial View => MovieCardPartial and then you can reuse it across multiple views

Dependency Injection
Design Pattern that enables you to write loosely coupled code
tightly coupled code vs loosely coupled

easy to maintain
easy to test
easy to change the functionality without changing much of the code


method(int x, IMovieService service)

var movieService = new MovieService();
var movieService2 = new MovieTestService();

method(5, movieService)

HomeController c = new HomeController();