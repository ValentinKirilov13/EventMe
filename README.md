# EventMe 👩🏻‍💻
My first ASP.NET project with MVC pattern.

Functionality:
- Basic CRUD operations
- Processing with GET and POST requests

The application is basic event manager where you can add upcomming events, also delete and update them. It have responsive design with dinamic fields in form.

To RUN the application:
- all you need to do is to open "appsettings.json" and change "connectionString" field with your local Database server connectionString
- apply migrations with Package Manager Console -> Update-Database command

Clarification ❗❗❗

For this project I have used MS SQL Server and the Entity provider is SQLServer, if you want to run in other Database server you need to download package with provider for your database. After that you need to change in "Program.cs" -> IoC container -> "add database service" -> opt.(Your provider) to use your provider.

# Home Page
![Screenshot 2024-02-07 161725](https://github.com/ValentinKirilov13/EventMe/assets/144913661/8668ad9c-d48d-4bd5-87f5-78d5fe10b4d5)
# Explore Page
![Screenshot 2024-02-07 161902](https://github.com/ValentinKirilov13/EventMe/assets/144913661/d4d22121-b612-47dd-bb57-c15ec632090f)
# Add Page
![Screenshot (39)](https://github.com/ValentinKirilov13/EventMe/assets/144913661/39c49b59-cdf5-4195-9410-50905db3ee69)
# Edit Page
![Screenshot 2024-02-07 162057](https://github.com/ValentinKirilov13/EventMe/assets/144913661/011d8a6f-7b0c-4789-b4cf-5050397519c3)
# Delete Page
![Screenshot 2024-02-07 162021](https://github.com/ValentinKirilov13/EventMe/assets/144913661/3ec32b98-69d1-4073-8a2e-d8198a85c732)
