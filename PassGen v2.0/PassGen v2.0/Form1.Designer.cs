namespace PassGen_v2._0
{
    partial class rootPanel
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
            this.webApp = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.webApptxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.genPassBtn = new System.Windows.Forms.Button();
            this.viewPassBtn = new System.Windows.Forms.Button();
            this.passLength = new System.Windows.Forms.TrackBar();
            this.PL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passLength)).BeginInit();
            this.SuspendLayout();
            // 
            // webApp
            // 
            this.webApp.AutoSize = true;
            this.webApp.Location = new System.Drawing.Point(12, 9);
            this.webApp.Name = "webApp";
            this.webApp.Size = new System.Drawing.Size(149, 17);
            this.webApp.TabIndex = 0;
            this.webApp.Text = "Website or Application";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(12, 50);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(69, 17);
            this.pass.TabIndex = 1;
            this.pass.Text = "Password";
            // 
            // webApptxt
            // 
            this.webApptxt.Location = new System.Drawing.Point(167, 12);
            this.webApptxt.Name = "webApptxt";
            this.webApptxt.Size = new System.Drawing.Size(138, 22);
            this.webApptxt.TabIndex = 2;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(167, 50);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(138, 22);
            this.passtxt.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(361, 140);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 47);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // genPassBtn
            // 
            this.genPassBtn.Location = new System.Drawing.Point(247, 140);
            this.genPassBtn.Name = "genPassBtn";
            this.genPassBtn.Size = new System.Drawing.Size(108, 47);
            this.genPassBtn.TabIndex = 5;
            this.genPassBtn.Text = "Generate Password";
            this.genPassBtn.UseVisualStyleBackColor = true;
            this.genPassBtn.Click += new System.EventHandler(this.genPassBtn_Click);
            // 
            // viewPassBtn
            // 
            this.viewPassBtn.Location = new System.Drawing.Point(133, 140);
            this.viewPassBtn.Name = "viewPassBtn";
            this.viewPassBtn.Size = new System.Drawing.Size(108, 47);
            this.viewPassBtn.TabIndex = 6;
            this.viewPassBtn.Text = "View Passwords";
            this.viewPassBtn.UseVisualStyleBackColor = true;
            this.viewPassBtn.Click += new System.EventHandler(this.viewPassBtn_Click);
            // 
            // passLength
            // 
            this.passLength.Location = new System.Drawing.Point(167, 78);
            this.passLength.Maximum = 20;
            this.passLength.Name = "passLength";
            this.passLength.Size = new System.Drawing.Size(138, 56);
            this.passLength.TabIndex = 7;
            this.passLength.Value = 10;
            // 
            // PL
            // 
            this.PL.AutoSize = true;
            this.PL.Location = new System.Drawing.Point(12, 95);
            this.PL.Name = "PL";
            this.PL.Size = new System.Drawing.Size(117, 17);
            this.PL.TabIndex = 8;
            this.PL.Text = "Password Length";
            // 
            // rootPanel
            // 
            this.ClientSize = new System.Drawing.Size(445, 195);
            this.Controls.Add(this.PL);
            this.Controls.Add(this.passLength);
            this.Controls.Add(this.viewPassBtn);
            this.Controls.Add(this.genPassBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.webApptxt);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.webApp);
            this.Name = "rootPanel";
            ((System.ComponentModel.ISupportInitialize)(this.passLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button viewPass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button genPass;
        private System.Windows.Forms.Label webApp;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox webApptxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button genPassBtn;
        private System.Windows.Forms.Button viewPassBtn;
        private System.Windows.Forms.TrackBar passLength;
        private System.Windows.Forms.Label PL;
    }
}

