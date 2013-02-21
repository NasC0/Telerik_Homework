using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;

namespace FallingRocksGame
{
    public class ScreenElements
    {
        public int positionX { get; set; }
        public int positionY { get; set; }
        public char value { get; set; }
        public int color { get; set; }

        public ScreenElements()
        {
            this.color = 15;
        }
        public ScreenElements(int positionX, int positionY, char value, int color)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.value = value;
            this.color = color;
        }
        public void Show()
        {
            Console.SetCursorPosition(this.positionX, this.positionY);
            Console.ForegroundColor = (ConsoleColor)this.color;
            Console.Write(this.value);
        }
        public void ShowAt(int positionX, int positionY)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = (ConsoleColor)this.color;
            Console.Write(this.value);
        }
        public void ShowAtSymbol(int positionX, int positionY, char symbol)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = (ConsoleColor)this.color;
            Console.Write(symbol);
        }
        public void Hide()
        {
            Console.SetCursorPosition(this.positionX, this.positionY);
            Console.Write(' ');
        }
        public void MoveDown()
        {
            this.positionY += 1;
        }
        public void MoveUp()
        {
            this.positionY -= 1;
        }
        public void MoveLeft()
        {
            this.positionX -= 1;
        }
        public void MoveLeft(int fieldWidth)
        {
            this.positionX -= 1;
            if (positionX <= 0)
            {
                positionX = fieldWidth - 1;
            }
        }
        public void MoveRight()
        {
            this.positionX += 1;
        }
        public void MoveRight(int fieldWidth)
        {
            this.positionX += 1;
            if (positionX >= fieldWidth)
            {
                positionX = 1;
            }
        }
    }
    public class Frames : ScreenElements
    {
        private int startX;
        private int startY;
        private int endX;
        private int endY;

        public Frames() { }
        public Frames(int startX, int startY, int endX, int endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }
        public void Print(int startX, int startY, int endX, int endY)
        {
            this.value = '║';
            for (int i = startY; i < endY; i++)
            {
                this.ShowAt(startX, i);
                this.ShowAt(endX, i);
            }
            this.value = '═';
            for (int i = startX + 1; i < endX; i++)
            {
                this.ShowAt(i, startY);
                this.ShowAt(i, endY);
            }
            this.ShowAtSymbol(startX, startY, '╔');
            this.ShowAtSymbol(startX, endY, '╚');
            this.ShowAtSymbol(endX, startY, '╗');
            this.ShowAtSymbol(endX, endY, '╝');
            for (int i = startX + 1; i <= endX - 1; i++)
            {
                for (int j = startY + 1; j <= endY - 1; j++)
                {
                    this.ShowAtSymbol(i, j, ' ');
                }
            }
        }
        public void Print()
        {
            this.value = '║';
            for (int i = startY; i < endY; i++)
            {
                this.ShowAt(startX, i);
                this.ShowAt(endX, i);
            }
            this.value = '═';
            for (int i = startX + 1; i < endX; i++)
            {
                this.ShowAt(i, startY);
                this.ShowAt(i, endY);
            }
            this.ShowAtSymbol(startX, startY, '╔');
            this.ShowAtSymbol(startX, endY, '╚');
            this.ShowAtSymbol(endX, startY, '╗');
            this.ShowAtSymbol(endX, endY, '╝');
            for (int i = startX + 1; i <= endX - 1; i++)
            {
                for (int j = startY + 1; j <= endY - 1; j++)
                {
                    this.ShowAtSymbol(i, j, ' ');
                }
            }
        }
        public void Clear(int startX, int startY, int endX, int endY)
        {
            for (int i = startX; i <= endX; i++)
            {
                for (int j = startY; j <= endY; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(' ');
                }
            }
        }
    }
    class Dwarf : ScreenElements
    {
        private ScreenElements leftBracket;
        private ScreenElements rightBracket;
        private ScreenElements dwarf;
        private int dwarfLives;
        private int fieldWidth;

        public Dwarf(int fieldWidth, int fieldHeight)
        {
            leftBracket = new ScreenElements(fieldWidth / 2 - 1, fieldHeight - 2, '(', 15);
            dwarf = new ScreenElements(fieldWidth / 2, fieldHeight - 2, 'O', 15);
            rightBracket = new ScreenElements(fieldWidth / 2 + 1, fieldHeight - 2, ')', 15);
            leftBracket.Show();
            dwarf.Show();
            rightBracket.Show();
            this.fieldWidth = fieldWidth;
            this.dwarfLives = 3;
            this.ShowLives();
        }
        public new void MoveLeft()
        {
            if (leftBracket.positionX > 1)
            {
                leftBracket.MoveLeft();
                dwarf.MoveLeft();
                rightBracket.Hide();
                rightBracket.MoveLeft();
                leftBracket.Show();
                dwarf.Show();
                rightBracket.Show();
            }
        }
        public new void MoveRight()
        {
            if (rightBracket.positionX < fieldWidth - 1)
            {
                rightBracket.MoveRight();
                dwarf.MoveRight();
                leftBracket.Hide();
                leftBracket.MoveRight();
                rightBracket.Show();
                dwarf.Show();
                leftBracket.Show();
            }
        }
        public bool IncreaseLives()
        {
            if (dwarfLives < 6)
            {
                this.dwarfLives++;
                this.ShowLives();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DecreaseLives()
        {
            if (dwarfLives > 1)
            {
                this.dwarfLives--;
                this.ShowLives();
                return true;
            }
            else
            {
                FallingRocks.GameOver(); // needs to be redone properly
                return false;
            }
        }
        public int GetPositionX()
        {
            return dwarf.positionX;
        }
        public int GetPositionY()
        {
            return dwarf.positionY;
        }
        private void ShowLives()
        {
            Console.SetCursorPosition(1, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Lives: ");
            Console.Write("                        ");
            Console.SetCursorPosition(8, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < this.dwarfLives; i++)
            {
                Console.Write("(O) ");
            }
        }
    }
    class Bombs
    {
        private int count;

        public Bombs(string name, int position)
        {
            count = 3;
            Console.SetCursorPosition(position, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(name);
        }
        public int GetCount()
        {
            return count;
        }
        public void SetBombs(int number, int postion, int color)
        {
            count += number;
            if (count <= 3)
            {
                Console.SetCursorPosition(postion, 0);
                Console.Write("            ");
                Console.SetCursorPosition(postion, 0);
                Console.ForegroundColor = (ConsoleColor)color;
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write("(O) ");
                    }
                }
                else
                {
                    count = 0;
                    Console.Write("- ");
                }
            }
            else
            {
                count = 3;
            }
        }
    }
    class Menus : Frames
    {
        private int fieldWidth;
        private int fieldHeight;

        public Menus(int fieldWidth, int fieldHeight)
        {
            this.fieldWidth = fieldWidth;
            this.fieldHeight = fieldHeight;
        }
        public void Pause()
        {
            ConsoleKeyInfo readKey;
            int x = fieldWidth / 2;
            int y = fieldHeight / 2;
            lock (FallingRocks.syncObject)
            {
                this.Print(x - 20, y - 2, x + 20, y + 2);
                Console.SetCursorPosition(x - 18, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Game paused press \"P\" to continue...");
                do
                {
                    readKey = Console.ReadKey(true);
                } while (!(readKey.KeyChar == 'p' || readKey.KeyChar == 'P'));
                this.Clear(x - 20, y - 2, x + 20, y + 2);
            }
        }
        public void Help()
        {
            int x = fieldWidth / 2;
            int y = fieldHeight / 2;
            lock (FallingRocks.syncObject)
            {
                this.Print(x - 40, y - 10, x + 45, y + 10);
                WriteAt(x - 20, y - 9, " Welcome to \"Falling Rocks\" Game.", 15);
                WriteAt(x - 38, y - 5, " The goal of the game is to sustain on the field as long as possible.", 15);
                WriteAt(x - 38, y - 4, " Be aware of the falling rocks, they will harm you.", 15);
                WriteAt(x - 38, y - 3, " Also watch out for the special rocks they will give you bonuses.", 15);
                WriteAt(x - 38, y - 2, " Be aware though the green are friendly, but the red are evil.", 15);
                WriteAt(x - 38, y - 1, " If you see yourselve in dire situation use bombs, they will make space.", 15);
                WriteAt(x - 38, y - 0, " The special bombs are even better because they will reduce the speed.", 15);
                WriteAt(x - 38, y + 1, " Use the arrows <- and -> to move and avoid rocks.", 15);
                WriteAt(x - 38, y + 2, " Use \"B\" and \"C\" to release bombs and special bombs respectively.", 15);
                WriteAt(x - 38, y + 3, " Make as much points as possible.", 15);
                WriteAt(x - 38, y + 5, " Good luck and have fun.", 15);
                WriteAt(x - 20, y + 9, "Press any key to continue... ", 12);
                ConsoleKeyInfo readKey = Console.ReadKey(true);
                this.Clear(x - 40, y - 10, x + 45, y + 10);
            }
        }
        public void BottomToolbar()
        {
            Console.SetCursorPosition(1, fieldHeight);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("S");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Sound ON/OFF;");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" L");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Legend;");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" P");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Pause;");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" B");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Bomb;");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" C");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Special bomb;");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Esc");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Quit;");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" F1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Help;");
            Console.SetCursorPosition(fieldWidth - 25, fieldHeight);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("TELERIK ACADEMY 2012/2013");
        }
        public void SetTitle(string title)
        {
            string titleString = "";
            for (int i = 0; i < fieldWidth; i++)
            {
                titleString += " ";
            }
            Console.Title = titleString;
            Console.Title = Console.Title.Insert((Console.WindowWidth - 10), title);
        }
        public void Quit()
        {
            ConsoleKeyInfo readKey;
            int x = fieldWidth / 2;
            int y = fieldHeight / 2;
            lock (FallingRocks.syncObject)
            {
                this.Print(x - 22, y - 2, x + 22, y + 2);
                WriteAt(x - 20, y, "Do you really want to leave the game Y/N? ", 12);
                do
                {
                    readKey = Console.ReadKey(true);
                } while (!(readKey.KeyChar == 'y' || readKey.KeyChar == 'Y' || readKey.KeyChar == 'n' || readKey.KeyChar == 'N'));
                if (readKey.KeyChar == 'n' || readKey.KeyChar == 'N')
                {
                    this.Clear(x - 22, y - 2, x + 22, y + 2);
                }
                else
                {
                    FallingRocks.GameOver();
                }
            }
        }
        public void Legend()
        {
            int x = fieldWidth / 2;
            int y = fieldHeight / 2;
            lock (FallingRocks.syncObject)
            {
                this.Print(x - 42, y - 7, x + 42, y + 10);
                PrintLegendSymbols(10, "*", y - 5);
                PrintLegendText(15, "- Gives Life (max 6);", y - 5);
                PrintLegendSymbols(10, "%", y - 4);
                PrintLegendText(15, "- Reduces the speed of the falling rocks;", y - 4);
                PrintLegendSymbols(10, "#", y - 3);
                PrintLegendText(15, "- The bomb removes rocks from the screen activate (B);", y - 3);
                PrintLegendSymbols(10, "$", y - 2);
                PrintLegendText(15, "- The special bomb removes the rocks and reduces their speed activate (C);", y - 2);
                PrintLegendSymbols(10, "&", y - 1);
                PrintLegendText(15, "- Reduces density of the falling rocks;", y - 1);
                PrintLegendSymbols(10, "^", y);
                PrintLegendText(15, "- Gives bonus points;", y);
                PrintLegendSymbols(10, ".", y + 1);
                PrintLegendText(15, "- The player can shoot the rocks;", y + 1);
                PrintLegendSymbols(12, "!", y + 3);
                PrintLegendText(15, "- Increase the density of the rocks;", y + 3);
                PrintLegendSymbols(12, "+", y + 4);
                PrintLegendText(15, "- Increase the speed of the falling rocks;", y + 4);
                PrintLegendSymbols(12, "@", y + 5);
                PrintLegendText(15, "- Takes one's players lives;", y + 5);
                PrintLegendSymbols(12, ";", fieldHeight / 2 + 6);
                PrintLegendText(15, "- Instant kill - the player is killed instantly;", y + 6);
                PrintLegendText(15, "  Press any key to continue...", y + 9);
                ConsoleKeyInfo readKey = Console.ReadKey(true);
                this.Clear(x - 42, y - 7, x + 42, y + 10);
            }
        }
        private void PrintLegendSymbols(int color, string text, int height)
        {
            Console.SetCursorPosition(fieldWidth / 2 - 38, height);
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write(text);
        }
        private void PrintLegendText(int color, string text, int height)
        {
            Console.SetCursorPosition(fieldWidth / 2 - 35, height);
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write(text);
        }
        private void WriteAt(int x, int y, string text, int color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write(text);
        }
        public void Write(StreamWriter writer)
        {
            WriteFile(writer, "TOP 10 SCORE");
            WriteFile(writer, "1.  George Stoikov..........................   10000");
            WriteFile(writer, "2.  Vladimir Enchev.........................    5000");
            WriteFile(writer, "3.  Andrei Mladenov.........................    1000");
            WriteFile(writer, "4.  Nikolai Aleksiev........................     500");
            WriteFile(writer, "5.  ........................................        ");
            WriteFile(writer, "6.  ........................................        ");
            WriteFile(writer, "7.  ........................................        ");
            WriteFile(writer, "8.  ........................................        ");
            WriteFile(writer, "9.  ........................................        ");
            WriteFile(writer, "10. ........................................        ");
        }
        private void WriteFile(StreamWriter writer, string text)
        {
            writer.WriteLine(text);
            writer.WriteLine();
        }
    }
    class FallingRocks
    {
        public partial class NativeMethods
        {
            [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "BlockInput")]
            [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
            public static extern bool BlockInput([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool fBlockIt);
        }

        private static Thread rocksThread;
        private static bool runFlag = true;
        private static EventWaitHandle threadSignal = new AutoResetEvent(false);

        private static int fieldHeight = 50; // Play field height
        private static int fieldWidth = 130; // Play field width
        private static int rocksDensity = 50; // Symbols density [50...1] the higher the lower the density.
        private static int rocksSpeed = 999; // Rocks speed [999...0] the lower the higher the speed.
        private static int level = 1;

        private static List<ScreenElements> slowRocks = new List<ScreenElements>();
        private static List<ScreenElements> quickRocks = new List<ScreenElements>();
        private static List<ScreenElements> quickerRocks = new List<ScreenElements>();
        private static List<ScreenElements> bonusRocks = new List<ScreenElements>();
        //private static List<ScreenElements> firstLine = new List<ScreenElements>();
        private static Dwarf dwarf;
        public static object syncObject;

        private static StreamReader reader;
        private static StreamWriter writer;
        private static Frames frame;
        private static Menus menu;
        private static ConsoleKeyInfo readKey;
        private static bool soundFlag = true;
        private static bool westWind = false;
        private static bool eastWind = false;
        private static Bombs bombs;
        private static Bombs specialBombs;
        private static ScreenElements[] specialRocks = new ScreenElements[10];
        public static int scoreCounter = 0;
        private static int bullets = 0;
        private static bool shoot = false;
        private static ScreenElements bullet = new ScreenElements(0, 0, '|', 15);
        private static Random randomX = new Random();
        private static Random randomWind = new Random();
        private static Random randomSymbol = new Random();
        private static Random randomColor = new Random();
        /* ------------------------------------------------------------------------ Main Method ---------------------------------------------------------------------*/
        public static void Main()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(fieldWidth - 6, fieldHeight - 6);
            Console.SetBufferSize(fieldWidth - 6, fieldHeight - 6);

            syncObject = new object();
            menu = new Menus(fieldWidth, fieldHeight);
            menu.Help();
            SetLevel();
            bombs = new Bombs("Bombs: ", 34);
            bombs.SetBombs(0, 41, 6);
            specialBombs = new Bombs("Special Bombs: ", 54);
            specialBombs.SetBombs(0, 69, 14);

            frame = new Frames(0, 0, ' ', 15);

            frame.Print(0, 1, fieldWidth, fieldHeight - 1);
            menu = new Menus(fieldWidth, fieldHeight);

            menu.SetTitle("Falling Rocks Game");
            menu.BottomToolbar();
            InitSpecialRocks();
            dwarf = new Dwarf(fieldWidth, fieldHeight);
            SetBullets(10);

            rocksThread = new Thread(ManageRocks);
            rocksThread.Start();

            threadSignal.Set();
            SetWind();
            GetKey();
        }

        public static void SetCounter(int counter)
        {
            scoreCounter += counter;
            lock (syncObject)
            {
                Console.SetCursorPosition(fieldWidth - 13, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("SCORE: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0,6}", scoreCounter);
            }
        }

        /* ------------------------------------------------------------------------ Rocks Management ----------------------------------------------------------------*/
        public static void ManageRocks()
        {
            int count = 0;
            while (runFlag)
            {
                SetCounter(10);
                count++;
                if (shoot)
                {
                    bullet.Hide();
                    bullet.MoveUp();
                    if (bullet.positionY > 2)
                    {
                        bullet.Show();
                    }
                    else
                    {
                        bullet.positionX = 0;
                        bullet.positionY = 0;
                        shoot = false;
                    }
                }
                lock (syncObject)
                {
                    Console.SetCursorPosition(fieldWidth - 30, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("({0})", 10 - count);
                }

                if (count >= 10)
                {
                    GetSpecialRock();
                    rocksDensity--;
                    SetRocksSpeed(-30);
                    level++;
                    SetLevel();
                    SetWind();
                    count = 0;
                }
                ManageLists(bonusRocks);
                GetNewRocks(quickerRocks, 3);
                ManageLists(quickerRocks);
                Thread.Sleep(rocksSpeed / 5);
                ManageLists(bonusRocks);
                GetNewRocks(quickerRocks, 3);
                ManageLists(quickerRocks);
                Thread.Sleep(rocksSpeed / 5);
                ManageLists(bonusRocks);
                GetNewRocks(quickRocks, 2);
                ManageLists(quickRocks);
                GetNewRocks(slowRocks, 1);
                ManageLists(slowRocks);
                Thread.Sleep(rocksSpeed / 5);
                ManageLists(bonusRocks);
                GetNewRocks(quickerRocks, 3);
                ManageLists(quickerRocks);
                Thread.Sleep(rocksSpeed / 5);
                GetNewRocks(quickRocks, 2);
                ManageLists(quickRocks);
                if (soundFlag)
                {
                    //System.Media.SystemSounds.Asterisk.Play();
                    //System.Media.SystemSounds.Beep.Play();
                    //System.Media.SystemSounds.Exclamation.Play();
                    //System.Media.SystemSounds.Hand.Play();
                    //System.Media.SystemSounds.Question.Play();
                    Console.Beep(500, 10);
                }

                Thread.Sleep(rocksSpeed / 5);
            }
        }
        private static void ManageLists(List<ScreenElements> RocksList)
        {
            lock (syncObject)
            {
                foreach (ScreenElements rock in RocksList)
                {
                    rock.Hide();
                    rock.MoveDown();
                    if (westWind)
                    {
                        rock.MoveRight(fieldWidth);
                    }
                    if (eastWind)
                    {
                        rock.MoveLeft(fieldWidth);
                    }
                    if (rock.positionX == dwarf.GetPositionX() && rock.positionY == dwarf.GetPositionY())
                    {
                        Collision(rock);
                    }
                    if (rock.positionX == bullet.positionX && rock.positionY == bullet.positionY)
                    {
                        bullet.Hide();
                        bullet.positionX = 0;
                        bullet.positionY = 0;
                        shoot = false;
                        rock.Hide();
                        RocksList.Remove(rock);
                    }
                }
                RocksList.RemoveAll(Rocks => Rocks.positionY >= fieldHeight - 2);
                foreach (ScreenElements rock in RocksList)
                {
                    rock.Show();
                }
            }
        }
        private static void SetRocksSpeed(int speed)
        {
            if (rocksSpeed + speed < 0)
            {
                rocksSpeed = 0;
            }
            else
            {
                if (rocksSpeed + speed > 999)
                {
                    rocksSpeed = 999;
                }
                else
                {
                    rocksSpeed += speed;
                }
            }
        }
        private static void SetRocksDensity(int density)
        {
            if (rocksDensity + density < 0)
            {
                rocksDensity = 0;
            }
            else
            {
                if (rocksDensity + density > 50)
                {
                    rocksDensity = 50;
                }
                else
                {
                    rocksDensity += density;
                }
            }
        }
        private static void GetNewRocks(List<ScreenElements> RocksList, int density)
        {
            int rondomPositionX = 1;
            for (int i = 0; i < fieldWidth / (rocksDensity * density); i++)
            {
                rondomPositionX = randomX.Next(1, fieldWidth);
                while (RocksList.Any(Rocks => Rocks.positionX == rondomPositionX))
                {
                    rondomPositionX = randomX.Next(1, fieldWidth - 2);
                }
                lock (syncObject)
                {
                    RocksList.Add(new ScreenElements(rondomPositionX, 2, '@', randomColor.Next(1, 16)));
                }
            }
        }
        private static void InitSpecialRocks()
        {
            specialRocks[0] = new ScreenElements(1, 1, '*', 10); // Gives Life;
            specialRocks[1] = new ScreenElements(1, 1, '%', 10); // Reduce the speed of the falling rocks;
            specialRocks[2] = new ScreenElements(1, 1, '#', 10); // Bomb - removes rocks and bonuses alike from the screen;
            specialRocks[3] = new ScreenElements(1, 1, '$', 10); // Special bomb - removes only the rocks from the screen;
            specialRocks[4] = new ScreenElements(1, 1, '&', 10); // Reduce density of the falling rocks;
            specialRocks[5] = new ScreenElements(1, 1, '^', 10); // Gives bonus points;
            specialRocks[6] = new ScreenElements(1, 1, '.', 10); // The player can shoot the rocks;
            specialRocks[7] = new ScreenElements(1, 1, '!', 12); // Increase the density of the rocks;
            specialRocks[8] = new ScreenElements(1, 1, '+', 12); // Increase the speed of the falling rocks;
            specialRocks[9] = new ScreenElements(1, 1, ';', 12);  // Instant kill - the player is killed instantly;
        }
        private static void GetSpecialRock()
        {
            int rondomPositionX = 0;
            rondomPositionX = randomX.Next(1, fieldWidth);
            int randSymbol = randomSymbol.Next(0, 10);
            bonusRocks.Add(new ScreenElements(rondomPositionX, 2, specialRocks[randSymbol].value, specialRocks[randSymbol].color));
        }
        /* ---------------------------------------------------------------- Keyboard Input Management ----------------------------------------------------------- */
        private static void GetKey()
        {
            while (runFlag)
            {
                readKey = Console.ReadKey(true);
                switch (readKey.KeyChar)
                {
                    case 'p':
                    case 'P':
                        menu.Pause(); break;
                    case 's':
                    case 'S':
                        SoundControl(); break;
                    case 'l':
                    case 'L':
                        menu.Legend(); break;

                    default:
                        break;
                }
                if (readKey.Key == ConsoleKey.Escape)
                {
                    menu.Quit();
                }
                if (readKey.Key == ConsoleKey.F1)
                {
                    menu.Help();
                }
                if (readKey.Key == ConsoleKey.B)
                {
                    if (bombs.GetCount() > 0)
                    {
                        Explode(1, 41, 6);
                    }
                }
                if (readKey.Key == ConsoleKey.C)
                {
                    if (specialBombs.GetCount() > 0)
                    {
                        Explode(2, 69, 14);
                    }
                }
                if (readKey.Key == ConsoleKey.LeftArrow)
                {
                    lock (syncObject)
                    {
                        dwarf.MoveLeft();
                    }
                }
                if (readKey.Key == ConsoleKey.RightArrow)
                {
                    lock (syncObject)
                    {
                        dwarf.MoveRight();
                    }
                }
                if (readKey.Key == ConsoleKey.Spacebar)
                {
                    if (bullets > 0)
                    {
                        bullet.positionX = dwarf.GetPositionX();
                        bullet.positionY = dwarf.GetPositionY() - 1;
                        bullet.Show();
                        SetBullets(-1);
                        shoot = true;
                    }
                }
            }
        }

        private static void SoundControl()
        {
            if (soundFlag)
            {
                soundFlag = false;
            }
            else
            {
                soundFlag = true;
            }
        }

        private static void Collision(ScreenElements rock)
        {
            switch (rock.value)
            {
                case '*': dwarf.IncreaseLives(); break;
                case '#': bombs.SetBombs(1, 41, 6); break;
                case '@': dwarf.DecreaseLives(); break;
                case '%': SetRocksSpeed(100); break;
                case '$': specialBombs.SetBombs(1, 69, 15); break;
                case '+': SetRocksSpeed(-100); break;
                case '&': SetRocksDensity(-3); break;
                case '!': SetRocksDensity(3); break;
                case ';': GameOver(); break;
                case '^': SetCounter(100); break;
                case '.': SetBullets(10); break;

                default: break;
            }
        }

        private static void SetBullets(int newBullets)
        {
            bullets += newBullets;
            if (bullets > 99)
            {
                bullets = 99;
            }
            if (bullets < 0)
            {
                bullets = 0;
            }
            lock (syncObject)
            {
                Console.SetCursorPosition(82, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Bullets: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0,2}", bullets);
            }
        }

        private static void Shoot()
        {
            shoot = true;
        }

        private static void Explode(int bombType, int position, int color)
        {
            System.Media.SystemSounds.Beep.Play();
            lock (syncObject)
            {
                foreach (ScreenElements rock in slowRocks)
                {
                    rock.Hide();
                }
                slowRocks.Clear();
                foreach (ScreenElements rock in quickRocks)
                {
                    rock.Hide();
                }
                quickRocks.Clear();
                foreach (ScreenElements rock in quickerRocks)
                {
                    rock.Hide();
                }
                quickerRocks.Clear();
                if (bombType == 1)
                {
                    bombs.SetBombs(-1, position, color);
                }
                else
                {
                    specialBombs.SetBombs(-1, position, color);
                    rocksSpeed += 100;
                    rocksDensity += 10;
                }
            }
        }

        private static void SetLevel()
        {
            Console.SetCursorPosition(fieldWidth - 23, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("LEVEL: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0,2}", level);
        }

        private static void SetWind()
        {
            int wind = randomWind.Next(1, 4);
            lock (syncObject)
            {
                Console.SetCursorPosition(fieldWidth - 27, 0);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("(");
                if (wind == 1)
                {
                    westWind = false;
                    eastWind = false;
                    Console.Write("-");
                }
                if (wind == 2)
                {
                    westWind = true;
                    eastWind = false;
                    Console.Write("W");
                }
                if (wind == 3)
                {
                    westWind = false;
                    eastWind = true;
                    Console.Write("E");
                }
                Console.Write(")");
            }
        }

        protected internal static void GameOver() // to be finished
        {
            runFlag = false;
            int height = -11;
            Console.Clear();
            Console.Beep(1000, 1000);
            Console.ForegroundColor = ConsoleColor.Red;
            // Console.WriteLine("Your final score is: {0}", scoreCounter);

            try
            {
                reader = new StreamReader("HighScore.txt");
            }
            catch (FileNotFoundException)
            {
                writer = new StreamWriter("HighScore.txt");
                using (writer)
                {
                    menu.Write(writer);
                }
                reader = new StreamReader("HighScore.txt");
            }
            string line = reader.ReadLine();
            Console.SetCursorPosition(fieldWidth / 2 - 6, fieldHeight / 2 + height);
            while (line != null)
            {
                Console.Write(line);
                height++;
                Console.SetCursorPosition(fieldWidth / 2 - 26, fieldHeight / 2 + height);
                line = reader.ReadLine();
            }
            reader.Close();

            rocksThread.Join();
        }
    }
}