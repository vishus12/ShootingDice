using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
        Console.WriteLine("Enter a number between 1 and 6");
        string answer = Console.ReadLine();

        int numAnswer;
        bool isNumber = int.TryParse(answer, out numAnswer);
        if ( isNumber && numAnswer > 0 && numAnswer < 7)

        {
            return numAnswer;
        }
        else 
        {
            Console.WriteLine("Enter a number between 1 and 6");
            return Roll();


        }   
    }
    } 

}