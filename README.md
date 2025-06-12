# ItWorksDoNotTouch

![alt text](https://github.com/referencenull/ItWorksDoNotTouch/blob/main/donottouch.png?raw=true)

## Business Application - Web Version

This application has been upgraded from a console application to a modern web application using ASP.NET Core. It demonstrates GitHub Copilot capabilities through various text processing, pattern generation, and mathematical operations.

### Features

- **String Operations:**
  - Reverse String - Reverses the characters in input text
  - Remove Whitespace - Removes all spaces from input text

- **Pattern Generation:**
  - Letter Pattern - Creates diamond patterns using letters
  - Star Pattern - Creates diamond patterns using stars

- **Mathematical Operations:**
  - Circle Area Calculator - Computes area from radius
  - Prime Number Checker - Determines if a number is prime

### How to Run

1. **Prerequisites:**
   - .NET 8.0 SDK or later
   - A web browser

2. **Running the Application:**
   ```bash
   cd BusinessApp
   dotnet run
   ```

3. **Access the Application:**
   - Open your web browser
   - Navigate to `http://localhost:5000`
   - Use the navigation menu to access different operations

### Web Interface

The application provides:
- A clean, responsive web interface
- Individual pages for each operation
- Real-time processing via REST API calls
- Interactive forms with validation

### API Endpoints

For programmatic access, the following REST API endpoints are available:

- `POST /api/string/reverse` - Reverse a string
- `POST /api/string/remove-whitespace` - Remove whitespace from a string
- `POST /api/pattern/letter` - Generate letter patterns
- `POST /api/pattern/star` - Generate star patterns  
- `POST /api/math/circle-area` - Calculate circle area
- `POST /api/math/prime-check` - Check if number is prime

### Technology Stack

- **Backend:** ASP.NET Core 8.0
- **Frontend:** HTML, CSS, JavaScript
- **Architecture:** MVC pattern with service layer
- **APIs:** RESTful JSON endpoints

### Development

The application follows clean architecture principles:
- Controllers handle HTTP requests/responses
- Services contain business logic
- Models define data contracts
- Views provide user interface
