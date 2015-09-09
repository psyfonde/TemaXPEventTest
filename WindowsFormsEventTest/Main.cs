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
    public partial class Main : Form
    {
        private MemberCtr memberCtr;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            memberCtr = new MemberCtr();
        }

        private void notifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notifier notifier = new Notifier(memberCtr);
            notifier.Show();
        }

        private void observerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Observer observer = new Observer(memberCtr);
            observer.Show();
        }
    }
}
