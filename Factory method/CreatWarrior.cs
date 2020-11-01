using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_method
{
    class CreatWarrior : AbstarctUnit
    {
        public override IUnit CreatUnit()
        {
            return new Warrior();
        }
    }
}
