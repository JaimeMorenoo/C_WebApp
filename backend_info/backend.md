# BackEnd

## The Web Server
A web server is a process running on a computer that listens for incoming requests for information over the internet and sends back responses. Each time a user navigates to a website on their browser, the browser makes a request to the web server of that website. Every website has at least one web server. 

The specific format of a request (and the resulting response) is called the protocol. You might be familiar with the protocol used to access websites: HTTP. For the simplest websites, a client makes a single request. The web server receives that request and sends the client a response containing everything needed to view the website. This is called a static website. 

A static website might be a good choice for a simple personal website with a short bio and family photos. A user navigating Twitter, however, wants access to new content as it’s created, which a static website couldn’t provide.


## So What is the Back-end?
The collection of programming logic required to deliver dynamic content to a client, manage security, process payments, and myriad other tasks is sometimes known as the “application” or application server. 

The application server can be responsible for anything from sending an email confirmation after a purchase to running the complicated algorithms a search engine uses to give us meaningful results.

## Storing Data
The back-ends of modern web applications include some sort of database, often more than one. Databases are collections of information. There are many different databases, but we can divide them into two types: relational databases and non-relational databases (also known as NoSQL databases). 

## What is an API?
When a user navigates to a specific item for sale on an e-commerce site, the price listed for that item is stored in a database, and when they purchase it, the database will need to be updated with the correct inventory for that item type. In fact, much of what the back-end entails is reading, updating, or deleting information stored in a database.

In order to have consistent ways of interacting with data, a back-end will often include a web API. API stands for Application Programming Interface and can mean a lot of different things, but a web API is a collection of predefined ways of, or rules for, interacting with a web application’s data, often through an HTTP request-response cycle.

## Authorization and Authentication
Two other concepts we’ll want our server-side logic to handle are authentication and authorization.

+ Authentication is the process of validating the identity of a user.
+ Authorization controls which users have access to which resources and actions.


