## Information
This challenge is about working with a ASP.NET MVC application and how to configure certain functionality.

#### Step 1
When a user visits the site on "/", the user should be shown the "HelloWorld" view. 

Please do this while using the default routes.

#### Step 2
When a user visits "/Home/Page/1", the user should be shown the default view ("Page") together with a PageViewModel containing the current page id.

Though when the user visits with a number lower than 1, such as "Home/Page/-1", it should be redirected back to the Index action.

#### Step 3
The owner of the website wants to run a new page for his limited sale. This page should be accessable through "/summer-deal" and should show the "Deal" view.

Please extend the routes so this is set up correctly.

#### Step 4
There also needs to be a new page when visiting "/News", which returns a NewsViewModel with the news items from NewsBaseController.News

#### Step 5
When visiting "/News/Search" it should be possible to post a SearchPostModel to filter the news items with, which need to be displayed in a SearchViewModel.

#### Step 6
"/News/Feed" should have the same functionality as "/News/Search", except it should return a JsonResult instead.

#### Notes
- Routes can be found in "App_Start/RouteConfig.cs".
- There are no actuall views in this project, as these will not be rendered in test cases.
- This project is a replica of a C# MVC project that would normally run within IIS or IIS Express, this means some functionallity/contents might not be working or can be different.