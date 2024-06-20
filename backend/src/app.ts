import express from 'express';
import bodyParser from 'body-parser';
import cors from 'cors';
import * as fs from 'fs';

interface User {
    id: number;
    name: string;
    email: string;
    phone?: string;
    githubLink?: string;
    stopwatch?: string;
}

const app = express();
const port = 3000;
const filename = './src/data/users.json';

app.use(bodyParser.json());
app.use(cors());

function loadUsers(): User[] {
    try {
        const data = fs.readFileSync(filename, 'utf8');
        return JSON.parse(data);
    } catch (error) {
        console.error('Error reading file:', error);
        return [];
    }
}

function saveUsers(users: User[]): void {
    try {
        fs.writeFileSync(filename, JSON.stringify(users, null, 2), 'utf8');
        console.log('Data has been saved.');
    } catch (error) {
        console.error('Error writing file:', error);
    }
}

app.get('/users', (req, res) => {
    const users = loadUsers();
    res.json(users);
});

app.post('/users', (req, res) => {
    const users = loadUsers();
    const newUser: User = { id: users.length + 1, ...req.body };
    users.push(newUser);
    saveUsers(users);
    res.status(201).json(newUser);
});

app.listen(port, () => {
    console.log(`Server is running on http://localhost:${port}`);
});


// DELETE user by id
app.delete('/users/:id', (req, res) => {
    const userId = parseInt(req.params.id);
    let users = loadUsers();
    users = users.filter(user => user.id !== userId);
    saveUsers(users);
    res.status(200).json({ message: 'User deleted successfully' });
});
