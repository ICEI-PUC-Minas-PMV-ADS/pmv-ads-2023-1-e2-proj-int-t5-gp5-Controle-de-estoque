const express = require('express');
const path = require('path');

const app = express();

app.use(express.static(path.join(__dirname, 'View')));

app.get('/Account', (req, res) => {
    res.sendFile(path.join(__dirname, '/View/Account/index.cshtml'));
});

app.listen(3000, () => {
    console.log('Servidor rodando na porta 3000');
});
