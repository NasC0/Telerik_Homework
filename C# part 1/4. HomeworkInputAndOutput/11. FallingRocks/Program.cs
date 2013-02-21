using System;
using System.Threading;
using System.Collections.Generic;

struct GameObjects
{
    public int col, row;
    public ConsoleColor color;
    public char sign;
}

struct Dwarf
{
    public int colOne, colTwo, colThree, row;
    public ConsoleColor color;
    public char signOne, signTwo, signThree;
}

class Program
{
    // for dwarf printing
    static void PrintDwarfOnField (int colOne, int colTwo, int colThree, int row, 
        char signOne, char signTwo, char signThree,
        ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(colOne, row);
        Console.ForegroundColor = color;
        Console.Write(signOne);
        Console.SetCursorPosition(colTwo, row);
        Console.ForegroundColor = color;
        Console.Write(signTwo);
        Console.SetCursorPosition(colThree, row);
        Console.ForegroundColor = color;
        Console.Write(signThree);
    }

    // for game objects printing
    static void PrintOnField (int col, int row, char sign,    
        ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(col, row);
        Console.ForegroundColor = color;
        Console.Write(sign);
    }

    // for score printing
    static void PrintStringOnField(int col, int row, string str,    
        ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(col, row);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void Main()
    {
        // player playing field dimensions
        int playFieldWidth = 30;
        int playFieldHeight = 20;

        // dwarf creation
        Dwarf dwarf = new Dwarf();
        dwarf.colOne = (playFieldWidth / 2) - 1;
        dwarf.colTwo = (playFieldWidth / 2);
        dwarf.colThree = (playFieldWidth / 2) + 1;
        dwarf.row = playFieldHeight - 1;
        dwarf.color = ConsoleColor.Yellow;
        dwarf.signOne = '(';
        dwarf.signTwo = '0';
        dwarf.signThree = ')';

        // for random color generation
        ConsoleColor[] randomColor = new ConsoleColor[5]; 
        randomColor[0] = ConsoleColor.Green;
        randomColor[1] = ConsoleColor.Magenta;
        randomColor[2] = ConsoleColor.Cyan;
        randomColor[3] = ConsoleColor.Blue;
        randomColor[4] = ConsoleColor.White;

        // for random char generation
        char[] randomChar = new char[11]; 
        randomChar[0] = '^';
        randomChar[1] = '@';
        randomChar[2] = '*';
        randomChar[3] = '&';
        randomChar[4] = '+';
        randomChar[5] = '%';
        randomChar[6] = '$';
        randomChar[7] = '#';
        randomChar[8] = '!';
        randomChar[9] = '.';
        randomChar[10] = ';';

        // random numbers generator
        Random randomGenerator = new Random();

        // rocks
        List<GameObjects> rocks = new List<GameObjects>();


        // game field and cursor visibility
        Console.CursorVisible = false;
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 60;
        int gameFieldBoundaries = playFieldWidth + 1;

        // game end conditions, speed and score
        int lives = 3;
        double sleepTime = 0.5; 
        double speed = 150;
        int score = 0;

        // Game Rules
        PrintStringOnField(0, 0, "Welcome to the game Falling Rocks!", ConsoleColor.White);
        PrintStringOnField(0, 1, "You are a brave dwarf who is facing a rock-hurling troll!", ConsoleColor.White);
        PrintStringOnField(0, 2, "For each rock you avoid you gain 10 points.", ConsoleColor.White);
        PrintStringOnField(0, 3, "You lose 50 points and 1 life for each rock that hits you!", ConsoleColor.White);
        PrintStringOnField(0, 4, "The game speed increases over time.", ConsoleColor.White);
        PrintStringOnField(0, 5, "Good Luck!!!", ConsoleColor.White);
        PrintStringOnField(0, 6, "To start the game press \"y\", to exit press \"n\"", ConsoleColor.Green);
        Console.SetCursorPosition(0, 7);
        ConsoleKeyInfo yesOrNo = Console.ReadKey(true);
        if (yesOrNo.Key == ConsoleKey.Y)
        // game start
        {
            while (true)
            {
                // game speed
                speed += sleepTime;
                if (speed > 425)
                {
                    speed = 425;
                }

                // hit flag
                bool hit = false;

                // create rocks
                for (int i = 0; i < randomGenerator.Next(0, 5); i++)
                {
                    GameObjects newRock = new GameObjects();
                    newRock.color = randomColor[randomGenerator.Next(0, 4)];
                    newRock.col = randomGenerator.Next(0, playFieldWidth);
                    newRock.row = 0;
                    newRock.sign = randomChar[randomGenerator.Next(0, 10)];
                    rocks.Add(newRock);
                }
                // Move Dwarf
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (pressedKey.Key == ConsoleKey.LeftArrow || pressedKey.Key == ConsoleKey.A)
                    {
                        if (dwarf.colOne - 1 > 0)
                        {
                            dwarf.colOne = dwarf.colOne - 1;
                            dwarf.colTwo = dwarf.colTwo - 1;
                            dwarf.colThree = dwarf.colThree - 1;
                        }
                    }
                    if (pressedKey.Key == ConsoleKey.RightArrow || pressedKey.Key == ConsoleKey.D)
                    {
                        if (dwarf.colThree + 1 < playFieldWidth)
                        {
                            dwarf.colOne = dwarf.colOne + 1;
                            dwarf.colTwo = dwarf.colTwo + 1;
                            dwarf.colThree = dwarf.colThree + 1;
                        }
                    }
                }

                // Move Rocks
                List<GameObjects> newList = new List<GameObjects>();
                for (int i = 0; i < rocks.Count; i++)
                {
                    GameObjects oldRock = rocks[i];
                    GameObjects newRock = new GameObjects();
                    newRock.col = oldRock.col;
                    newRock.row = oldRock.row + 1;
                    newRock.sign = oldRock.sign;
                    newRock.color = oldRock.color;
                    if (newRock.row == dwarf.row && (newRock.col == dwarf.colOne || newRock.col == dwarf.colTwo || newRock.col == dwarf.colThree)) // unit collision
                    {
                        hit = true;
                        lives -= 1;
                        if (lives <= 0)
                        {
                            PrintStringOnField(10, 9, "GAME OVER!", ConsoleColor.Red);
                            PrintStringOnField(6, 10, "Your score is: " + score, ConsoleColor.Red);
                            PrintStringOnField(5, 11, "Press [Enter] to exit", ConsoleColor.Red);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                    if (newRock.row < playFieldHeight)
                    {
                        newList.Add(newRock);
                    }
                    else          // scoring system
                    {
                        score += 10;
                    }
                }
                rocks = newList;
                
                // Clear the console
                Console.Clear();

                // ReDraw playfield

                if (hit)
                {
                    rocks.Clear();
                    if (score <= 50)
                    {
                        score = 0;
                    }
                    else
                    {
                        score -= 50;
                    }
                    
                    PrintOnField(dwarf.colOne, dwarf.row, 'X', ConsoleColor.Red);
                    PrintOnField(dwarf.colTwo, dwarf.row, 'X', ConsoleColor.Red);
                    PrintOnField(dwarf.colThree, dwarf.row, 'X', ConsoleColor.Red);
                }
                else
                {  
                    PrintDwarfOnField(dwarf.colOne, dwarf.colTwo, dwarf.colThree, dwarf.row, 
                        dwarf.signOne, dwarf.signTwo, dwarf.signThree, dwarf.color); // drawing the dwarf
                }

                foreach (GameObjects rock in rocks)
                {
                    PrintOnField(rock.col, rock.row, rock.sign, rock.color);
                }

                for (int i = 0; i < playFieldHeight; i++)  // playfield boundaries
                {
                    PrintOnField(playFieldWidth, i, '|', ConsoleColor.Gray);
                }

                

                // Print Score
                PrintStringOnField(40, 9, "Lives: " + lives, ConsoleColor.White);
                PrintStringOnField(40, 10, "Speed: " + speed, ConsoleColor.White);
                PrintStringOnField(40, 11, "Score: " + score, ConsoleColor.White);

                // Slow down the console
                Thread.Sleep(500 - (int)speed);
            }
        }
        if (yesOrNo.Key == ConsoleKey.N)
            return;
        else
        {
            Main();
        }
    }
}