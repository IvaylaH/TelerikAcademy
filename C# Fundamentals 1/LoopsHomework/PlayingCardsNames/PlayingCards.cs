/*Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.*/

using System;

    class PlayingCards
    {
        static void Main()
        {
            char spade = '\u2660';
            char club = '\u2663';
            char heart = '\u2665';
            char diamond = '\u2666';
            string playingCard = null;
            char[] symbols = new char[4] {club, diamond, heart, spade};
            char symbol;

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine();

            for (int i = 0; i <= 3; i++)
            {
                symbol = symbols[i];

                if ((symbol == club) || (symbol == spade))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                for (int j = 2; j <= 13; j++)
                {
                    switch (j)
                    {
                        case 2: playingCard = "2"; break;
                        case 3: playingCard = "3"; break;
                        case 4: playingCard = "4"; break;
                        case 5: playingCard = "5"; break;
                        case 6: playingCard = "6"; break;
                        case 7: playingCard = "7"; break;
                        case 8: playingCard = "8"; break;
                        case 9: playingCard = "9"; break;
                        case 10: playingCard = "J"; break;
                        case 11: playingCard = "D"; break;
                        case 12: playingCard = "K"; break;
                        case 13: playingCard = "A"; break;
                        default: break;
                    }
                    Console.Write(playingCard + (char)symbol + " ");
                }
                Console.WriteLine();
            }
        }
    }