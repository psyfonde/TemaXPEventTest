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
    public partial class Observer : Form
    {
        private MemberCtr memberCtr;

        public Observer(MemberCtr memberCtr)
        {
            this.memberCtr = memberCtr;
            InitializeComponent();
        }

        public void UpdateMemberName(object sender, MemberNameChangedArgs e)
        {
            lblName.Text = e.msg;
           // lblName.Refresh();
        }

        private void lblName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Observer_Load(object sender, EventArgs e)
        {

        }
    }
}
