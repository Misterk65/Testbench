namespace Testbench
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSvcState = new System.Windows.Forms.Button();
            this.btnSigStrength = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTestSvc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSvcState
            // 
            this.btnSvcState.Location = new System.Drawing.Point(12, 12);
            this.btnSvcState.Name = "btnSvcState";
            this.btnSvcState.Size = new System.Drawing.Size(208, 32);
            this.btnSvcState.TabIndex = 0;
            this.btnSvcState.Text = "button1";
            this.btnSvcState.UseVisualStyleBackColor = true;
            this.btnSvcState.Click += new System.EventHandler(this.btnSvcState_Click);
            // 
            // btnSigStrength
            // 
            this.btnSigStrength.Location = new System.Drawing.Point(12, 50);
            this.btnSigStrength.Name = "btnSigStrength";
            this.btnSigStrength.Size = new System.Drawing.Size(208, 33);
            this.btnSigStrength.TabIndex = 1;
            this.btnSigStrength.Text = "button2";
            this.btnSigStrength.UseVisualStyleBackColor = true;
            this.btnSigStrength.Click += new System.EventHandler(this.btnSigStrength_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(208, 52);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "button1";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTestSvc
            // 
            this.btnTestSvc.Location = new System.Drawing.Point(12, 89);
            this.btnTestSvc.Name = "btnTestSvc";
            this.btnTestSvc.Size = new System.Drawing.Size(208, 32);
            this.btnTestSvc.TabIndex = 3;
            this.btnTestSvc.Text = "button1";
            this.btnTestSvc.UseVisualStyleBackColor = true;
            this.btnTestSvc.Click += new System.EventHandler(this.btnTestSvc_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 253);
            this.ControlBox = false;
            this.Controls.Add(this.btnTestSvc);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSigStrength);
            this.Controls.Add(this.btnSvcState);
            this.MaximumSize = new System.Drawing.Size(250, 300);
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Name = "FrmMain";
            this.Text = "T-Bench";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSvcState;
        private System.Windows.Forms.Button btnSigStrength;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTestSvc;
    }
}

