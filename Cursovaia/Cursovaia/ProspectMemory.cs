using System;
using System.Collections.Generic;
using System.Text;



namespace Cursovaia
{
    class ProspectMemory
    {
        public Stack<Memento> History { get; private set; }

        public ProspectMemory() 
        {
            History = new Stack<Memento>();
        }
    }
}
