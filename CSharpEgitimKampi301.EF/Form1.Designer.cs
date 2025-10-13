namespace CSharpEgitimKampi301.EF
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Güncelle = new System.Windows.Forms.Button();
            this.btn_IdGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rehber Id:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(108, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(145, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(108, 49);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(145, 20);
            this.txtAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rehber Adı:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(108, 85);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(145, 20);
            this.txtSoyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rehber Soyadı:";
            // 
            // btn_Listele
            // 
            this.btn_Listele.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Listele.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listele.ForeColor = System.Drawing.Color.White;
            this.btn_Listele.Location = new System.Drawing.Point(108, 111);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(145, 32);
            this.btn_Listele.TabIndex = 6;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = false;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(108, 149);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(145, 32);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sil.ForeColor = System.Drawing.Color.White;
            this.btn_Sil.Location = new System.Drawing.Point(108, 187);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(145, 32);
            this.btn_Sil.TabIndex = 8;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Güncelle
            // 
            this.btn_Güncelle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Güncelle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Güncelle.ForeColor = System.Drawing.Color.White;
            this.btn_Güncelle.Location = new System.Drawing.Point(108, 225);
            this.btn_Güncelle.Name = "btn_Güncelle";
            this.btn_Güncelle.Size = new System.Drawing.Size(145, 32);
            this.btn_Güncelle.TabIndex = 9;
            this.btn_Güncelle.Text = "Güncelle";
            this.btn_Güncelle.UseVisualStyleBackColor = false;
            this.btn_Güncelle.Click += new System.EventHandler(this.btn_Güncelle_Click);
            // 
            // btn_IdGetir
            // 
            this.btn_IdGetir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_IdGetir.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IdGetir.ForeColor = System.Drawing.Color.White;
            this.btn_IdGetir.Location = new System.Drawing.Point(108, 263);
            this.btn_IdGetir.Name = "btn_IdGetir";
            this.btn_IdGetir.Size = new System.Drawing.Size(145, 32);
            this.btn_IdGetir.TabIndex = 10;
            this.btn_IdGetir.Text = "Id\'ye göre getir";
            this.btn_IdGetir.UseVisualStyleBackColor = false;
            this.btn_IdGetir.Click += new System.EventHandler(this.btn_IdGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 278);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_IdGetir);
            this.Controls.Add(this.btn_Güncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rehber İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Güncelle;
        private System.Windows.Forms.Button btn_IdGetir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

