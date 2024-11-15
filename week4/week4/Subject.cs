using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    internal interface Subject
    {
        void registerObserver() {}

        void removeObserver() {}

        void notifyObservers() {}
    }
}
