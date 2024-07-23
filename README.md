# BlogPostsExample

## Introduction
Simple ASP. NET project for a RESTful API that manages a blog posts platform.
It is built using the framework ASP.NET Core, and the libraries Swagger and Swashbuckle.
There is a usage section down below, with detailed instructions on how to run and edit the project.

## Entities
It consists mainly of two classes: BlogPosts and Comments, which will be explained further.

### BlogPost
The BlogPost class represents a blog post in the application.
It has a unique identifier (ID) and contains information about the post, such as the title, content, and associated comments.

Properties
ID (Guid): A unique identifier for the blog post.
Title (string): The title of the blog post.
Content (string): The content of the blog post.
Comments (List<Comment>): A list of comments associated with the blog post.
Constructor
BlogPost(string title, string content): Initializes a new instance of the BlogPost class with the specified title and content.
The ID is automatically generated, and the Comments list is initialized as an empty list.

### Comments
The comments class is rather simple, represents a single comment that belongs to a blogPost.

Properties
Content (string): The content of the comment.

## Endpoints
All API's endpoints and their respective funcionalities are listed below.
The HTTP method for each funcionality is written between "[]"

### [GET] /api/posts
Returns a full list of all the blog posts, their titles, content, and the number of comments
that each blog post have.

### [POST] /api/posts
Creates a new blog post. The user is required to provide a title and content to create the blog post.

### [DELETE] /api/posts/{id}
Delete a blog post, given that the user provides a valid blogPost ID.

### [GET] /api/posts/{id}
Retrieves a single blog post, with a list of all it's comments

### [POST] /api/posts/{id}/comments
Add a comment to a blog post, given that the user provides a valid blogPost ID. The comment content is required.

## Usage
The user needs to clone this project in a Linux or Windows machine.
The software requirements to run this project are:
dotnet 7.0 or higher

Once the code is running, either in the commend prompt or in a source code editor,
the user can interact with the API using the host: localhost and the port is automatically generated,
the user should check in the console on which port the program is running.
To interact with the API, the user can either choose to use Swagger in a web browser, or do custom
HTTP calls following the documentation in another manner, such as curl calls or a third party tool such as Postman.
