
using System;

class Program {
    public static void Main(string[] args) {
        int num;
        bool validinput;

        do { Console.Write("Enter the number of rows: ");
             string input = Console.ReadLine();

             validinput = int.TryParse(input, out num) && num >= 0;

            if(!validinput) {
                Console.Write("Invalid Input, Input a non-negative Integer:  ");
            } 

            else if (num == 0) {
                Environment.Exit(0);
            }
            else {
             for (int i = 1; i <= num; i++) {
                    for (int j = 1; j <= num - i; j++) {
                    Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++) {
                        Console.Write("*");
                        if (j < i) {
                            Console.Write("*");
                        }
                    }

                    Console.WriteLine();
                }
            }

    } while (!validinput || num != 0);
}
}