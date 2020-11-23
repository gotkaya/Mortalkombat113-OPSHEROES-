using System;

namespace OPSuperHeroes
{
    class Program
    {
        class player
        {
            string name;
            int hp;

            public player(string _name)
            {
                name = _name;
                Random rnd = new Random();
                hp = rnd.Next(100, 151);
            }
            public void SayHello()
            {
                Console.WriteLine($"{name} says Hello!");
            }

            public void ShowYourHP()
            {
                Console.WriteLine($"{name}s Hp:{hp}");
            }

            public int MakeDamage()
            {
                Random rnd = new Random();
                return rnd.Next(10, 51);

            }

            public void TakeDamage(int damage)
            {
                if(hp <= 0)
                {
                    hp = 0;
                }else
                {
                    hp = hp - damage;

                }
            }

            public int HP
            {
                get { return hp; }
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Name your first character: ");
            string characterNameone = Console.ReadLine();
            Console.WriteLine("Name your second character: ");
            string characterNametwo = Console.ReadLine();

            player playerone = new player(characterNameone);
            player playertwo = new player(characterNametwo);
            playerone.SayHello();
            playerone.ShowYourHP();
            playertwo.SayHello();
            playertwo.ShowYourHP();

            for(int i = 0; i < 3; i++)
            {
                playerone.TakeDamage(playertwo.MakeDamage());
                playertwo.TakeDamage(playerone.MakeDamage());
                playerone.ShowYourHP();
                playertwo.ShowYourHP();
            }

            if(playerone.HP > playertwo.HP)
            {
                Console.WriteLine("Player One won!");
            }else if (playerone.HP > playertwo.HP)
            {
                Console.WriteLine("Player Two won!");
            }else
            {
                Console.WriteLine("Its a tie!");
            }

            Console.WriteLine($"Player one hit {playerone.MakeDamage()}");
          
        }
    }
}
