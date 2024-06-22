# Internship_Project

This project is a Windows Form application with a TypeScript Express backend for managing submissions.

## Technologies Used

- **Frontend:** .NET Framework, C#
- **Backend:** TypeScript, Express.js

## How to Run

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/Shree563/Internship_Project.git

### Frontend (Windows Form Application)

**1.Inside the Internship_Project folder, you mentioned there are frontend and backend folders.**

Frontend:

Open a separate Visual Studio Code window (assuming you're using VS Code) and navigate to the frontend folder:

cd frontend

code .

Open Form1.Designer.vb in Visual Studio by navigating to the file and using Shift + F7 to switch to the designer view.

Run the form by clicking on the play button in Visual Studio.


### Backend (TypeScript Express Server) ---> CODE IS AVAILABLE IN FOLDER BACKEND-->SRC--->  APP.TS

**Similarly, open another Visual Studio Code window and navigate to the backend folder:**

cd backend

code .

**Install Dependencies:**

**1.Open the developer shell in Visual Studio.**

Navigate to the backend folder:

cd backend

**2.Install necessary dependencies**

PS C:\Users\shree\source\repos\Internship_Project\backend> npm install

PS C:\Users\shree\source\repos\Internship_Project\backend> npm install --save-dev @types/cors

PS C:\Users\shree\source\repos\Internship_Project\backend> npm install express body-parser cors

**3. Build and Run the Backend:**

Compile TypeScript files

PS C:\Users\shree\source\repos\Internship_Project\backend> tsc

PS C:\Users\shree\source\repos\Internship_Project\backend> node dist/app.js

Server is running on http://localhost:3000 // this means the backend is up and running

### Execution Flow

Once the backend server is confirmed to be running, proceed with executing the Windows Form application.
