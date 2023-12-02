using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
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
        string netim(string dogru, string yanlis)
        {

            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            int sonuc = 0; 
            if(dogru!=null && yanlis!=null)
            {
                 sonuc = Convert.ToInt16(dogru) - Convert.ToInt16(yanlis);
                return sonuc.ToString();
            }
            else
            {
                return sonuc.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTrNet.Text = netim(txtTrDogru.Text, txtTrYanlis.Text);
            txtMtNet.Text = netim(txtMtDogru.Text, txtMtYanlis.Text);
            txtFzNet.Text = netim(txtFzDogru.Text, txtFzYanlis.Text);
        }
    }
}
