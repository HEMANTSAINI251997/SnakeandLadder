using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    public class SnakeandLadder
    {
        int position = 0;
        public void Checksnakeandladder()
        {
            Console.WriteLine("Start Position = " + position);
            Random random = new Random();   
            int num = random.Next(1,7);
            Console.WriteLine("Player roll the dice and get the number = " + num);
            int option = random.Next(0,3);
            if (option == 0)
            {
                Console.WriteLine("They are NO Play, Postion = " + position);
                
            }
            else if (option == 1)
            {
                position = position + num;
                Console.WriteLine("LADDER - Position Add By = " + position );
            }
            else
            {
                position=position - num;
                Console.WriteLine("SNAKE - Position Down By = " + position);
            }
        }
    }
}
