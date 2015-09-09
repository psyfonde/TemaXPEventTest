using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsEventTest
{
    public class MemberNameChangedArgs : EventArgs
    {
        public readonly String msg;

        public MemberNameChangedArgs(string message)
        {
            msg = message;
        }
    }
}
