# Basic-C-Sharp-Projects
This repository contains C# projects that I completed as a student at The Tech Academy

# Featured Projects:
- <a href="https://github.com/sseyler0119/Basic-C-Sharp-Projects/tree/master/Branching-ShippingQuote">Branch Shipping Quote Console App</a>
- <a href="https://github.com/sseyler0119/Basic-C-Sharp-Projects/tree/master/TwentyOne">Casino Console App</a>
- <a href="https://github.com/sseyler0119/Basic-C-Sharp-Projects/tree/master/NewsletterAppMVC">Newsletter Sign-Up</a>
- <a href="https://github.com/sseyler0119/Basic-C-Sharp-Projects/tree/master/CarInsurance">Car Insurance Quote</a>

## Branch Shipping Quote 

This project is a simple console app that gets input from the user and either generates a shipping quote or notifies the user that their package cannot be shipped if it is too heavy or too large to be shipped. 

## Grand Hotel Casino App

This is a basic console app built in the .NET Framework that creates a Twenty One card game. It utilizes namespaces, classes, and inheritance in a way that would allow the app to be expanded to other <a href="https://github.com/sseyler0119/Basic-C-Sharp-Projects/tree/master/Casino">Casino</a> card games. Included classes: Card, Dealer, Deck, Player, Game, and a Fraud Exception class to alert Casino security when fraudulent activity is detected. Additionaly, the following classes utilize inheritance :TwentyOneDealer inherits from Dealer and TwentyOneGame inherits from Game. The TwentyOneRules class is used to define the rules of TwentyOne and includes methods that determine if a player/dealer has busted, if the dealer should hit or stay, or if either has Blackjack.

## Car Insurance Quote


## Newsletter Sign-Up

This is simple ASP.NET MVC web app used to get and keep track of newsletter signups. ADO.NET is used to send/retrieve information to/from the Newsletter SQL database. There is an Admin and Home controller along with corresponding views to render the information to the user using Bootstrap styling. The Home view uses a simple form to collect signup information from the user, and the Home Controller SignUp method stores this informatin in a database. The Admin view passes in a viewmodel as a list to limit information sent directly to the Admin page. The Admin Controller contains a function to retrieve user information from the database and an unsubscribe function to update the database that a user has unsubscribed from the newsletter.
