using System;

namespace Factory_method
{
    internal class Archer : IUnit
    {
        public void Attack()
        {
            Console.WriteLine("Attack bow");
        }
    }
}