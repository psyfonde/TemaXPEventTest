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
        private Notifier notifier;
        private Observer observer;

        public Main()
        {
            notifier = new Notifier(memberCtr);
            observer = new Observer(memberCtr);
            notifier.MemberNameChanged += observer.UpdateMemberName;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            memberCtr = new MemberCtr();

        }

        private void notifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //notifier = new Notifier(memberCtr);
            
            notifier.Show();
        }

        private void observerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //observer = new Observer(memberCtr);
            
            observer.Show();
        }
    }
}
