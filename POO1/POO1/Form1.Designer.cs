namespace POO1
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
            this.labelAdam = new System.Windows.Forms.Label();
            this.labelAdamNumber = new System.Windows.Forms.Label();
            this.labelEve = new System.Windows.Forms.Label();
            this.labelEveNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAdam
            // 
            this.labelAdam.AutoSize = true;
            this.labelAdam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdam.Location = new System.Drawing.Point(12, 53);
            this.labelAdam.Name = "labelAdam";
            this.labelAdam.Size = new System.Drawing.Size(103, 37);
            this.labelAdam.TabIndex = 0;
            this.labelAdam.Text = "Name";
            // 
            // labelAdamNumber
            // 
            this.labelAdamNumber.AutoSize = true;
            this.labelAdamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdamNumber.Location = new System.Drawing.Point(137, 53);
            this.labelAdamNumber.Name = "labelAdamNumber";
            this.labelAdamNumber.Size = new System.Drawing.Size(132, 37);
            this.labelAdamNumber.TabIndex = 1;
            this.labelAdamNumber.Text = "Number";
            // 
            // labelEve
            // 
            this.labelEve.AutoSize = true;
            this.labelEve.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEve.Location = new System.Drawing.Point(12, 136);
            this.labelEve.Name = "labelEve";
            this.labelEve.Size = new System.Drawing.Size(103, 37);
            this.labelEve.TabIndex = 2;
            this.labelEve.Text = "Name";
            // 
            // labelEveNumber
            // 
            this.labelEveNumber.AutoSize = true;
            this.labelEveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEveNumber.Location = new System.Drawing.Point(137, 136);
            this.labelEveNumber.Name = "labelEveNumber";
            this.labelEveNumber.Size = new System.Drawing.Size(132, 37);
            this.labelEveNumber.TabIndex = 3;
            this.labelEveNumber.Text = "Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelEveNumber);
            this.Controls.Add(this.labelEve);
            this.Controls.Add(this.labelAdamNumber);
            this.Controls.Add(this.labelAdam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdam;
        private System.Windows.Forms.Label labelAdamNumber;
        private System.Windows.Forms.Label labelEve;
        private System.Windows.Forms.Label labelEveNumber;
    }
}

