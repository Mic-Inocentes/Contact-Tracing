
namespace Contact_Tracing
{
    partial class ContactTracing
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
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPronouns = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtboxContactNumber = new System.Windows.Forms.TextBox();
            this.txtboxTemperature = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttnSave
            // 
            this.bttnSave.BackColor = System.Drawing.Color.SeaShell;
            this.bttnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSave.Location = new System.Drawing.Point(114, 185);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(178, 25);
            this.bttnSave.TabIndex = 7;
            this.bttnSave.Text = "Save Information";
            this.bttnSave.UseVisualStyleBackColor = false;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFirstName.Location = new System.Drawing.Point(24, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(61, 15);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name";
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.BackColor = System.Drawing.Color.SeaShell;
            this.txtboxLastName.Location = new System.Drawing.Point(219, 36);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(168, 20);
            this.txtboxLastName.TabIndex = 10;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(216, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 15);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(74, 139);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 15);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Age:";
            // 
            // lblPronouns
            // 
            this.lblPronouns.AutoSize = true;
            this.lblPronouns.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPronouns.Location = new System.Drawing.Point(190, 139);
            this.lblPronouns.Name = "lblPronouns";
            this.lblPronouns.Size = new System.Drawing.Size(126, 15);
            this.lblPronouns.TabIndex = 13;
            this.lblPronouns.Text = "Temperature: (in celcius)";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(53, 74);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(50, 15);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address:";
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.BackColor = System.Drawing.Color.SeaShell;
            this.txtboxAddress.Location = new System.Drawing.Point(109, 72);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(277, 20);
            this.txtboxAddress.TabIndex = 17;
            // 
            // txtboxAge
            // 
            this.txtboxAge.BackColor = System.Drawing.Color.SeaShell;
            this.txtboxAge.Location = new System.Drawing.Point(109, 137);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(65, 20);
            this.txtboxAge.TabIndex = 18;
            this.txtboxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxAge_KeyPress);
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.BackColor = System.Drawing.Color.SeaShell;
            this.txtboxFirstName.Location = new System.Drawing.Point(27, 36);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(168, 20);
            this.txtboxFirstName.TabIndex = 21;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(13, 103);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(90, 15);
            this.lblContactNumber.TabIndex = 22;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // txtboxContactNumber
            // 
            this.txtboxContactNumber.BackColor = System.Drawing.Color.SeaShell;
            this.txtboxContactNumber.Location = new System.Drawing.Point(109, 101);
            this.txtboxContactNumber.Name = "txtboxContactNumber";
            this.txtboxContactNumber.Size = new System.Drawing.Size(277, 20);
            this.txtboxContactNumber.TabIndex = 23;
            this.txtboxContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxContactNumber_KeyPress);
            // 
            // txtboxTemperature
            // 
            this.txtboxTemperature.BackColor = System.Drawing.Color.SeaShell;
            this.txtboxTemperature.Location = new System.Drawing.Point(322, 137);
            this.txtboxTemperature.Name = "txtboxTemperature";
            this.txtboxTemperature.Size = new System.Drawing.Size(65, 20);
            this.txtboxTemperature.TabIndex = 24;
            this.txtboxTemperature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxTemperature_KeyPress);
            // 
            // ContactTracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(405, 231);
            this.Controls.Add(this.txtboxTemperature);
            this.Controls.Add(this.txtboxContactNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.txtboxFirstName);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPronouns);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtboxLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.bttnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ContactTracing";
            this.ShowIcon = false;
            this.Text = "Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPronouns;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.TextBox txtboxAge;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtboxContactNumber;
        private System.Windows.Forms.TextBox txtboxTemperature;
    }
}

