# [Vendor Tracker for Della's Bakery](https://github.com/ayohana/VendorTracker.git/)

#### C# Basic Web Applications Exercise for [Epicodus](https://www.epicodus.com/), 03.13.2020

#### By [**Adela Darmansyah**](https://ayohana.github.io/portfolio/)

## Description

**This application is for Della's Bakery to help keep track of their vendors and orders of baked goods belonging to those vendors.** For example, Della supplies croissants to a vendor called Suzie's Cafe weekly. Della will be able to enter _"Suzie's Cafe"_ as a vendor and their order of _"croissants"_ to help keep track of Della's expanding business relationships.

## User Stories

* As a bakery owner, I want to be able to enter my vendors so that I can keep track of all my clients.
* As a bakery owner, I want to be able to click on each vendor so that I can see each of their description in detail.
* As a bakery owner, I want to be able to enter orders belonging to vendors so that I can keep track of my clients' demands.
* As a bakery owner, I want to be able to see all the orders belonging to a vendor so that I can prepare what I need to bake ahead of time.
* As a developer, I want to see a splash page with a sweet welcome message so that I can welcome the bakery owner to their application.

## HTTP Routes using RESTful convention

| Route Name | URL Path | HTTP Method | Purpose |
| :--------- | :------- | :---------- | :------ |
| `Home:` Index | / | GET | `Homepage:` Displays splash page |
| `Vendors:` Index | /vendors | GET | Displays list of all vendors |
| `Vendors:` New | /vendors/new | GET | Offers form to create a new vendor |
| `Vendors:` Create | /vendors | POST | Creates a new vendor on server |
| `Vendors:` Show | /vendors/{vendorID} | GET | Displays one specific vendor's details including a list of all orders associated to the vendor |
| `Vendors:` Create | /vendors/{vendorID}/orders | POST | Creates a new order within one specific vendor |
| `Orders:` New | /vendors/{vendorID}/orders/new | GET | Offers form to create a new order within one specific vendor |
| `Orders:` Show | /vendors/{vendorID}/orders/{orderID} | GET | Displays one specific order's details within one specific vendor |

## Setup/Installation Requirements

* Download [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
* Clone this [repository](https://github.com/ayohana/VendorTracker.git)
* Open the `Command Line Interface`.
  * Navigate into the `VendorTracker` directory.
    * Type in the command `dotnet restore` to gather tools and dependencies for the application.
    * Type in the command `dotnet run` to run the application.
  * Navigate into the `VendorTracker.Tests` directory.
    * Type in the command `dotnet restore` to gather tools and dependencies for the tests.
    * Type in the command `dotnet test` to run the tests. 

## Known Bugs

No known bugs at this time.

## Support and contact details

Feel free to provide feedback via email: adela.yohana@gmail.com.

## Technologies Used

* C#
* [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
* MVC Pattern

### License

This C# console application is licensed under the MIT license.

Copyright (c) 2020 **Adela Darmansyah**
