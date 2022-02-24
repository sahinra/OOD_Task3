using System;
using System.Collections.Generic;
using System.Text;


namespace OOD_Task3.Iterator
{
    using Task3;
    interface AbstractIterator
    {
        public ExcellDatabase FirstInExcelDb();
        public OvercomplicatedDatabase FirstInComplicatedDb();
        public SimpleGenomeDatabase FirstInSimpleDb();
        public ExcellDatabase NextInExcelDb();
        public OvercomplicatedDatabase NextInComplicatedDb();
        public SimpleGenomeDatabase NextInSimpleDb();
        public bool isCompleted();

    }
}

// A Comment..
// Actually, I was thinking iteartor pattern here but I couldn't decide which type I should use for First() and Next(),
//since there are 3 types of databases, also we aren't allowed to modify their content otherwise I could define an interface 
//for them. Then, I thought that maybe I can use the idea of visitor pattern as well to behave for each database specially
//but the problem is about their type. So, I couldn't understand what to do exactly.
// As for the filtering part, we would use iterator to find the objects which provides the dedicated criteria.