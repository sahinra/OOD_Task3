using System;
using System.Collections.Generic;
using System.Text;
using Task3;

namespace OOD_Task3.Iterator
{
    class Iterator : AbstractIterator
    {
        private ConcreteCollection concreteCollection;

        public Iterator(ConcreteCollection concreteCollection)
        {
            this.concreteCollection = concreteCollection;
        }

        public OvercomplicatedDatabase FirstInComplicatedDb()
        {
            throw new NotImplementedException();
        }

        public ExcellDatabase FirstInExcelDb()
        {
            throw new NotImplementedException();
        }

        public SimpleGenomeDatabase FirstInSimpleDb()
        {
            throw new NotImplementedException();
        }

        public OvercomplicatedDatabase NextInComplicatedDb()
        {
            throw new NotImplementedException();
        }

        public bool isCompleted()
        {
            throw new NotImplementedException();
        }

        public ExcellDatabase NextInExcelDb()
        {
            throw new NotImplementedException();
        }

        public SimpleGenomeDatabase NextInSimpleDb()
        {
            throw new NotImplementedException();
        }
    }
}
