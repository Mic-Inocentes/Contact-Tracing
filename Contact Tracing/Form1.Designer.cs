
namespace Contact_Tracing
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
            this.bttnSave = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPronouns = new System.Windows.Forms.Label();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.txtboxPronouns = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtboxContactNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(312, 157);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(75, 20);
            this.bttnSave.TabIndex = 7;
            this.bttnSave.Text = "&Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(24, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name";
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Location = new System.Drawing.Point(27, 36);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(168, 20);
            this.txtboxFirstName.TabIndex = 9;
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Location = new System.Drawing.Point(219, 36);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(168, 20);
            this.txtboxLastName.TabIndex = 10;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(216, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(24, 77);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Age:";
            // 
            // lblPronouns
            // 
            this.lblPronouns.AutoSize = true;
            this.lblPronouns.Location = new System.Drawing.Point(216, 77);
            this.lblPronouns.Name = "lblPronouns";
            this.lblPronouns.Size = new System.Drawing.Size(55, 13);
            this.lblPronouns.TabIndex = 13;
            this.lblPronouns.Text = "Pronouns:";
            // 
            // txtboxAge
            // 
            this.txtboxAge.Location = new System.Drawing.Point(56, 74);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(139, 20);
            this.txtboxAge.TabIndex = 14;
            // 
            // txtboxPronouns
            // 
            this.txtboxPronouns.Location = new System.Drawing.Point(274, 74);
            this.txtboxPronouns.Name = "txtboxPronouns";
            this.txtboxPronouns.Size = new System.Drawing.Size(113, 20);
            this.txtboxPronouns.TabIndex = 15;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(24, 116);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(87, 13);
            this.lblContactNumber.TabIndex = 16;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // txtboxContactNumber
            // 
            this.txtboxContactNumber.Location = new System.Drawing.Point(114, 113);
            this.txtboxContactNumber.Name = "txtboxContactNumber";
            this.txtboxContactNumber.Size = new System.Drawing.Size(273, 20);
            this.txtboxContactNumber.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 202);
            this.Controls.Add(this.txtboxContactNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.txtboxPronouns);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.lblPronouns);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtboxLastName);
            this.Controls.Add(this.txtboxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.bttnSave);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPronouns;
        private System.Windows.Forms.TextBox txtboxAge;
        private System.Windows.Forms.TextBox txtboxPronouns;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtboxContactNumber;
    }
}

