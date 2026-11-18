
using System;

// Create the game board
char[] gameBoard = { '1', '2', '3',
                     '4', '5', '6',
                     '7', '8', '9' };

char currentPlayer = 'X';
int numberPlayed;
bool isGameOver = false;

Console.WriteLine("--- TIC TAC TOE ---");

while (!isGameOver)
{
    // Display the board
    Console.WriteLine();
    Console.WriteLine($" {gameBoard[0]} | {gameBoard[1]} | {gameBoard[2]}");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {gameBoard[3]} | {gameBoard[4]} | {gameBoard[5]}");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {gameBoard[6]} | {gameBoard[7]} | {gameBoard[8]}");

    // Ask current player for input
    Console.WriteLine();
    Console.WriteLine($"Player {currentPlayer}, enter a number (1-9):");

    if (!int.TryParse(Console.ReadLine(), out numberPlayed) ||
        numberPlayed < 1 || numberPlayed > 9)
    {
        Console.WriteLine("Invalid input! Try again.");
        continue;
    }

    // Check if position is already occupied
    if (gameBoard[numberPlayed - 1] == 'X' ||
        gameBoard[numberPlayed - 1] == 'O')
    {
        Console.WriteLine("Position already taken! Try again.");
        continue;
    }

    // Place the player's mark
    gameBoard[numberPlayed - 1] = currentPlayer;

    // Check for winner
    if (CheckWinner(gameBoard))
    {
        Console.WriteLine();
        DisplayBoard(gameBoard);
        Console.WriteLine($"Player {currentPlayer} wins!");
        isGameOver = true;
    }
    // Check for draw
    else if (IsDraw(gameBoard))
    {
        Console.WriteLine();
        DisplayBoard(gameBoard);
        Console.WriteLine("It's a draw!");
        isGameOver = true;
    }
    else
    {
        // Switch players
        if (currentPlayer == 'X')
            currentPlayer = 'O';
        else
            currentPlayer = 'X';
    }
}
Console.WriteLine("Game Over!");

// Check all possible winning combinations
static bool CheckWinner(char[] b)
{
    int[,] winningPositions =
    {
        { 0, 1, 2 },
        { 3, 4, 5 },
        { 6, 7, 8 },
        { 0, 3, 6 },
        { 1, 4, 7 },
        { 2, 5, 8 },
        { 0, 4, 8 },
        { 2, 4, 6 }
    };

    for (int i = 0; i < 8; i++)
    {
        if (b[winningPositions[i, 0]] ==
            b[winningPositions[i, 1]] &&
            b[winningPositions[i, 1]] ==
            b[winningPositions[i, 2]])
        {
            return true;
        }
    }

    return false;
}

// Check whether the board is full
static bool IsDraw(char[] b)
{
    foreach (char position in b)
    {
        if (position != 'X' && position != 'O')
            return false;
    }

    return true;
}

// Display the final board
static void DisplayBoard(char[] gameBoard)
{
    Console.WriteLine($" {gameBoard[0]} | {gameBoard[1]} | {gameBoard[2]}");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {gameBoard[3]} | {gameBoard[4]} | {gameBoard[5]}");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {gameBoard[6]} | {gameBoard[7]} | {gameBoard[8]}");
}

