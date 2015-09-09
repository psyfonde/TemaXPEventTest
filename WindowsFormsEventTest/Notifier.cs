using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEventTest
{
    public partial class Notifier : Form
    {
        private MemberCtr memberCtr;

        public event EventHandler<MemberNameChangedArgs> MemberNameChanged;


        public Notifier(MemberCtr memberCtr)
        {
            this.memberCtr = memberCtr;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           

            //Observer obs = new Observer(memberCtr);
            
            //MemberNameChanged += obs.UpdateMemberName;

            Member m = new MemberCtr().CreateMember(txtName.Text);

            if (this.MemberNameChanged != null)
            {
                this.MemberNameChanged(this, new MemberNameChangedArgs(this.txtName.Text));
            }
           
           
            //obs.Show();
        }
    }
}
