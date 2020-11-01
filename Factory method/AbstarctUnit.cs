using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_method
{
    abstract class AbstarctUnit
    {
        public abstract IUnit CreatUnit();

        public void AplloydAtack()
        {
            var unit = CreatUnit();
            unit.Attack();
        }

    }
}
