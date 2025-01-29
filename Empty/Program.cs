

// Create Instance of Web Application
var builder = WebApplication.CreateBuilder(args);

// Build the Application
var app = builder.Build();

// Define the Route
app.MapGet("/", () =>

     "Hello World!"

    
);

// Run the Application
app.Run();
