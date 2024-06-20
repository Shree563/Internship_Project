"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var fs = require("fs");
// Example data
var users = [
    { id: 1, name: 'Alice', email: 'alice@example.com' },
    { id: 2, name: 'Bob', email: 'bob@example.com' },
];
// Function to load data from JSON file
function loadUsers(filename) {
    try {
        var data = fs.readFileSync(filename, 'utf8');
        return JSON.parse(data);
    }
    catch (error) {
        console.error('Error reading file:', error);
        return [];
    }
}
// Function to save data to JSON file
function saveUsers(filename, users) {
    try {
        fs.writeFileSync(filename, JSON.stringify(users, null, 2), 'utf8');
        console.log('Data has been saved.');
    }
    catch (error) {
        console.error('Error writing file:', error);
    }
}
// Usage example
var filename = './data/users.json';
// Load existing users from JSON file
var existingUsers = loadUsers(filename);
console.log('Existing users:', existingUsers);
// Add a new user
var newUser = { id: 3, name: 'Charlie', email: 'charlie@example.com' };
existingUsers.push(newUser);
// Save updated users to JSON file
saveUsers(filename, existingUsers);
