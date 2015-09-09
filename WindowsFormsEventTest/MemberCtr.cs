using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsEventTest
{
    public class MemberCtr
    {
        public event EventHandler<MemberNameChangedArgs> MemberNameChanged;

        public Member CreateMember(string name)
        {
            
            //Observer obs = new Observer();
            //this.MemberNameChanged += obs.UpdateMemberName;

            if (MemberNameChanged != null)
            {
                this.MemberNameChanged(this, new MemberNameChangedArgs(name));
            }
            return new Member() { Name = name };
        }
    }
}
