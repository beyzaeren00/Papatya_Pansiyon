namespace Pansiyon
{
    partial class FrmAnaForm
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
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnyenimüşteri = new System.Windows.Forms.Button();
            this.btnodalar = new System.Windows.Forms.Button();
            this.btnmüşteriler = new System.Windows.Forms.Button();
            this.btnpersmaaş = new System.Windows.Forms.Button();
            this.btnstok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.Pink;
            this.btnadmin.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadmin.Location = new System.Drawing.Point(61, 77);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(158, 120);
            this.btnadmin.TabIndex = 0;
            this.btnadmin.Text = "Admin Giriş";
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnyenimüşteri
            // 
            this.btnyenimüşteri.BackColor = System.Drawing.Color.Pink;
            this.btnyenimüşteri.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyenimüşteri.Location = new System.Drawing.Point(242, 77);
            this.btnyenimüşteri.Name = "btnyenimüşteri";
            this.btnyenimüşteri.Size = new System.Drawing.Size(158, 120);
            this.btnyenimüşteri.TabIndex = 1;
            this.btnyenimüşteri.Text = "Yeni Müşteri";
            this.btnyenimüşteri.UseVisualStyleBackColor = false;
            this.btnyenimüşteri.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnodalar
            // 
            this.btnodalar.BackColor = System.Drawing.Color.Pink;
            this.btnodalar.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnodalar.Location = new System.Drawing.Point(432, 77);
            this.btnodalar.Name = "btnodalar";
            this.btnodalar.Size = new System.Drawing.Size(158, 120);
            this.btnodalar.TabIndex = 2;
            this.btnodalar.Text = "Odalar";
            this.btnodalar.UseVisualStyleBackColor = false;
            this.btnodalar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnmüşteriler
            // 
            this.btnmüşteriler.BackColor = System.Drawing.Color.Pink;
            this.btnmüşteriler.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmüşteriler.Location = new System.Drawing.Point(624, 77);
            this.btnmüşteriler.Name = "btnmüşteriler";
            this.btnmüşteriler.Size = new System.Drawing.Size(158, 120);
            this.btnmüşteriler.TabIndex = 3;
            this.btnmüşteriler.Text = "Müşteriler";
            this.btnmüşteriler.UseVisualStyleBackColor = false;
            this.btnmüşteriler.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnpersmaaş
            // 
            this.btnpersmaaş.BackColor = System.Drawing.Color.Pink;
            this.btnpersmaaş.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpersmaaş.Location = new System.Drawing.Point(146, 212);
            this.btnpersmaaş.Name = "btnpersmaaş";
            this.btnpersmaaş.Size = new System.Drawing.Size(158, 120);
            this.btnpersmaaş.TabIndex = 4;
            this.btnpersmaaş.Text = "Gelir-Gider";
            this.btnpersmaaş.UseVisualStyleBackColor = false;
            this.btnpersmaaş.Click += new System.EventHandler(this.btnpersmaaş_Click);
            // 
            // btnstok
            // 
            this.btnstok.BackColor = System.Drawing.Color.Pink;
            this.btnstok.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstok.Location = new System.Drawing.Point(344, 212);
            this.btnstok.Name = "btnstok";
            this.btnstok.Size = new System.Drawing.Size(158, 120);
            this.btnstok.TabIndex = 5;
            this.btnstok.Text = "Stok";
            this.btnstok.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(544, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 120);
            this.button2.TabIndex = 6;
            this.button2.Text = "Müşteri Mesajları";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnstok);
            this.Controls.Add(this.btnpersmaaş);
            this.Controls.Add(this.btnmüşteriler);
            this.Controls.Add(this.btnodalar);
            this.Controls.Add(this.btnyenimüşteri);
            this.Controls.Add(this.btnadmin);
            this.Name = "FrmAnaForm";
            this.Text = "FrmAnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnyenimüşteri;
        private System.Windows.Forms.Button btnodalar;
        private System.Windows.Forms.Button btnmüşteriler;
        private System.Windows.Forms.Button btnpersmaaş;
        private System.Windows.Forms.Button btnstok;
        private System.Windows.Forms.Button button2;
    }
}