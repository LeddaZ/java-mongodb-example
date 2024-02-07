using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

internal class Program
{
    static int windowHeight = 20;
    static int windowWidth = 40;
    static int score = 0;
    static Queue<Position> snake = new Queue<Position>();
    static Position food = new Position(0, 0);
    static Random randomGenerator = new Random();
    static bool gameover = false;
    static string direction = "Right";

    static void Main()
    {
        Console.WindowHeight = windowHeight;
        Console.WindowWidth = windowWidth;
        Console.BufferHeight = windowHeight;
        Console.BufferWidth = windowWidth;

        InitializeGame();

        while (!gameover)
        {
            Draw();
            Input();
            Move();
            CheckCollision();
            Thread.Sleep(100);
        }

        Console.SetCursorPosition(windowWidth / 2 - 5, windowHeight / 2);
        Console.Write("Game Over! Score: " + score);
        Console.ReadKey();
    }

    static void InitializeGame()
    {
        snake.Clear();
        score = 0;
        gameover = false;
        direction = "Right";

        // Initialize snake
        for (int i = 0; i < 4; i++)
        {
            snake.Enqueue(new Position(i, 0));
        }

        // Initialize food
        SetFoodPosition();
    }

    static void SetFoodPosition()
    {
        int x = randomGenerator.Next(1, windowWidth - 1);
        int y = randomGenerator.Next(1, windowHeight - 1);
        food = new Position(x, y);

        // Make sure the food doesn't spawn on the snake
        while (snake.Contains(food) || (food.X == 0 && food.Y == 0))
        {
            x = randomGenerator.Next(1, windowWidth - 1);
            y = randomGenerator.Next(1, windowHeight - 1);
            food = new Position(x, y);
        }
    }

    static void Draw()
    {
        Console.Clear();

        // Draw snake
        foreach (var position in snake)
        {
            Console.SetCursorPosition(position.X, position.Y);
            Console.Write("*");
        }

        // Draw food
        Console.SetCursorPosition(food.X, food.Y);
        Console.Write("#");

        // Draw score
        Console.SetCursorPosition(windowWidth - 10, 0);
        Console.Write("Score: " + score);
    }

    static void Input()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (direction != "Down")
                        direction = "Up";
                    break;
                case ConsoleKey.DownArrow:
                    if (direction != "Up")
                        direction = "Down";
                    break;
                case ConsoleKey.LeftArrow:
                    if (direction != "Right")
                        direction = "Left";
                    break;
                case ConsoleKey.RightArrow:
                    if (direction != "Left")
                        direction = "Right";
                    break;
            }
        }
    }

    static void Move()
    {
        Position snakeHead = snake.Last();
        Position newHead = new Position(snakeHead.X, snakeHead.Y);

        switch (direction)
        {
            case "Up":
                newHead.Y--;
                break;
            case "Down":
                newHead.Y++;
                break;
            case "Left":
                newHead.X--;
                break;
            case "Right":
                newHead.X++;
                break;
        }

        snake.Enqueue(newHead);

        // Check if snake eats food
        if (snake.Contains(food))
        {
            score++;
            SetFoodPosition();
        }
        else
        {
            // Remove tail if the snake doesn't eat food
            Position tail = snake.Dequeue();
            Console.SetCursorPosition(tail.X, tail.Y);
            Console.Write(" ");
        }

        // Check if snake collides with itself
        if (snake.Count != snake.Distinct().Count())
        {
            gameover = true;
        }

        // Check if snake collides with walls
        if (newHead.X < 0 || newHead.X >= windowWidth || newHead.Y < 0 || newHead.Y >= windowHeight)
        {
            gameover = true;
        }
    }

    static void CheckCollision()
    {
        // Check if snake head collides with itself or walls
        Position head = snake.Last();
        if (snake.Take(snake.Count - 1).Any(p => p.X == head.X && p.Y == head.Y))
        {
            gameover = true;
        }
    }
}

class Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}
