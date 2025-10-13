namespace CSharpEgitimKampi301.EF
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_IdGetir = new System.Windows.Forms.Button();
            this.btn_Güncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.txtÜlke = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGeceGündüz = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numKapasite = new System.Windows.Forms.NumericUpDown();
            this.cbRehber = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKapasite)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(891, 334);
            this.dataGridView1.TabIndex = 23;
            // 
            // btn_IdGetir
            // 
            this.btn_IdGetir.BackColor = System.Drawing.Color.Brown;
            this.btn_IdGetir.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_IdGetir.ForeColor = System.Drawing.Color.White;
            this.btn_IdGetir.Location = new System.Drawing.Point(67, 324);
            this.btn_IdGetir.Name = "btn_IdGetir";
            this.btn_IdGetir.Size = new System.Drawing.Size(145, 32);
            this.btn_IdGetir.TabIndex = 22;
            this.btn_IdGetir.Text = "Id\'ye göre getir";
            this.btn_IdGetir.UseVisualStyleBackColor = false;
            this.btn_IdGetir.Click += new System.EventHandler(this.btn_IdGetir_Click);
            // 
            // btn_Güncelle
            // 
            this.btn_Güncelle.BackColor = System.Drawing.Color.Brown;
            this.btn_Güncelle.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Güncelle.ForeColor = System.Drawing.Color.White;
            this.btn_Güncelle.Location = new System.Drawing.Point(146, 286);
            this.btn_Güncelle.Name = "btn_Güncelle";
            this.btn_Güncelle.Size = new System.Drawing.Size(98, 32);
            this.btn_Güncelle.TabIndex = 21;
            this.btn_Güncelle.Text = "Güncelle";
            this.btn_Güncelle.UseVisualStyleBackColor = false;
            this.btn_Güncelle.Click += new System.EventHandler(this.btn_Güncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Brown;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.Color.White;
            this.btn_Sil.Location = new System.Drawing.Point(12, 286);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(99, 32);
            this.btn_Sil.TabIndex = 20;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Brown;
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(146, 239);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(96, 32);
            this.btn_Ekle.TabIndex = 19;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Listele
            // 
            this.btn_Listele.BackColor = System.Drawing.Color.Brown;
            this.btn_Listele.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Listele.ForeColor = System.Drawing.Color.White;
            this.btn_Listele.Location = new System.Drawing.Point(15, 239);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(96, 32);
            this.btn_Listele.TabIndex = 18;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = false;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // txtÜlke
            // 
            this.txtÜlke.Location = new System.Drawing.Point(98, 82);
            this.txtÜlke.Name = "txtÜlke";
            this.txtÜlke.Size = new System.Drawing.Size(145, 20);
            this.txtÜlke.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ülke:";
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(98, 52);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(145, 20);
            this.txtSehir.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Şehir:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(99, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(145, 20);
            this.txtID.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lokasyon Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kapasite:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(98, 142);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(145, 20);
            this.txtFiyat.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fiyat:";
            // 
            // txtGeceGündüz
            // 
            this.txtGeceGündüz.Location = new System.Drawing.Point(98, 175);
            this.txtGeceGündüz.Name = "txtGeceGündüz";
            this.txtGeceGündüz.Size = new System.Drawing.Size(145, 20);
            this.txtGeceGündüz.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Gün Gece :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Rehber :";
            // 
            // numKapasite
            // 
            this.numKapasite.Location = new System.Drawing.Point(97, 112);
            this.numKapasite.Name = "numKapasite";
            this.numKapasite.Size = new System.Drawing.Size(146, 20);
            this.numKapasite.TabIndex = 32;
            // 
            // cbRehber
            // 
            this.cbRehber.FormattingEnabled = true;
            this.cbRehber.Location = new System.Drawing.Point(97, 205);
            this.cbRehber.Name = "cbRehber";
            this.cbRehber.Size = new System.Drawing.Size(145, 21);
            this.cbRehber.TabIndex = 33;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 387);
            this.Controls.Add(this.cbRehber);
            this.Controls.Add(this.numKapasite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGeceGündüz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_IdGetir);
            this.Controls.Add(this.btn_Güncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.txtÜlke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Lokasyon İşlemleri";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKapasite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_IdGetir;
        private System.Windows.Forms.Button btn_Güncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.TextBox txtÜlke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGeceGündüz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numKapasite;
        private System.Windows.Forms.ComboBox cbRehber;
    }
}