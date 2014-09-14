var cells = document.getElementsByTagName('td'),
    numberOfCells = cells.length,
    playerOneChar = 'X',
    playerTwoChar = 'O',
    playerOneTurn = true;

console.log(numberOfCells);
console.log(cells[2].innerHTML === '');

for (var i = 0; i < numberOfCells; i += 1) {
    cells[i].addEventListener('click', updateGame, false);
}

function updateGame(event) {
    event = event || window.event;

    if (playerOneTurn) {
        event.target.innerHTML = playerOneChar;
    } else {
        event.target.innerHTML = playerTwoChar;
    }

    // One of the players placed
    // three of his characters.
    if (isThereAWinner()) {
        if (playerOneTurn) {
            alert('Player one wins the game!');
        } else {
            alert('Player two wins the game!');
        }
        window.location.reload();
    }

    // No empty cells left and
    // there is no winner.
    if (isGameOver()) {
        alert('Game over. No winner.');
        window.location.reload();
    }

    playerOneTurn = !playerOneTurn;

    event.target.removeEventListener('click', updateGame, false);
}

function isThereAWinner() {
    var board = [],
        rowIndex = 0,
        playerOneSequence = playerOneChar + playerOneChar + playerOneChar,
        playerTwoSequence = playerTwoChar + playerTwoChar + playerTwoChar,
        sequence = '';

    for (var i = 0; i < numberOfCells; i += 3) {
        board[rowIndex] = [];
        board[rowIndex].push(cells[i].innerHTML);
        board[rowIndex].push(cells[i+1].innerHTML);
        board[rowIndex].push(cells[i+2].innerHTML);
        rowIndex += 1;
    }

    for (var row = 0; row < board.length; row += 1) {
        sequence = board[row][0] + board[row][1] + board[row][2];

        if (sequence === playerOneSequence || sequence === playerTwoSequence) {
            return true;
        }
    }

    for (var col = 0; col < board.length; col += 1) {
        sequence = board[0][col] + board[1][col] + board[2][col];

        if (sequence === playerOneSequence || sequence === playerTwoSequence) {
            return true;
        }
    }

    var diag1 = board[0][0] + board[1][1] + board[2][2],
        diag2 = board[0][2] + board[1][1] + board[2][0];

    if (diag1 === playerOneSequence || diag1 === playerTwoSequence) {
        return true;
    }

    if (diag2 === playerOneSequence || diag2 === playerTwoSequence) {
        return true;
    }

    return false;
}

function isGameOver() {
    var occupiedCells = 0;

    for (var i = 0; i < numberOfCells; i += 1) {
        if (cells[i].innerHTML !== '') {
            occupiedCells += 1;
        }
    }

    if (occupiedCells === numberOfCells) {
        return true;
    }

    return false;
}
