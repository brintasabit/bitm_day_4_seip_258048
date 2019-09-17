using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_4_seip_class
{
    public partial class ListHome : Form
    {
        List<string> names = new List<string> { };
        public ListHome()
        {
            InitializeComponent();
        }

        private void NameShow()
        {
            names.Add(addTextBox.Text);
            string show = "";
            

            foreach (string name in names)
            {
                show += "Name: " + name + "\n";
            }
            MessageBox.Show(show);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
           /* names.Add(addTextBox.Text);
            string show="";
            for (int i = 0; i < name.Count; i++)
            {
                show += "Name: " + name[i] + "\n";
            }


           foreach (string name in names)
           {
               show += "Name: " + name+ "\n";
            }
            MessageBox.Show(show);
            */
            NameShow();




        }

        

        private void add2Button_Click(object sender, EventArgs e)
        {
            NameShow();
        }
    }
}
