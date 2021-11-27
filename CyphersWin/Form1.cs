using Ciphers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CyphersWin.Error;

namespace CyphersWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
     

        private void buttonAction_Click(object sender, EventArgs e)
        {
            int result = isAllDataGood();
            if (!result.Equals(1))
            {
                MessageBox.Show(Error.GetEnumDescription((Status)result));
            }
            else
            {
                if (radioButtonCeasar.Checked==true)
                {
                    if (radioButtonChiper.Checked==true)
                    {
                        textBoxTextNew.Text = Ceasar.Encipher(textBoxText.Text, int.Parse(textBoxShift.Text));
                    }
                    else
                    {
                        textBoxTextNew.Text = Ceasar.Decipher(textBoxText.Text, int.Parse(textBoxShift.Text));
                    }
                }
                else
                {
                    if (radioButtonChiper.Checked == true)
                    {
                        textBoxTextNew.Text = Playfair.Encipher(textBoxText.Text, textBoxKey.Text);
                    }
                    else
                    {
                    textBoxTextNew.Text = Playfair.Decipher(textBoxText.Text, textBoxKey.Text);
                }
                }

            }
        }

        private void radioButtonCeasar_CheckedChanged(object sender, EventArgs e)
        {
            textBoxShift.Enabled = true;
            textBoxKey.Enabled = false;
            trackBarShift.Enabled = true;
        }

        private void radioButtonPlayfair_CheckedChanged(object sender, EventArgs e)
        {

                textBoxShift.Enabled = false;
                textBoxKey.Enabled = true;
                trackBarShift.Enabled = false;
       
        }

        private void trackBarShift_Scroll(object sender, EventArgs e)
        {
            textBoxShift.Text = trackBarShift.Value.ToString();
        }
        private int isAllDataGood() {
            if (textBoxText.Text.Length.Equals(0))
            {
                return -1;
            }
            if (textBoxKey.Text.Length.Equals(0) && radioButtonPlayfair.Checked==true)
            {
                return -2;
            }
            if (textBoxShift.Text.Equals("0") && radioButtonCeasar.Checked==true)
            {
                return -3;
            }
            if( !areChractersUnique(textBoxKey.Text))
            {
                return -4;
            }
            return 1;

        }
    }
}
