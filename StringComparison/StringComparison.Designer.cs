namespace StringComparison
{
    partial class frmStringComparison
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtStringOne = new System.Windows.Forms.TextBox();
            this.txtStringTwo = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(10, 25);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(271, 16);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter 2 strings to find out if they are the same:";
            // 
            // txtStringOne
            // 
            this.txtStringOne.Location = new System.Drawing.Point(13, 54);
            this.txtStringOne.Name = "txtStringOne";
            this.txtStringOne.Size = new System.Drawing.Size(265, 20);
            this.txtStringOne.TabIndex = 1;
            // 
            // txtStringTwo
            // 
            this.txtStringTwo.Location = new System.Drawing.Point(12, 99);
            this.txtStringTwo.Name = "txtStringTwo";
            this.txtStringTwo.Size = new System.Drawing.Size(265, 20);
            this.txtStringTwo.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(108, 138);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmStringComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 179);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtStringTwo);
            this.Controls.Add(this.txtStringOne);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmStringComparison";
            this.Text = "String Comparison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtStringOne;
        private System.Windows.Forms.TextBox txtStringTwo;
        private System.Windows.Forms.Button btnSubmit;
    }
}

