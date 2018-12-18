namespace WindowsFormsApp1
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblYD = new System.Windows.Forms.Label();
            this.lblXD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.Red;
            this.lblX.Location = new System.Drawing.Point(40, 42);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(135, 31);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "Waiting ...";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.ForeColor = System.Drawing.Color.Red;
            this.lblY.Location = new System.Drawing.Point(263, 42);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(135, 31);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Waiting ...";
            // 
            // lblYD
            // 
            this.lblYD.AutoSize = true;
            this.lblYD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYD.ForeColor = System.Drawing.Color.Green;
            this.lblYD.Location = new System.Drawing.Point(263, 176);
            this.lblYD.Name = "lblYD";
            this.lblYD.Size = new System.Drawing.Size(135, 31);
            this.lblYD.TabIndex = 3;
            this.lblYD.Text = "Waiting ...";
            // 
            // lblXD
            // 
            this.lblXD.AutoSize = true;
            this.lblXD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXD.ForeColor = System.Drawing.Color.Green;
            this.lblXD.Location = new System.Drawing.Point(40, 176);
            this.lblXD.Name = "lblXD";
            this.lblXD.Size = new System.Drawing.Size(135, 31);
            this.lblXD.TabIndex = 2;
            this.lblXD.Text = "Waiting ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 233);
            this.Controls.Add(this.lblYD);
            this.Controls.Add(this.lblXD);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblYD;
        private System.Windows.Forms.Label lblXD;
    }
}

