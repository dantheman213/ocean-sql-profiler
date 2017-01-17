namespace Ocean
{
    partial class FormOptions
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
            if (disposing && (components != null)) {
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
            this.buttonBrowse1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textCommandLogLocation = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBrowse1
            // 
            this.buttonBrowse1.Location = new System.Drawing.Point(731, 73);
            this.buttonBrowse1.Name = "buttonBrowse1";
            this.buttonBrowse1.Size = new System.Drawing.Size(139, 25);
            this.buttonBrowse1.TabIndex = 5;
            this.buttonBrowse1.Text = "Browse";
            this.buttonBrowse1.UseVisualStyleBackColor = true;
            this.buttonBrowse1.Click += new System.EventHandler(this.buttonBrowse1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location of Postgres Statement Log:";
            // 
            // textCommandLogLocation
            // 
            this.textCommandLogLocation.Location = new System.Drawing.Point(197, 76);
            this.textCommandLogLocation.Name = "textCommandLogLocation";
            this.textCommandLogLocation.ReadOnly = true;
            this.textCommandLogLocation.Size = new System.Drawing.Size(522, 20);
            this.textCommandLogLocation.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(731, 171);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 53);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 110);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "to learn how to setup and access your pg_log with appropiate output options.";
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBrowse1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCommandLogLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBrowse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCommandLogLocation;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}