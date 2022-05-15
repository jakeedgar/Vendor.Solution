# _Pierre's Vendor Site_

## By: Jake Edgar

#### A website for Vendors to host their bakery goods.

## _Technologies Used:_

* C#
* MSTest
* .NET
* Markdown
* MVC

## Description 

A website which allows users to create multiple vendors each with multiple orders and easily navigate between them.

## Installation and Setup Requirements

* Navigate to your preferred code Editing Software.
* Clone this repository to your desktop by using the command *git clone* followed by this link https://github.com/jakeedgar/Vendor.Solution.git
* Navigate to the top level of the directory. 
* Run *dotnet --version* in your command terminal to check what version of dotnet you are running. If it is not 5.0 or newer, please review the information at this link: *https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.401-macos-x64-installer* and update your version. This will ensure that both C# and dotnet are installed and updated on your machine. 
* Make sure the dotnet script REPL is installed or run *dotnet tool install -g dotnet-script* to install it globally on your machine. 
* Navigate to the root directory of Vendor.Solution and use a launch command to open the directory in your preferred editing software. I recommend VSCode, especially for C# and dotnet projects. 
* To install the testing environment navigate to the directory titled: Vendor.Tests in your command line, and run the command *dotnet restore*. 
* Run *dotnet test* to confirm the environment is working correctly. 
* After updating the testing environment, navigate to the directory titled: Vendor in your command line, and then run *dotnet build*.
* After it builds successfully, run *dotnet watch run* to create a live server for the website to be hosted. Navigate to *localhost:5000* on your desired web browser, I recommend google chrome.
* Enjoy the site!


## Known Bugs
* The delete function for the orders does not remove the order from the list generated when its first added, and clicking on that link will bring you to a broken page. 

## License

Licensed under the [MIT License](LICENSE).
Copyright (c) 2022 Jake Edgar