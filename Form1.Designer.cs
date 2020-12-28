namespace amort_nacrt_2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.obrestnaMeraBox = new System.Windows.Forms.TextBox();
            this.stKuponovBox = new System.Windows.Forms.TextBox();
            this.nominalaBox = new System.Windows.Forms.TextBox();
            this.oznakaNalozbe = new System.Windows.Forms.ComboBox();
            this.dataGridPrikaz = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.shrani = new System.Windows.Forms.Button();
            this.zapri = new System.Windows.Forms.Button();
            this.izracunaj = new System.Windows.Forms.Button();
            this.zacetniDatumBox = new System.Windows.Forms.DateTimePicker();
            this.zapadlostBox = new System.Windows.Forms.DateTimePicker();
            this.CleanButton = new System.Windows.Forms.Button();
            this.PocistiDB = new System.Windows.Forms.Button();
            this.PokaziBazo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "End date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interest rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of coupons";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nominal value";
            // 
            // obrestnaMeraBox
            // 
            this.obrestnaMeraBox.Location = new System.Drawing.Point(183, 158);
            this.obrestnaMeraBox.Name = "obrestnaMeraBox";
            this.obrestnaMeraBox.Size = new System.Drawing.Size(217, 22);
            this.obrestnaMeraBox.TabIndex = 4;
            // 
            // stKuponovBox
            // 
            this.stKuponovBox.Location = new System.Drawing.Point(183, 191);
            this.stKuponovBox.Name = "stKuponovBox";
            this.stKuponovBox.Size = new System.Drawing.Size(217, 22);
            this.stKuponovBox.TabIndex = 5;
            // 
            // nominalaBox
            // 
            this.nominalaBox.Location = new System.Drawing.Point(183, 227);
            this.nominalaBox.Name = "nominalaBox";
            this.nominalaBox.Size = new System.Drawing.Size(217, 22);
            this.nominalaBox.TabIndex = 6;
            // 
            // oznakaNalozbe
            // 
            this.oznakaNalozbe.DisplayMember = "rerqr";
            this.oznakaNalozbe.FormattingEnabled = true;
            this.oznakaNalozbe.Items.AddRange(new object[] {
            "Simple bond amortization plan"});
            this.oznakaNalozbe.Location = new System.Drawing.Point(183, 44);
            this.oznakaNalozbe.Name = "oznakaNalozbe";
            this.oznakaNalozbe.Size = new System.Drawing.Size(217, 24);
            this.oznakaNalozbe.TabIndex = 1;
            this.oznakaNalozbe.Text = "(select plan)";
            // 
            // dataGridPrikaz
            // 
            this.dataGridPrikaz.AllowUserToAddRows = false;
            this.dataGridPrikaz.AllowUserToDeleteRows = false;
            this.dataGridPrikaz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPrikaz.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridPrikaz.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrikaz.Location = new System.Drawing.Point(46, 340);
            this.dataGridPrikaz.Name = "dataGridPrikaz";
            this.dataGridPrikaz.ReadOnly = true;
            this.dataGridPrikaz.RowHeadersWidth = 51;
            this.dataGridPrikaz.RowTemplate.Height = 24;
            this.dataGridPrikaz.Size = new System.Drawing.Size(548, 246);
            this.dataGridPrikaz.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Type of plan";
            // 
            // shrani
            // 
            this.shrani.Location = new System.Drawing.Point(183, 289);
            this.shrani.Name = "shrani";
            this.shrani.Size = new System.Drawing.Size(96, 33);
            this.shrani.TabIndex = 8;
            this.shrani.Text = "Save";
            this.shrani.UseVisualStyleBackColor = true;
            this.shrani.Click += new System.EventHandler(this.shrani_Click);
            // 
            // zapri
            // 
            this.zapri.Location = new System.Drawing.Point(305, 289);
            this.zapri.Name = "zapri";
            this.zapri.Size = new System.Drawing.Size(95, 33);
            this.zapri.TabIndex = 9;
            this.zapri.Text = "Close";
            this.zapri.UseVisualStyleBackColor = true;
            this.zapri.Click += new System.EventHandler(this.zapri_Click);
            // 
            // izracunaj
            // 
            this.izracunaj.Location = new System.Drawing.Point(46, 289);
            this.izracunaj.Name = "izracunaj";
            this.izracunaj.Size = new System.Drawing.Size(95, 33);
            this.izracunaj.TabIndex = 7;
            this.izracunaj.Text = "Calculate";
            this.izracunaj.UseVisualStyleBackColor = true;
            this.izracunaj.Click += new System.EventHandler(this.izracunaj_Click);
            // 
            // zacetniDatumBox
            // 
            this.zacetniDatumBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zacetniDatumBox.CustomFormat = " dd-MM-yyyy";
            this.zacetniDatumBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.zacetniDatumBox.Location = new System.Drawing.Point(183, 88);
            this.zacetniDatumBox.Name = "zacetniDatumBox";
            this.zacetniDatumBox.Size = new System.Drawing.Size(217, 22);
            this.zacetniDatumBox.TabIndex = 2;
            this.zacetniDatumBox.Value = new System.DateTime(2020, 10, 8, 0, 0, 0, 0);
            // 
            // zapadlostBox
            // 
            this.zapadlostBox.CustomFormat = " dd-MM-yyyy";
            this.zapadlostBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.zapadlostBox.Location = new System.Drawing.Point(183, 120);
            this.zapadlostBox.Name = "zapadlostBox";
            this.zapadlostBox.Size = new System.Drawing.Size(217, 22);
            this.zapadlostBox.TabIndex = 3;
            this.zapadlostBox.Value = new System.DateTime(2020, 10, 8, 0, 0, 0, 0);
            // 
            // CleanButton
            // 
            this.CleanButton.AccessibleDescription = "";
            this.CleanButton.Location = new System.Drawing.Point(518, 593);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(75, 23);
            this.CleanButton.TabIndex = 11;
            this.CleanButton.Text = "Clear";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // PocistiDB
            // 
            this.PocistiDB.Location = new System.Drawing.Point(507, 294);
            this.PocistiDB.Name = "PocistiDB";
            this.PocistiDB.Size = new System.Drawing.Size(87, 23);
            this.PocistiDB.TabIndex = 12;
            this.PocistiDB.Text = "DeleteDB";
            this.PocistiDB.UseVisualStyleBackColor = true;
            this.PocistiDB.Click += new System.EventHandler(this.PocistiDB_Click);
            // 
            // PokaziBazo
            // 
            this.PokaziBazo.Location = new System.Drawing.Point(507, 265);
            this.PokaziBazo.Name = "PokaziBazo";
            this.PokaziBazo.Size = new System.Drawing.Size(86, 23);
            this.PokaziBazo.TabIndex = 13;
            this.PokaziBazo.Text = "ShowDB";
            this.PokaziBazo.UseVisualStyleBackColor = true;
            this.PokaziBazo.Click += new System.EventHandler(this.PokaziBazo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 631);
            this.Controls.Add(this.PokaziBazo);
            this.Controls.Add(this.PocistiDB);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.zapadlostBox);
            this.Controls.Add(this.zacetniDatumBox);
            this.Controls.Add(this.izracunaj);
            this.Controls.Add(this.zapri);
            this.Controls.Add(this.shrani);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridPrikaz);
            this.Controls.Add(this.oznakaNalozbe);
            this.Controls.Add(this.nominalaBox);
            this.Controls.Add(this.stKuponovBox);
            this.Controls.Add(this.obrestnaMeraBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Amortizacijski načrt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox obrestnaMeraBox;
        private System.Windows.Forms.TextBox stKuponovBox;
        private System.Windows.Forms.TextBox nominalaBox;
        private System.Windows.Forms.ComboBox oznakaNalozbe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button shrani;
        private System.Windows.Forms.Button zapri;
        private System.Windows.Forms.Button izracunaj;
        public System.Windows.Forms.DateTimePicker zacetniDatumBox;
        public System.Windows.Forms.DateTimePicker zapadlostBox;
        private System.Windows.Forms.Button CleanButton;
        public System.Windows.Forms.DataGridView dataGridPrikaz;
        private System.Windows.Forms.Button PocistiDB;
        private System.Windows.Forms.Button PokaziBazo;
    }
}

