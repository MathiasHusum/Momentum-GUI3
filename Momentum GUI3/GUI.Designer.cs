namespace Momentum_GUI3
{
    partial class GUI
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
            this.medlemmer = new System.Windows.Forms.Button();
            this.vis_medlemmer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.by = new System.Windows.Forms.TextBox();
            this.postnr = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.efternavn = new System.Windows.Forms.TextBox();
            this.tlf_nr = new System.Windows.Forms.TextBox();
            this.korttype = new System.Windows.Forms.TextBox();
            this.accepter = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.email = new System.Windows.Forms.TextBox();
            this.tilbage_tilføj = new System.Windows.Forms.Button();
            this.fornavn = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fornavncolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efternavnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fødselsdatoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnummerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlf_nrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.købtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indløstColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.udløbsdatoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.årskorttypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gentegningColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.andetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tilbage_vis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // medlemmer
            // 
            this.medlemmer.Location = new System.Drawing.Point(207, 312);
            this.medlemmer.Name = "medlemmer";
            this.medlemmer.Size = new System.Drawing.Size(150, 75);
            this.medlemmer.TabIndex = 0;
            this.medlemmer.Text = "Tilføj Medlemmer";
            this.medlemmer.UseVisualStyleBackColor = true;
            this.medlemmer.Click += new System.EventHandler(this.button1_Click);
            // 
            // vis_medlemmer
            // 
            this.vis_medlemmer.Location = new System.Drawing.Point(545, 311);
            this.vis_medlemmer.Name = "vis_medlemmer";
            this.vis_medlemmer.Size = new System.Drawing.Size(150, 75);
            this.vis_medlemmer.TabIndex = 1;
            this.vis_medlemmer.Text = "Vis Medlemmer";
            this.vis_medlemmer.UseVisualStyleBackColor = true;
            this.vis_medlemmer.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.by);
            this.panel1.Controls.Add(this.postnr);
            this.panel1.Controls.Add(this.adresse);
            this.panel1.Controls.Add(this.efternavn);
            this.panel1.Controls.Add(this.tlf_nr);
            this.panel1.Controls.Add(this.korttype);
            this.panel1.Controls.Add(this.accepter);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.tilbage_tilføj);
            this.panel1.Controls.Add(this.fornavn);
            this.panel1.Location = new System.Drawing.Point(18, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 604);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // by
            // 
            this.by.Location = new System.Drawing.Point(150, 214);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(310, 20);
            this.by.TabIndex = 4;
            this.by.Text = "By";
            // 
            // postnr
            // 
            this.postnr.Location = new System.Drawing.Point(150, 171);
            this.postnr.Name = "postnr";
            this.postnr.Size = new System.Drawing.Size(310, 20);
            this.postnr.TabIndex = 3;
            this.postnr.Text = "Post nr.";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(150, 133);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(310, 20);
            this.adresse.TabIndex = 2;
            this.adresse.Text = "Adresse";
            // 
            // efternavn
            // 
            this.efternavn.Location = new System.Drawing.Point(150, 97);
            this.efternavn.Name = "efternavn";
            this.efternavn.Size = new System.Drawing.Size(310, 20);
            this.efternavn.TabIndex = 1;
            this.efternavn.Text = "Efternavn";
            // 
            // tlf_nr
            // 
            this.tlf_nr.Location = new System.Drawing.Point(150, 389);
            this.tlf_nr.Name = "tlf_nr";
            this.tlf_nr.Size = new System.Drawing.Size(310, 20);
            this.tlf_nr.TabIndex = 8;
            this.tlf_nr.Text = "Telefonnummer";
            // 
            // korttype
            // 
            this.korttype.Location = new System.Drawing.Point(150, 352);
            this.korttype.Name = "korttype";
            this.korttype.Size = new System.Drawing.Size(310, 20);
            this.korttype.TabIndex = 7;
            this.korttype.Text = "Korttype";
            // 
            // accepter
            // 
            this.accepter.Location = new System.Drawing.Point(330, 503);
            this.accepter.Name = "accepter";
            this.accepter.Size = new System.Drawing.Size(130, 70);
            this.accepter.TabIndex = 8;
            this.accepter.Text = "Accepter";
            this.accepter.UseVisualStyleBackColor = true;
            this.accepter.Click += new System.EventHandler(this.accepter_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 310);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(150, 254);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(310, 20);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // tilbage_tilføj
            // 
            this.tilbage_tilføj.Location = new System.Drawing.Point(150, 503);
            this.tilbage_tilføj.Name = "tilbage_tilføj";
            this.tilbage_tilføj.Size = new System.Drawing.Size(130, 70);
            this.tilbage_tilføj.TabIndex = 99;
            this.tilbage_tilføj.Text = "Tilbage";
            this.tilbage_tilføj.UseVisualStyleBackColor = true;
            this.tilbage_tilføj.Click += new System.EventHandler(this.tilbage_tilføj_Click);
            // 
            // fornavn
            // 
            this.fornavn.Location = new System.Drawing.Point(150, 58);
            this.fornavn.Name = "fornavn";
            this.fornavn.Size = new System.Drawing.Size(310, 20);
            this.fornavn.TabIndex = 0;
            this.fornavn.Text = "Fornavn";
            this.fornavn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.tilbage_vis);
            this.panel2.Location = new System.Drawing.Point(12, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 727);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fornavncolumn,
            this.efternavnColumn,
            this.mailColumn,
            this.fødselsdatoColumn,
            this.postnummerColumn,
            this.tlf_nrColumn,
            this.købtColumn,
            this.indløstColumn,
            this.udløbsdatoColumn,
            this.årskorttypeColumn,
            this.gentegningColumn,
            this.andetColumn});
            this.dataGridView1.Location = new System.Drawing.Point(4, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1254, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // fornavncolumn
            // 
            this.fornavncolumn.HeaderText = "Fornavn";
            this.fornavncolumn.Name = "fornavncolumn";
            this.fornavncolumn.ReadOnly = true;
            // 
            // efternavnColumn
            // 
            this.efternavnColumn.HeaderText = "Efternavn";
            this.efternavnColumn.Name = "efternavnColumn";
            this.efternavnColumn.ReadOnly = true;
            // 
            // mailColumn
            // 
            this.mailColumn.HeaderText = "Mail";
            this.mailColumn.Name = "mailColumn";
            this.mailColumn.ReadOnly = true;
            // 
            // fødselsdatoColumn
            // 
            this.fødselsdatoColumn.HeaderText = "Fødselsdato";
            this.fødselsdatoColumn.Name = "fødselsdatoColumn";
            this.fødselsdatoColumn.ReadOnly = true;
            // 
            // postnummerColumn
            // 
            this.postnummerColumn.HeaderText = "Postnummer";
            this.postnummerColumn.Name = "postnummerColumn";
            this.postnummerColumn.ReadOnly = true;
            // 
            // tlf_nrColumn
            // 
            this.tlf_nrColumn.HeaderText = "Tlf Nr.";
            this.tlf_nrColumn.Name = "tlf_nrColumn";
            this.tlf_nrColumn.ReadOnly = true;
            // 
            // købtColumn
            // 
            this.købtColumn.HeaderText = "Købt";
            this.købtColumn.Name = "købtColumn";
            this.købtColumn.ReadOnly = true;
            // 
            // indløstColumn
            // 
            this.indløstColumn.HeaderText = "Indløst";
            this.indløstColumn.Name = "indløstColumn";
            this.indløstColumn.ReadOnly = true;
            // 
            // udløbsdatoColumn
            // 
            this.udløbsdatoColumn.HeaderText = "Udløbsdato";
            this.udløbsdatoColumn.Name = "udløbsdatoColumn";
            this.udløbsdatoColumn.ReadOnly = true;
            // 
            // årskorttypeColumn
            // 
            this.årskorttypeColumn.HeaderText = "Årskorttype";
            this.årskorttypeColumn.Name = "årskorttypeColumn";
            this.årskorttypeColumn.ReadOnly = true;
            // 
            // gentegningColumn
            // 
            this.gentegningColumn.HeaderText = "Gentegning";
            this.gentegningColumn.Name = "gentegningColumn";
            this.gentegningColumn.ReadOnly = true;
            // 
            // andetColumn
            // 
            this.andetColumn.HeaderText = "Andet";
            this.andetColumn.Name = "andetColumn";
            this.andetColumn.ReadOnly = true;
            // 
            // tilbage_vis
            // 
            this.tilbage_vis.Location = new System.Drawing.Point(0, 466);
            this.tilbage_vis.Name = "tilbage_vis";
            this.tilbage_vis.Size = new System.Drawing.Size(130, 70);
            this.tilbage_vis.TabIndex = 1;
            this.tilbage_vis.Text = "Tilbage";
            this.tilbage_vis.UseVisualStyleBackColor = true;
            this.tilbage_vis.Click += new System.EventHandler(this.tilbage_vis_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.vis_medlemmer);
            this.Controls.Add(this.medlemmer);
            this.Name = "GUI";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button medlemmer;
        private System.Windows.Forms.Button vis_medlemmer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox fornavn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tilbage_tilføj;
        private System.Windows.Forms.Button tilbage_vis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox efternavn;
        private System.Windows.Forms.TextBox tlf_nr;
        private System.Windows.Forms.TextBox korttype;
        private System.Windows.Forms.Button accepter;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox by;
        private System.Windows.Forms.TextBox postnr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornavncolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternavnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fødselsdatoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnummerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlf_nrColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn købtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indløstColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn udløbsdatoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn årskorttypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gentegningColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn andetColumn;
    }
}

