# Core-Practice
## Middleware
#### At its core, middleware in ASP.NET Core is a series of components that form a pipeline through which every HTTP request and response flows. <br>
  #### Each middleware component can:<br>
  **1- Examine** the incoming request.<br>
  **2- Modify** the request or response (if needed).<br>
  **3- Invoke** the next middleware in the pipeline or short-circuit the process and generate a response itself.<br>
#### This pipeline allows you to modularize your application's logic and add features like authentication, logging, error handling, routing, and more in a clean and maintainable way.<br>

## **app.Use vs. app.Run**<br>
#### These two methods are fundamental for adding middleware to your pipeline, but they have key differences:<br>
#### **app.Use(async (context, next) => { ... })**<br>
  **Non-Terminal Middleware**: This type of middleware typically performs some action and then calls the next delegate to pass control to the next middleware in the pipeline.<br>
  **Can Modify Request/Response**: It can change the request or response before passing it along.<br>
  **Examples**: Authentication, logging, custom headers, etc.<br>

#### **app.Run(async (context) => { ... })**<br>
**Terminal Middleware**: This middleware doesn't call next; it ends the pipeline and generates the response itself.<br>
**Often Used for the Final Response**: It's commonly used for handling requests that don't need further processing (e.g., returning a simple message).<br>
**Can't Modify Request**: Since it's the end of the line, it cannot modify the request before passing it on.<br>



