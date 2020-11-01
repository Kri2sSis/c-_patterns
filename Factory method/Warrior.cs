using System;

namespace Factory_method
{
    internal class Warrior : IUnit
    {
        public void Attack()
        {
            Console.Write("Attack sword");
        }
    }
}