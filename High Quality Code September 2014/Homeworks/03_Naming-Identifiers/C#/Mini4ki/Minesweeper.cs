using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Minesweeper
    {
        public class Ranking
        {
            private string name;

            private int points;

            public string Player
            {
                get
                {
                    return this.name;
                }

                set
                {
                    this.name = value;
                }
            }

            public int Points
            {
                get
                {
                    return this.points;
                }

                set
                {
                    this.points = value;
                }
            }

            public Ranking()
            { 
            }

            public Ranking(string name, int points)
            {
                this.Player = name;
                this.Points = points;
            }
        }

        private static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] field = CreatePlayingField();
            char[,] bombs = AddBombs();
            int counter = 0;
            bool isBoom = false;
            List<Ranking> winners = new List<Ranking>(6);
            int row = 0;
            int coll = 0;
            bool flag = true;
            const int max = 35;
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine(
                        "Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki."
                        + " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    dumpp(field);
                    flag = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out coll)
                        && row <= field.GetLength(0) && coll <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ShowRank(winners);
                        break;
                    case "restart":
                        field = CreatePlayingField();
                        bombs = AddBombs();
                        dumpp(field);
                        isBoom = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, coll] != '*')
                        {
                            if (bombs[row, coll] == '-')
                            {
                                Move(field, bombs, row, coll);
                                counter++;
                            }

                            if (max == counter)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                dumpp(field);
                            }
                        }
                        else
                        {
                            isBoom = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (isBoom)
                {
                    dumpp(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", counter);
                    string nickname = Console.ReadLine();
                    Ranking t = new Ranking(nickname, counter);
                    if (winners.Count < 5)
                    {
                        winners.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < winners.Count; i++)
                        {
                            if (winners[i].Points < t.Points)
                            {
                                winners.Insert(i, t);
                                winners.RemoveAt(winners.Count - 1);
                                break;
                            }
                        }
                    }

                    winners.Sort((Ranking r1, Ranking r2) => r2.Player.CompareTo(r1.Player));
                    winners.Sort((Ranking r1, Ranking r2) => r2.Points.CompareTo(r1.Points));
                    ShowRank(winners);

                    field = CreatePlayingField();
                    bombs = AddBombs();
                    counter = 0;
                    isBoom = false;
                    flag = true;
                }

                if (flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    dumpp(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string name = Console.ReadLine();
                    Ranking score = new Ranking(name, counter);
                    winners.Add(score);
                    ShowRank(winners);
                    field = CreatePlayingField();
                    bombs = AddBombs();
                    counter = 0;
                    flag2 = false;
                    flag = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void ShowRank(List<Ranking> points)
        {
            Console.WriteLine("\nTo4KI:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].Player, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void Move(char[,] field, char[,] bombs, int row, int coll)
        {
            char bombsCount = CalculateBombs(bombs, row, coll);
            bombs[row, coll] = bombsCount;
            field[row, coll] = bombsCount;
        }

        private static void dumpp(char[,] board)
        {
            int row = board.GetLength(0);
            int coll = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < coll; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] AddBombs()
        {
            int rows = 5;
            int colls = 10;
            char[,] playingField = new char[rows, colls];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    playingField[i, j] = '-';
                }
            }

            List<int> row3 = new List<int>();
            while (row3.Count < 15)
            {
                Random random = new Random();
                int nextRandom = random.Next(50);
                if (!row3.Contains(nextRandom))
                {
                    row3.Add(nextRandom);
                }
            }

            foreach (int cell in row3)
            {
                int coll = cell / colls;
                int row = cell % colls;
                if (row == 0 && cell != 0)
                {
                    coll--;
                    row = colls;
                }
                else
                {
                    row++;
                }

                playingField[coll, row - 1] = '*';
            }

            return playingField;
        }

        private static void Scores(char[,] field)
        {
            int coll = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < coll; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char bombsCount = CalculateBombs(field, i, j);
                        field[i, j] = bombsCount;
                    }
                }
            }
        }

        private static char CalculateBombs(char[,] r, int rr, int rrr)
        {
            int count = 0;
            int rows = r.GetLength(0);
            int colls = r.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (r[rr - 1, rrr] == '*')
                {
                    count++;
                }
            }

            if (rr + 1 < rows)
            {
                if (r[rr + 1, rrr] == '*')
                {
                    count++;
                }
            }

            if (rrr - 1 >= 0)
            {
                if (r[rr, rrr - 1] == '*')
                {
                    count++;
                }
            }

            if (rrr + 1 < colls)
            {
                if (r[rr, rrr + 1] == '*')
                {
                    count++;
                }
            }

            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (r[rr - 1, rrr - 1] == '*')
                {
                    count++;
                }
            }

            if ((rr - 1 >= 0) && (rrr + 1 < colls))
            {
                if (r[rr - 1, rrr + 1] == '*')
                {
                    count++;
                }
            }

            if ((rr + 1 < rows) && (rrr - 1 >= 0))
            {
                if (r[rr + 1, rrr - 1] == '*')
                {
                    count++;
                }
            }

            if ((rr + 1 < rows) && (rrr + 1 < colls))
            {
                if (r[rr + 1, rrr + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}