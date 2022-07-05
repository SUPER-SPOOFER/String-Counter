namespace StringCounter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siticoneTextBox1 = new Siticone.UI.WinForms.SiticoneTextBox();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FillColor = System.Drawing.Color.LightGray;
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.FocusedState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.ForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.HoveredState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Location = new System.Drawing.Point(12, 35);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.siticoneTextBox1.PlaceholderText = "Enter your words!";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.ShadowDecoration.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Size = new System.Drawing.Size(469, 36);
            this.siticoneTextBox1.TabIndex = 0;
            this.siticoneTextBox1.TextChanged += new System.EventHandler(this.siticoneTextBox1_TextChanged);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(12, 77);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(76, 19);
            this.siticoneLabel1.TabIndex = 1;
            this.siticoneLabel1.Text = "0 Characters";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticoneControlBox1);
            this.siticonePanel1.FillColor = System.Drawing.Color.Gainsboro;
            this.siticonePanel1.Location = new System.Drawing.Point(-3, -1);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(514, 30);
            this.siticonePanel1.TabIndex = 2;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Gainsboro;
            this.siticoneControlBox1.HoveredState.BorderColor = System.Drawing.Color.Gainsboro;
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.Gainsboro;
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.Location = new System.Drawing.Point(462, 5);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(30, 19);
            this.siticoneControlBox1.TabIndex = 3;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.TargetControl = this.siticonePanel1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(493, 112);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.siticoneTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
    }
}

