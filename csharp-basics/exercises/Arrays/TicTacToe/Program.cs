using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] _board = new char[3, 3];
        private static char pirmaisSpeletajs = 'x';
        private static char otraisSpeletajs = 'o';


        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
            bool speleBeigusies = false;
            ielikZimi(ref speleBeigusies);
            Console.ReadKey();
        }

        private static void parbaude(ref bool speleBeigusies)
        {
            for (int i = 0; i < 3; i++)
            {

                if (_board[i, 0] != ' ' && _board[i, 0] == _board[i, 1] && _board[i, 0] == _board[i, 2])
                {
                    Console.WriteLine($"{_board[i, 0]} ir uzvarējis!");
                    speleBeigusies = true;
                    return;
                }

                if (_board[0, i] != ' ' && _board[0, i] == _board[1, i] && _board[0, i] == _board[2, i])
                {
                    Console.WriteLine($"{_board[0, i]} ir uzvarējis!");
                    speleBeigusies = true;
                    return;
                }
            }

            if (_board[0, 0] != ' ' && _board[0, 0] == _board[1, 1] && _board[0, 0] == _board[2, 2])
            {
                Console.WriteLine($"{_board[0, 0]} ir uzvarējis!");
                speleBeigusies = true;
                return;
            }

            if (_board[0, 2] != ' ' && _board[0, 2] == _board[1, 1] && _board[0, 2] == _board[2, 0])
            {
                Console.WriteLine($"{_board[0, 2]} ir uzvarējis!");
                speleBeigusies = true;
                return;
            }
        }


        private static void ielikZimi(ref bool speleBeigusies)
        {
            int veiksmigiGajieni = 0;

            while (veiksmigiGajieni < 9 && !speleBeigusies)
            {
                char aktīvaisSpeletajs = veiksmigiGajieni % 2 == 0 ? pirmaisSpeletajs : otraisSpeletajs;

                Console.WriteLine($"Spēlētājs {aktīvaisSpeletajs}  ievadiet, lūdzu, rindiņu (0-2 ) : ");
                int rindasNr = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Spēlētājs {aktīvaisSpeletajs} ievadiet, lūdzu, kolonu (0-2 ) : ");
                int kolonasNr = Convert.ToInt32(Console.ReadLine());

                if (_board[rindasNr, kolonasNr] == ' ')
                {
                    _board[rindasNr, kolonasNr] = aktīvaisSpeletajs;
                    DisplayBoard();
                    veiksmigiGajieni++;
                    parbaude(ref speleBeigusies);
                }
                else
                {
                    Console.WriteLine("Šis laukums ir jau aizņemts. Lūdzu, izvēlies citu laukumu.");
                }

            }
            if (veiksmigiGajieni == 9 && !speleBeigusies)
            {
                Console.WriteLine("Spēle ir neizšķirta.");
            }
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    _board[r, c] = ' ';
            }

        }

        private static void DisplayBoard()
        {
            Console.WriteLine("    0  1  2 ");
            Console.WriteLine("  0  " + _board[0, 0] + "|" + _board[0, 1] + "|" + _board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + _board[1, 0] + "|" + _board[1, 1] + "|" + _board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + _board[2, 0] + "|" + _board[2, 1] + "|" + _board[2, 2]);
            Console.WriteLine("    --+-+--");

        }


    }
} 
