using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FNvlclasse : Form
    {
        public FNvlclasse()
        {
            InitializeComponent();


            string[] Dir = Directory.GetDirectories(@"C:\USers\vmoise\");

            for (int i = 1; i < Dir.Length; i++)
            {
                cBR.Items.Add(Dir[i]);
               

            }
        }

        private void cBR_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] F = Directory.GetFiles(cBR.SelectedItem.ToString());

            int count = clb.Items.Count;
            if(count > 0)
            {
                
                clb.Items.Clear();
                
            }

            for (int i = 0; i < F.Length; i++)
            {
                string message = System.IO.Path.GetFileName(F[i]);
                clb.Items.Add(message);
            }

        
        }

       
    }
}
