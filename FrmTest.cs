using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testbench
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void FrmTest_Load(object sender, EventArgs e)
        {
            btnStart.Text = "&close";
            
            if (id==1)
            {
                this.Text = "Evaluate Service State";
            }
            else if (id==2)
            {
                this.Text = "Evaluate Signal Strength";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CServiceState svcState =new CServiceState();

            try
            {
                if (btnStart.Text=="&Start")
                {
                    if (id == 1)
                    {
                        txtInput.Text = svcState.CreateServiceState(txtInput.Text);
                        btnStart.Text = "&Close";
                    }
                    else if (id == 2)
                    {
                        MessageBox.Show("Not yet implemented");
                    } 
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text != String.Empty)
            {
                string[] x = txtInput.Text.Split(':');
                
                if (x.Length==5)
                {
                    btnStart.Text = "&Start";    
                }
                else if(x.Length < 5)
                {
                    MessageBox.Show("The provided string has not the correct format!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInput.Text = string.Empty;
                }
                
            }
            else
            {
                btnStart.Text = "&Close";
            }
        }
    }
}
