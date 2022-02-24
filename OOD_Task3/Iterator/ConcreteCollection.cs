using System;
using System.Collections.Generic;
using System.Text;

namespace OOD_Task3.Iterator
{
    class ConcreteCollection : AbstractCollection
    {
        public Iterator IterateOverDatabases()
        {
            return new Iterator(this);
        }

        public void GetElemInDb()
        {
            
        }
    }
}
