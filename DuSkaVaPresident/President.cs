using System;

namespace DuSkaVaPresident
{
    public class President
    {
        public string name;
        private int environmentPriority;
        private int defensePriority;
        private int healthcarePriority;
        private int corruption;
        private int money;

        public President(string n)
        {
            Random generator = new Random();

            // int[] priorityArray = 
            // {
                
            // };

            // environmentPriority = generator.Next(0, 100);
            // defensePriority = generator.Next(0, 100);
            // healthcarePriority = generator.Next(0, 100);

            n = Console.ReadLine();
            this.name = n;

        }

        public void Present()
        {
            System.Console.WriteLine("Name: " + this.name);

        }

        public bool PassLegislation(int e, int d, int h, int bribe)
        {

            bool result = true;

            return result;    
        }
    }
}
