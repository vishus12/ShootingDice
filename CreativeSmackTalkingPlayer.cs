using System;
using System.Collections.Generic;


namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer: Player
    {
         public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Taunt();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }

        public void Taunt()
        {
            Random rnd= new Random();
            int rTaunt = rnd.Next(1, 6);

            switch(rTaunt)
            {
                case 1:
                Console.WriteLine("You suck!");
                break;
                case 2:
                Console.WriteLine("Youre Not Cool");
                break;
                case 3:
                Console.WriteLine("You are very not cool");
                break;
                case 4:
                Console.WriteLine("You are lame");
                break;
                case 5:
                Console.WriteLine("You are LOSER");
                break;
                case 6:
                Console.WriteLine("You are lameo");
                break;
            }
        }
    }
}