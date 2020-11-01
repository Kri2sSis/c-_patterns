using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_method
{
    class CreatArcher : AbstarctUnit
    {
        public override IUnit CreatUnit()
        {
            return new Archer();
        }
    }
}
