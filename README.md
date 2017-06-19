# BooksAPI
#### Introduction
Simple web api with books loaded from XML. User can search and show all books using the web client. Service is written in C# using Visual Studio for development. 

#### How to use
1. Download/clone github repo
2. Open the .sln using Visual Studio
3. Run the project 

#### Filepath of XML
'''
XDocument doc = XDocument.Load("C:/Users/mikae/Desktop/books.xml");
'''
This filepath needs to be modified. This can be found in BooksController.cs
