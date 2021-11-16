# Urgencias.App
This is still a draft for the assigned project. 
There are some thigs still missing, but as of now it can run, add people and do many of the things asked in the activity. 
If you want to try it on a database you should fist go to AppContext and copy the route for the desired database. 
you can do a migration of the tables by following the next steps:
1. Go to persistencia. and copy the following line:
dotnet ef migrations add third --startup-project ..\Urgencias.App.Consola\
next, you update your databse with the next line:
dotnet ef database update --startup-project ..\Urgencias.App.Consola\
Thanks. 
