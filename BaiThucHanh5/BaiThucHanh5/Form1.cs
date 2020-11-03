using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        int n1, n2, n3, n4;
        public class Utilities
        {
            public static void ResetAllControls(Control form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.Text = null;
                    }

                    if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.Items.Count > 0)
                            comboBox.SelectedIndex = 0;
                    }

                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        checkBox.Checked = false;
                    }

                    if (control is ListBox)
                    {
                        ListBox listBox = (ListBox)control;
                        listBox.ClearSelected();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CSM_TextChanged(object sender, EventArgs e)
        {

        }

        private void CSC_TextChanged(object sender, EventArgs e)
        {

        }

        private void DN_TextChanged(object sender, EventArgs e)
        {

        }

        private void VAT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }

        float n5;
        private void button1_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(CSC.Text);
            n2 = Convert.ToInt32(CSM.Text);
            n3 = n2 - n1;
            DN.Text = n3.ToString();
            if (n3 <= 100 && n3 > 0)
            {
                n4 = n3 * 1418;
            }
            else if (n3 <= 150)
            {
                n4 = n3 * 1622;
            }
            else if (n3 <= 200)
            {
                n4 = n3 * 2044;
            }
            else if (n3 <= 300)
            {
                n4 = n3 * 2210;
            }
            else if (n3 <= 400)
            {
                n4 = n3 * 2361;

            }
            else if (n3 >= 401)
            {
                n4 = n3 * 2420;
            }
            TT.Text = n4.ToString();
            n5 = (n4 * 110)/100;
            VAT.Text = n5.ToString();
        }
    }
}
