"use strict";
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    var desc = Object.getOwnPropertyDescriptor(m, k);
    if (!desc || ("get" in desc ? !m.__esModule : desc.writable || desc.configurable)) {
      desc = { enumerable: true, get: function() { return m[k]; } };
    }
    Object.defineProperty(o, k2, desc);
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const body_parser_1 = __importDefault(require("body-parser"));
const cors_1 = __importDefault(require("cors"));
const fs = __importStar(require("fs"));
const app = (0, express_1.default)();
const port = 3000;
const filename = './src/data/users.json';
app.use(body_parser_1.default.json());
app.use((0, cors_1.default)());
function loadUsers() {
    try {
        const data = fs.readFileSync(filename, 'utf8');
        return JSON.parse(data);
    }
    catch (error) {
        console.error('Error reading file:', error);
        return [];
    }
}
function saveUsers(users) {
    try {
        fs.writeFileSync(filename, JSON.stringify(users, null, 2), 'utf8');
        console.log('Data has been saved.');
    }
    catch (error) {
        console.error('Error writing file:', error);
    }
}
app.get('/users', (req, res) => {
    const users = loadUsers();
    res.json(users);
});
app.post('/users', (req, res) => {
    const users = loadUsers();
    const newUser = { id: users.length + 1, ...req.body };
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
