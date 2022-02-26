namespace Caculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb3 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.cong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số b:";
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(112, 51);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(155, 22);
            this.txtb1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết quả:";
            // 
            // txtb3
            // 
            this.txtb3.Location = new System.Drawing.Point(112, 107);
            this.txtb3.Name = "txtb3";
            this.txtb3.Size = new System.Drawing.Size(155, 22);
            this.txtb3.TabIndex = 4;
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(112, 79);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(155, 22);
            this.txtb2.TabIndex = 5;
            // 
            // cong
            // 
            this.cong.Location = new System.Drawing.Point(193, 148);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(74, 24);
            this.cong.TabIndex = 6;
            this.cong.Text = "Cộng";
            this.cong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 194);
            this.Controls.Add(this.cong);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.txtb3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.Button cong;
    }
}

