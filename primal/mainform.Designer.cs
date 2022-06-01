namespace primal
{
    partial class mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitbutton = new System.Windows.Forms.Button();
            this.beginbutton = new System.Windows.Forms.Button();
            this.calculationoutput = new System.Windows.Forms.TextBox();
            this.outputlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(644, 506);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(128, 43);
            this.exitbutton.TabIndex = 0;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // beginbutton
            // 
            this.beginbutton.Location = new System.Drawing.Point(510, 506);
            this.beginbutton.Name = "beginbutton";
            this.beginbutton.Size = new System.Drawing.Size(128, 43);
            this.beginbutton.TabIndex = 1;
            this.beginbutton.Text = "Begin";
            this.beginbutton.UseVisualStyleBackColor = true;
            this.beginbutton.Click += new System.EventHandler(this.beginbutton_Click);
            // 
            // calculationoutput
            // 
            this.calculationoutput.Location = new System.Drawing.Point(12, 94);
            this.calculationoutput.Multiline = true;
            this.calculationoutput.Name = "calculationoutput";
            this.calculationoutput.ReadOnly = true;
            this.calculationoutput.Size = new System.Drawing.Size(760, 406);
            this.calculationoutput.TabIndex = 2;
            // 
            // outputlabel
            // 
            this.outputlabel.AutoSize = true;
            this.outputlabel.Location = new System.Drawing.Point(12, 76);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(144, 15);
            this.outputlabel.TabIndex = 3;
            this.outputlabel.Text = "Primal calculation output:";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.calculationoutput);
            this.Controls.Add(this.beginbutton);
            this.Controls.Add(this.exitbutton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primal by Cameron Snyder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exitbutton;
        private Button beginbutton;
        private TextBox calculationoutput;
        private Label outputlabel;
    }
}