namespace Bitirme2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwBilgiler = new System.Windows.Forms.DataGridView();
            this.lblname = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.tbxsurname = new System.Windows.Forms.TextBox();
            this.tbxage = new System.Windows.Forms.TextBox();
            this.tbxcity = new System.Windows.Forms.TextBox();
            this.gbxEkle = new System.Windows.Forms.GroupBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.gbxGüncelle = new System.Windows.Forms.GroupBox();
            this.btnRnd = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.tbxcityUpdate = new System.Windows.Forms.TextBox();
            this.lblnameUpdate = new System.Windows.Forms.Label();
            this.lblsurnameUpdate = new System.Windows.Forms.Label();
            this.tbxageUpdate = new System.Windows.Forms.TextBox();
            this.lblageUpdate = new System.Windows.Forms.Label();
            this.tbxsurnameUpdate = new System.Windows.Forms.TextBox();
            this.tbxnameUpdate = new System.Windows.Forms.TextBox();
            this.lblcityUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBilgiler)).BeginInit();
            this.gbxEkle.SuspendLayout();
            this.gbxGüncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBilgiler
            // 
            this.dgwBilgiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBilgiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBilgiler.Location = new System.Drawing.Point(12, 12);
            this.dgwBilgiler.Name = "dgwBilgiler";
            this.dgwBilgiler.RowHeadersWidth = 51;
            this.dgwBilgiler.RowTemplate.Height = 24;
            this.dgwBilgiler.Size = new System.Drawing.Size(776, 247);
            this.dgwBilgiler.TabIndex = 0;
            this.dgwBilgiler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBilgiler_CellClick);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblname.Location = new System.Drawing.Point(18, 32);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(52, 18);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsurname.Location = new System.Drawing.Point(18, 75);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(75, 18);
            this.lblsurname.TabIndex = 2;
            this.lblsurname.Text = "Surname";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblage.Location = new System.Drawing.Point(18, 119);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(36, 18);
            this.lblage.TabIndex = 3;
            this.lblage.Text = "Age";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcity.Location = new System.Drawing.Point(18, 208);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(37, 18);
            this.lblcity.TabIndex = 5;
            this.lblcity.Text = "City";
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(98, 27);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(197, 27);
            this.tbxname.TabIndex = 6;
            // 
            // tbxsurname
            // 
            this.tbxsurname.Location = new System.Drawing.Point(98, 70);
            this.tbxsurname.Name = "tbxsurname";
            this.tbxsurname.Size = new System.Drawing.Size(197, 27);
            this.tbxsurname.TabIndex = 7;
            // 
            // tbxage
            // 
            this.tbxage.Location = new System.Drawing.Point(98, 114);
            this.tbxage.Name = "tbxage";
            this.tbxage.Size = new System.Drawing.Size(197, 27);
            this.tbxage.TabIndex = 8;
            // 
            // tbxcity
            // 
            this.tbxcity.Location = new System.Drawing.Point(98, 203);
            this.tbxcity.Name = "tbxcity";
            this.tbxcity.Size = new System.Drawing.Size(197, 27);
            this.tbxcity.TabIndex = 10;
            // 
            // gbxEkle
            // 
            this.gbxEkle.Controls.Add(this.btnekle);
            this.gbxEkle.Controls.Add(this.tbxcity);
            this.gbxEkle.Controls.Add(this.lblname);
            this.gbxEkle.Controls.Add(this.lblsurname);
            this.gbxEkle.Controls.Add(this.tbxage);
            this.gbxEkle.Controls.Add(this.lblage);
            this.gbxEkle.Controls.Add(this.tbxsurname);
            this.gbxEkle.Controls.Add(this.tbxname);
            this.gbxEkle.Controls.Add(this.lblcity);
            this.gbxEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxEkle.Location = new System.Drawing.Point(12, 293);
            this.gbxEkle.Name = "gbxEkle";
            this.gbxEkle.Size = new System.Drawing.Size(379, 298);
            this.gbxEkle.TabIndex = 11;
            this.gbxEkle.TabStop = false;
            this.gbxEkle.Text = "Bilgi Ekle";
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(145, 248);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 34);
            this.btnekle.TabIndex = 12;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // gbxGüncelle
            // 
            this.gbxGüncelle.Controls.Add(this.btnRnd);
            this.gbxGüncelle.Controls.Add(this.btngüncelle);
            this.gbxGüncelle.Controls.Add(this.tbxcityUpdate);
            this.gbxGüncelle.Controls.Add(this.lblnameUpdate);
            this.gbxGüncelle.Controls.Add(this.lblsurnameUpdate);
            this.gbxGüncelle.Controls.Add(this.tbxageUpdate);
            this.gbxGüncelle.Controls.Add(this.lblageUpdate);
            this.gbxGüncelle.Controls.Add(this.tbxsurnameUpdate);
            this.gbxGüncelle.Controls.Add(this.tbxnameUpdate);
            this.gbxGüncelle.Controls.Add(this.lblcityUpdate);
            this.gbxGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxGüncelle.Location = new System.Drawing.Point(403, 304);
            this.gbxGüncelle.Name = "gbxGüncelle";
            this.gbxGüncelle.Size = new System.Drawing.Size(396, 287);
            this.gbxGüncelle.TabIndex = 12;
            this.gbxGüncelle.TabStop = false;
            this.gbxGüncelle.Text = "Bilgileri Güncelle";
            // 
            // btnRnd
            // 
            this.btnRnd.Location = new System.Drawing.Point(159, 248);
            this.btnRnd.Name = "btnRnd";
            this.btnRnd.Size = new System.Drawing.Size(193, 33);
            this.btnRnd.TabIndex = 13;
            this.btnRnd.Text = "Random Güncelle";
            this.btnRnd.UseVisualStyleBackColor = true;
            this.btnRnd.Click += new System.EventHandler(this.btnRnd_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.Location = new System.Drawing.Point(55, 248);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(85, 34);
            this.btngüncelle.TabIndex = 12;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // tbxcityUpdate
            // 
            this.tbxcityUpdate.Location = new System.Drawing.Point(98, 203);
            this.tbxcityUpdate.Name = "tbxcityUpdate";
            this.tbxcityUpdate.Size = new System.Drawing.Size(197, 27);
            this.tbxcityUpdate.TabIndex = 10;
            // 
            // lblnameUpdate
            // 
            this.lblnameUpdate.AutoSize = true;
            this.lblnameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnameUpdate.Location = new System.Drawing.Point(18, 32);
            this.lblnameUpdate.Name = "lblnameUpdate";
            this.lblnameUpdate.Size = new System.Drawing.Size(52, 18);
            this.lblnameUpdate.TabIndex = 1;
            this.lblnameUpdate.Text = "Name";
            // 
            // lblsurnameUpdate
            // 
            this.lblsurnameUpdate.AutoSize = true;
            this.lblsurnameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsurnameUpdate.Location = new System.Drawing.Point(18, 75);
            this.lblsurnameUpdate.Name = "lblsurnameUpdate";
            this.lblsurnameUpdate.Size = new System.Drawing.Size(75, 18);
            this.lblsurnameUpdate.TabIndex = 2;
            this.lblsurnameUpdate.Text = "Surname";
            // 
            // tbxageUpdate
            // 
            this.tbxageUpdate.Location = new System.Drawing.Point(98, 114);
            this.tbxageUpdate.Name = "tbxageUpdate";
            this.tbxageUpdate.Size = new System.Drawing.Size(197, 27);
            this.tbxageUpdate.TabIndex = 8;
            // 
            // lblageUpdate
            // 
            this.lblageUpdate.AutoSize = true;
            this.lblageUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblageUpdate.Location = new System.Drawing.Point(18, 119);
            this.lblageUpdate.Name = "lblageUpdate";
            this.lblageUpdate.Size = new System.Drawing.Size(36, 18);
            this.lblageUpdate.TabIndex = 3;
            this.lblageUpdate.Text = "Age";
            // 
            // tbxsurnameUpdate
            // 
            this.tbxsurnameUpdate.Location = new System.Drawing.Point(98, 70);
            this.tbxsurnameUpdate.Name = "tbxsurnameUpdate";
            this.tbxsurnameUpdate.Size = new System.Drawing.Size(197, 27);
            this.tbxsurnameUpdate.TabIndex = 7;
            // 
            // tbxnameUpdate
            // 
            this.tbxnameUpdate.Location = new System.Drawing.Point(98, 27);
            this.tbxnameUpdate.Name = "tbxnameUpdate";
            this.tbxnameUpdate.Size = new System.Drawing.Size(197, 27);
            this.tbxnameUpdate.TabIndex = 6;
            // 
            // lblcityUpdate
            // 
            this.lblcityUpdate.AutoSize = true;
            this.lblcityUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcityUpdate.Location = new System.Drawing.Point(18, 208);
            this.lblcityUpdate.Name = "lblcityUpdate";
            this.lblcityUpdate.Size = new System.Drawing.Size(37, 18);
            this.lblcityUpdate.TabIndex = 5;
            this.lblcityUpdate.Text = "City";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.Location = new System.Drawing.Point(361, 597);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 31);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 629);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxGüncelle);
            this.Controls.Add(this.gbxEkle);
            this.Controls.Add(this.dgwBilgiler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBilgiler)).EndInit();
            this.gbxEkle.ResumeLayout(false);
            this.gbxEkle.PerformLayout();
            this.gbxGüncelle.ResumeLayout(false);
            this.gbxGüncelle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBilgiler;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.TextBox tbxsurname;
        private System.Windows.Forms.TextBox tbxage;
        private System.Windows.Forms.TextBox tbxcity;
        private System.Windows.Forms.GroupBox gbxEkle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.GroupBox gbxGüncelle;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.TextBox tbxcityUpdate;
        private System.Windows.Forms.Label lblnameUpdate;
        private System.Windows.Forms.Label lblsurnameUpdate;
        private System.Windows.Forms.TextBox tbxageUpdate;
        private System.Windows.Forms.Label lblageUpdate;
        private System.Windows.Forms.TextBox tbxsurnameUpdate;
        private System.Windows.Forms.TextBox tbxnameUpdate;
        private System.Windows.Forms.Label lblcityUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRnd;
    }
}

