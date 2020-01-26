using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class Developer: Employee
    {
        protected void numberProtected()
        { 
        }
        protected internal void numberProtectedInternal()
        {

        }
        private protected void numberPrivateProtected()
        { 

        }


    }
}
