# A Simple App

This project is a simple web application created for learning purposes. The primary goal is to explore and gain experience with various programming basics, including Python, Flask, Docker, C#, HTML, CSS, and JavaScript.

## Project Overview

The project consists of a basic web application with a Flask backend and a frontend built using HTML, CSS, and JavaScript. The backend provides a simple API endpoint that the frontend interacts with.

### Features

- **Flask Backend:** A minimal Flask application that responds with a "Hello from Flask!" message when accessed.
- **C# Console Application:** A basic C# console application that interacts with the Flask backend by making an HTTP request.
- **HTML, CSS, and JavaScript Frontend:** A simple webpage with a button to trigger a call to the Flask backend and display the response.

### Project Structure

The project is structured into the following directories:

- **backend:** Contains the Flask backend code.
- **csharp:** Includes the C# console application code.
- **frontend:** Houses the HTML, CSS, and JavaScript files for the frontend.

## Getting Started

Follow these steps to set up and run the project locally:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/YOUR_USERNAME/A-simple-app.git
   cd A-simple-app

**Run Flask Backend:**
```bash
cd backend
pip install -r requirements.txt
python app.py
```

**Build and Run C# Application:**
``` bash
cd ../csharp
dotnet build
dotnet run
```

**Serve Frontend:**
Open a new terminal and navigate to the project root:
```bash
python -m http.server
```

Visit http://localhost:8000/frontend/ in your browser.

**Interact with the App:**

Click the "Call Backend" button on the frontend to trigger a request to the Flask backend.
View the response displayed on the webpage.

# Important Notes
**Learning Purposes Only:**
This project is designed for learning purposes. It serves as a hands-on exploration of various technologies and programming languages.

**Collaborative Learning:**
The code may include contributions or adaptations from external sources. The project is a collaborative effort to understand and implement different aspects of software development.

**Dockerization:**
The application can be containerized using Docker. A Dockerfile is included for this purpose.

**Contributions:**
Contributions to improve or extend the functionality of the project are welcome. Feel free to submit issues or pull requests.

**License**
This project is licensed under the MIT License - see the LICENSE file for details.
