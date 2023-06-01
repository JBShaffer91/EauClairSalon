# Eau Claire's Salon Management System

## About

This is a MVC web application built for Eau Claire's Salon to help manage stylists and their clients. The application allows the salon owner to add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. 

## User Stories

* See a list of all stylists.
* Select a stylist, see their details, and see a list of all clients that belong to that stylist.
* Add new stylists to our system when they are hired.
* Add new clients to a specific stylist. 

## Technologies Used

- .NET 6.0 SDK
- C#
- ASP.NET Core MVC
- Entity Framework Core
- Razor
- MySQL Server
- MySQL Workbench
- CSS
- HTML

## Setup/Installation Requirements

To run this project, you must have the following installed:

* [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* [MySQL](https://dev.mysql.com/downloads/file/?id=484914)

After installation, follow these steps:

1. Clone the repository: `git clone https://github.com/<your_username>/HairSalon`.
2. Navigate into the `HairSalon` directory: `cd HairSalon`.
3. Open in your preferred text editor to view the code base.
4. Create your `appsettings.json` file in the `HairSalon` directory. Here is a sample setup:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=<first_last>;uid=root;pwd=;"
  }
}
```

To start the application:

1. Run `dotnet restore`.
2. Run `dotnet build`.
3. Run `dotnet run`.
4. Open a web browser and go to `http://localhost:5000`.

## Known Bugs

No known bugs at this time.

## Support and contact details

If you have any issues or have questions, ideas, or concerns, contact me at `justinbshaffer91@gmail.com`.

## License

Copyright 2023 Justin Shaffer

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


