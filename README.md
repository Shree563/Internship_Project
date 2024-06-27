# Internship_Project

This project is a Windows Form application with a TypeScript Express backend for managing submissions.

## Technologies Used

- **Frontend:** .NET Framework, VB
- **Backend:** TypeScript, Express.js

## How to Run

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/Shree563/Internship_Project.git

**1.Inside the Internship_Project folder, We have mentioned there are frontend and backend folders.**

### Frontend (Windows Form Application)

Frontend:

Open a separate Visual Studio Code window (assuming you're using VS Code) and navigate to the frontend folder:

cd frontend

code .

Open Form1.Designer.vb in Visual Studio by navigating to the file and using Shift + F7 to switch to the designer view and run the code by clicking on play button.

or

open the form1.vb and run it simply without opening the designer view by clicking on the play button in Visual Studio.

Main Page
![image](https://github.com/Shree563/Internship_Project/assets/173329929/c7cdfc5b-5eee-4413-86c3-ec35e4a0d255)

Create submission
![image](https://github.com/Shree563/Internship_Project/assets/173329929/8a0a6d4c-31ef-48d6-b43a-7ec64ef13360)

View Submission

![image](https://github.com/Shree563/Internship_Project/assets/173329929/e4a145ab-9797-4ad5-b6c4-0c1561d7628d)

![image](https://github.com/Shree563/Internship_Project/assets/173329929/7a8154cf-3869-474f-ad99-370fb226f54c)

![image](https://github.com/Shree563/Internship_Project/assets/173329929/fa3fc6da-30f5-47d8-a8ee-1012ae7af610)


### Backend (TypeScript Express Server) ---> CODE IS AVAILABLE IN FOLDER BACKEND-->SRC--->  APP.TS

**Similarly, open another Visual Studio Code window and navigate to the backend folder:**

cd backend

code .

**Install Dependencies:**

**1.Open the developer shell in Visual Studio.**

Navigate to the backend folder:

cd backend

**2.Install necessary dependencies**

1. Install Node.js and npm
Ensure you have Node.js and npm installed. You can download and install them from [nodejs.org.](https://nodejs.org/en)

PS C:\Users\shree\source\repos\Internship_Project\backend> Install-Package Newtonsoft.Json

PS C:\Users\shree\source\repos\Internship_Project\backend> npm install -g typescript

PS C:\Users\shree\source\repos\Internship_Project\backend> npm install

PS C:\Users\shree\source\repos\Internship_Project\backend> npm install --save-dev @types/cors

PS C:\Users\shree\source\repos\Internship_Project\backend> npm install express body-parser cors

**3. Build and Run the Backend:**

Compile TypeScript files

PS C:\Users\shree\source\repos\Internship_Project\backend> tsc

PS C:\Users\shree\source\repos\Internship_Project\backend> node dist/app.js

Server is running on http://localhost:3000 // this means the backend is up and running

![image](https://github.com/Shree563/Internship_Project/assets/173329929/0a8a66e6-d630-47c8-b163-009e63601c4c)

Data set -JSON file structure

![image](https://github.com/Shree563/Internship_Project/assets/173329929/e38d561e-aef7-4cfd-8393-3e011ea4313b)


### Execution Flow

Once the backend server is confirmed to be running, proceed with executing the Windows Form application.
