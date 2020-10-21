namespace Podcasts
{
    partial class Podcasts
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Humor");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("3");
            this.listView1 = new System.Windows.Forms.ListView();
            this.Avsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonNy = new System.Windows.Forms.Button();
            this.buttonSpara = new System.Windows.Forms.Button();
            this.buttonTa_bort = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonNyKategori = new System.Windows.Forms.Button();
            this.buttonSparaKategori = new System.Windows.Forms.Button();
            this.buttonKategoriTa_bort = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Avsnitt,
            this.Namn,
            this.Frekvens,
            this.Kategori});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(473, 168);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Avsnitt
            // 
            this.Avsnitt.Text = "Avsnitt";
            this.Avsnitt.Width = 118;
            // 
            // Namn
            // 
            this.Namn.Text = "Namn";
            this.Namn.Width = 110;
            // 
            // Frekvens
            // 
            this.Frekvens.Text = "Frekvens";
            this.Frekvens.Width = 114;
            // 
            // Kategori
            // 
            this.Kategori.Text = "Kategori";
            this.Kategori.Width = 127;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView2.Location = new System.Drawing.Point(503, 52);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(237, 168);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategorier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "http://...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uppdateringsfrekvens";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 248);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kategori";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(364, 248);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // buttonNy
            // 
            this.buttonNy.Location = new System.Drawing.Point(237, 275);
            this.buttonNy.Name = "buttonNy";
            this.buttonNy.Size = new System.Drawing.Size(75, 23);
            this.buttonNy.TabIndex = 9;
            this.buttonNy.Text = "Ny";
            this.buttonNy.UseVisualStyleBackColor = true;
            // 
            // buttonSpara
            // 
            this.buttonSpara.Location = new System.Drawing.Point(318, 275);
            this.buttonSpara.Name = "buttonSpara";
            this.buttonSpara.Size = new System.Drawing.Size(75, 23);
            this.buttonSpara.TabIndex = 10;
            this.buttonSpara.Text = "Spara";
            this.buttonSpara.UseVisualStyleBackColor = true;
            // 
            // buttonTa_bort
            // 
            this.buttonTa_bort.Location = new System.Drawing.Point(399, 275);
            this.buttonTa_bort.Name = "buttonTa_bort";
            this.buttonTa_bort.Size = new System.Drawing.Size(86, 23);
            this.buttonTa_bort.TabIndex = 11;
            this.buttonTa_bort.Text = "Ta bort";
            this.buttonTa_bort.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView3.Location = new System.Drawing.Point(12, 331);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(473, 151);
            this.listView3.TabIndex = 12;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(503, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 13;
            // 
            // buttonNyKategori
            // 
            this.buttonNyKategori.Location = new System.Drawing.Point(503, 256);
            this.buttonNyKategori.Name = "buttonNyKategori";
            this.buttonNyKategori.Size = new System.Drawing.Size(75, 23);
            this.buttonNyKategori.TabIndex = 14;
            this.buttonNyKategori.Text = "Ny";
            this.buttonNyKategori.UseVisualStyleBackColor = true;
            // 
            // buttonSparaKategori
            // 
            this.buttonSparaKategori.Location = new System.Drawing.Point(584, 256);
            this.buttonSparaKategori.Name = "buttonSparaKategori";
            this.buttonSparaKategori.Size = new System.Drawing.Size(75, 23);
            this.buttonSparaKategori.TabIndex = 15;
            this.buttonSparaKategori.Text = "Spara";
            this.buttonSparaKategori.UseVisualStyleBackColor = true;
            // 
            // buttonKategoriTa_bort
            // 
            this.buttonKategoriTa_bort.Location = new System.Drawing.Point(665, 256);
            this.buttonKategoriTa_bort.Name = "buttonKategoriTa_bort";
            this.buttonKategoriTa_bort.Size = new System.Drawing.Size(75, 23);
            this.buttonKategoriTa_bort.TabIndex = 16;
            this.buttonKategoriTa_bort.Text = "Ta Bort";
            this.buttonKategoriTa_bort.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Podcasts";
            // 
            // Podcasts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 494);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonKategoriTa_bort);
            this.Controls.Add(this.buttonSparaKategori);
            this.Controls.Add(this.buttonNyKategori);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.buttonTa_bort);
            this.Controls.Add(this.buttonSpara);
            this.Controls.Add(this.buttonNy);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Podcasts";
            this.Text = "Podcasts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Avsnitt;
        private System.Windows.Forms.ColumnHeader Namn;
        private System.Windows.Forms.ColumnHeader Frekvens;
        private System.Windows.Forms.ColumnHeader Kategori;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonNy;
        private System.Windows.Forms.Button buttonSpara;
        private System.Windows.Forms.Button buttonTa_bort;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonNyKategori;
        private System.Windows.Forms.Button buttonSparaKategori;
        private System.Windows.Forms.Button buttonKategoriTa_bort;
        private System.Windows.Forms.Label label5;
    }
}

