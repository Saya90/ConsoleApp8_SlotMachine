using System;
using System.Data;
using System.Reflection.Metadata;

namespace ConsoleApp8_SlotMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {


            const int CENTRAL_LINE = 1;
            const int HORIZONTAL_LINES = 2;
            const int VERTICAL_LINES = 3;
            const int DIAGONAL_LINES = 4;
            const int COST_ONE_LINE = 1;
            const int COST_HORIZONTAL_LINES = 3;
            const int COST_VERTICAL_LINES = 3;
            const int COST_DIAGONAL_LINES = 2;


            Console.WriteLine("Welcome to the slot Machine game! Choose from the following options in this 3X3 grid.");
            Console.WriteLine();
            Console.WriteLine("Choose 1 for playing only center line. (Cost = 1Euro )");
            Console.WriteLine("Choose 2 for all horizontal lines. (Cost per line = 1Euro )");
            Console.WriteLine("Choose 3 for all vertical lines. (Cost per line = 1Euro )");
            Console.WriteLine("Choose 4 for all diagonal lines.(Cost per line = 1Euro )");

            int mode = 0;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out mode))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }


                if (mode < 1 || mode > 4)
                {
                    Console.WriteLine("Invalid input. Please choose from 1 to 4");

                }

                else
                {
                    Console.WriteLine($"You chose {mode}");
                    break;
                }
            }

            Console.WriteLine($"Now please chose how much you want to bet! Minimum is 1 Euro. ");
            int betAmount = 0;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out betAmount))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (betAmount < 1)
                {
                    Console.WriteLine("Please choose minimum 1 Euro to start");
                }

                else

                {
                    Console.WriteLine($"You chose {betAmount} Euros");

                    break;

                }
            }

            int bet = 0;
            int totalWin = 0;



            //Console.WriteLine( { betAmount * }

            const int GRID_SIZE = 3;
            Random rng = new Random();
            int Randomnumber = rng.Next(1, 4);
            //int slotGrid = 1;
            // how to determin the center line 3 / 2 = 1.5-> 1
            int calculateCenterLine = 0;
            calculateCenterLine = (GRID_SIZE / 2);
            //Console.WriteLine($"{betAmount + 1 }");


            //Grid generation
            int[,] SlotMachineGrid = new int[GRID_SIZE, GRID_SIZE];

            for (int rowindex = 0; rowindex < GRID_SIZE; rowindex++)
            {

                for (int columnindex = 0; columnindex < GRID_SIZE; columnindex++)

                {
                    SlotMachineGrid[rowindex, columnindex] = 1; //rng.Next(1, 4);


                }

            }

            //GRID POPULATION
            for (int rowindex = 0; rowindex < GRID_SIZE; rowindex++)
            {

                for (int columnindex = 0; columnindex < GRID_SIZE; columnindex++)

                {
                    Console.Write(SlotMachineGrid[rowindex, columnindex]);
                    Console.Write('|');

                }
                Console.WriteLine();
            }


            bool win = true;
            if (mode == CENTRAL_LINE)
            {
                for (int i = 0; i < GRID_SIZE; i++)
                {
                    if (SlotMachineGrid[calculateCenterLine, 0] != SlotMachineGrid[calculateCenterLine, i])
                    {
                        win = false;
                        break;

                    }
                }
                if (win)
                {
                    Console.WriteLine("Wow, You win!");
                }

                else
                {
                    Console.WriteLine("Sorry you lose");
                }


            }
            else if (mode == HORIZONTAL_LINES)
            {

                for (int rowindex = 0; rowindex < GRID_SIZE; rowindex++)
                {


                    for (int columnindex = 0; columnindex < GRID_SIZE; columnindex++)

                    {
                        if (SlotMachineGrid[rowindex, 0] != SlotMachineGrid[rowindex, columnindex])
                        {

                            win = false;

                            break;

                        }
                    }


                    if (win)
                    {
                        Console.WriteLine("Wow, You won!");
                    }

                    else
                    {
                        Console.WriteLine("Sorry you lose");
                    }
                }
            }

            else if (mode == VERTICAL_LINES)
            {

                for (int columnindex = 0; columnindex < GRID_SIZE; columnindex++)
                {


                    for (int rowindex = 0; rowindex < GRID_SIZE; rowindex++)

                    {
                        if (SlotMachineGrid[columnindex, 0] != SlotMachineGrid[columnindex, rowindex])
                        {

                            win = false;

                            break;

                        }
                    }


                    if (win)
                    {
                        Console.WriteLine("Wow, You won!");
                    }

                    else
                    {
                        Console.WriteLine("Sorry you lose");
                    }

                }


            }
            else if (mode == DIAGONAL_LINES)
            {
                jkj;
            }

        }
    }
}


// if (SlotMachineGrid[calculateCenterLine, 0] == SlotMachineGrid[calculateCenterLine, 1] &&
//SlotMachineGrid[calculateCenterLine, 1] == SlotMachineGrid[calculateCenterLine, 2])
//  {
//Console.WriteLine("Win!");
//}

//Design a game where the user can play a make-believe slot machine. The user will be asked to make a wager to play
//various lines in a 3 x 3 grid. They can play center line, all three horizontal lines, all vertical lines and
//diagonals. For instance the user can enter $3 dollars and play all three horizontal lines. If the top line hits
//a winning combination, they earn $1 dollar for that line.

//Tips: The mention of a grid here should be a dead giveaway that you need a 2D array. You will also need
//functionality that can check a horizontal line, a vertical line and a diagonal. Depending on the number of
//lines they play, you may need to execute all three of these statements one or multiple times to look for winning
//lines. If they are playing three lines, you would call your horizontal line check function three times...
//one for the top row, one for the center row and one for the bottom row. Each of these row checking algorithms
//will then need to look for winning combinations. The result is then dumped into the player’s money total.
//As for the mechanism to determine what the wheels produce per spin, use a random number generating function.