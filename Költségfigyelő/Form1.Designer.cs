namespace winformProject
{
    partial class Koltsegfigyelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Koltsegfigyelo));
            this.tbMegnevezes = new System.Windows.Forms.TextBox();
            this.tbOsszeg = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnAdatok = new System.Windows.Forms.Button();
            this.btnFajlba = new System.Windows.Forms.Button();
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Megnevezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opciok = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbKategoria = new System.Windows.Forms.ComboBox();
            this.tlp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMegnevezes
            // 
            resources.ApplyResources(this.tbMegnevezes, "tbMegnevezes");
            this.tbMegnevezes.Name = "tbMegnevezes";
            this.tbMegnevezes.Click += new System.EventHandler(this.tbMegnevezes_Click);
            // 
            // tbOsszeg
            // 
            resources.ApplyResources(this.tbOsszeg, "tbOsszeg");
            this.tbOsszeg.Name = "tbOsszeg";
            this.tbOsszeg.Click += new System.EventHandler(this.tbOsszeg_Click);
            // 
            // dtpDatum
            // 
            resources.ApplyResources(this.dtpDatum, "dtpDatum");
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Name = "dtpDatum";
            // 
            // btnMentes
            // 
            this.btnMentes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnMentes, "btnMentes");
            this.btnMentes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.UseVisualStyleBackColor = false;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnTorles, "btnTorles");
            this.btnTorles.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.UseVisualStyleBackColor = false;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnAdatok
            // 
            this.btnAdatok.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnAdatok, "btnAdatok");
            this.btnAdatok.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdatok.Name = "btnAdatok";
            this.btnAdatok.UseVisualStyleBackColor = false;
            this.btnAdatok.Click += new System.EventHandler(this.btnAdatok_Click);
            // 
            // btnFajlba
            // 
            this.btnFajlba.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnFajlba, "btnFajlba");
            this.btnFajlba.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFajlba.Name = "btnFajlba";
            this.btnFajlba.UseVisualStyleBackColor = false;
            this.btnFajlba.Click += new System.EventHandler(this.btnFajlba_Click);
            // 
            // tlp1
            // 
            resources.ApplyResources(this.tlp1, "tlp1");
            this.tlp1.Controls.Add(this.dgvTabla, 1, 5);
            this.tlp1.Controls.Add(this.btnFajlba, 3, 1);
            this.tlp1.Controls.Add(this.btnAdatok, 1, 1);
            this.tlp1.Controls.Add(this.btnTorles, 5, 1);
            this.tlp1.Controls.Add(this.btnMentes, 5, 3);
            this.tlp1.Controls.Add(this.dtpDatum, 4, 3);
            this.tlp1.Controls.Add(this.cbKategoria, 3, 3);
            this.tlp1.Controls.Add(this.tbOsszeg, 2, 3);
            this.tlp1.Controls.Add(this.tbMegnevezes, 1, 3);
            this.tlp1.Name = "tlp1";
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Megnevezes,
            this.Osszeg,
            this.Tipus,
            this.Datum,
            this.Opciok});
            this.tlp1.SetColumnSpan(this.dgvTabla, 5);
            resources.ApplyResources(this.dgvTabla, "dgvTabla");
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.tlp1.SetRowSpan(this.dgvTabla, 2);
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellContentClick);
            this.dgvTabla.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTabla_CellFormatting);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.FillWeight = 50F;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Megnevezes
            // 
            this.Megnevezes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Megnevezes, "Megnevezes");
            this.Megnevezes.Name = "Megnevezes";
            this.Megnevezes.ReadOnly = true;
            // 
            // Osszeg
            // 
            this.Osszeg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Osszeg.FillWeight = 70F;
            resources.ApplyResources(this.Osszeg, "Osszeg");
            this.Osszeg.Name = "Osszeg";
            this.Osszeg.ReadOnly = true;
            // 
            // Tipus
            // 
            this.Tipus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Tipus, "Tipus");
            this.Tipus.Name = "Tipus";
            this.Tipus.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.FillWeight = 70F;
            resources.ApplyResources(this.Datum, "Datum");
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Opciok
            // 
            this.Opciok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opciok.FillWeight = 70F;
            resources.ApplyResources(this.Opciok, "Opciok");
            this.Opciok.Name = "Opciok";
            this.Opciok.ReadOnly = true;
            this.Opciok.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Opciok.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cbKategoria
            // 
            resources.ApplyResources(this.cbKategoria, "cbKategoria");
            this.cbKategoria.FormattingEnabled = true;
            this.cbKategoria.Name = "cbKategoria";
            // 
            // Koltsegfigyelo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.tlp1);
            this.Name = "Koltsegfigyelo";
            this.tlp1.ResumeLayout(false);
            this.tlp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbMegnevezes;
        private System.Windows.Forms.TextBox tbOsszeg;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnAdatok;
        private System.Windows.Forms.Button btnFajlba;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        public System.Windows.Forms.ComboBox cbKategoria;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Megnevezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewButtonColumn Opciok;
    }
}

