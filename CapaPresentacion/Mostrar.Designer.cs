namespace CapaPresentacion
{
    partial class Mostrar
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
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxOpciones = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.chbSi = new System.Windows.Forms.CheckBox();
            this.chbNo = new System.Windows.Forms.CheckBox();
            this.chbMacho = new System.Windows.Forms.CheckBox();
            this.chbHembra = new System.Windows.Forms.CheckBox();
            this.chbBien = new System.Windows.Forms.CheckBox();
            this.chbPoco = new System.Windows.Forms.CheckBox();
            this.chbNada = new System.Windows.Forms.CheckBox();
            this.txtCarav = new System.Windows.Forms.TextBox();
            this.txtOri = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtVacunas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDatos
            // 
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Location = new System.Drawing.Point(11, 107);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.RowTemplate.Height = 25;
            this.gridDatos.Size = new System.Drawing.Size(855, 333);
            this.gridDatos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "TABLA DE ANIMALES REGISTRADOS";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir.Location = new System.Drawing.Point(709, 446);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(157, 41);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "FILTRAR POR:";
            this.label2.Visible = false;
            // 
            // cbxOpciones
            // 
            this.cbxOpciones.FormattingEnabled = true;
            this.cbxOpciones.Items.AddRange(new object[] {
            "Caravana",
            "Origen",
            "Raza",
            "Destetado",
            "Sexo",
            "Sangrado",
            "Inseminacion",
            "Preñada",
            "Vacunas",
            "Capado",
            "Dientes"});
            this.cbxOpciones.Location = new System.Drawing.Point(139, 49);
            this.cbxOpciones.Name = "cbxOpciones";
            this.cbxOpciones.Size = new System.Drawing.Size(168, 23);
            this.cbxOpciones.TabIndex = 4;
            this.cbxOpciones.Visible = false;
            
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Khaki;
            this.btnFiltrar.Location = new System.Drawing.Point(690, 39);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(157, 41);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Visible = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chbSi
            // 
            this.chbSi.AutoSize = true;
            this.chbSi.Location = new System.Drawing.Point(379, 53);
            this.chbSi.Name = "chbSi";
            this.chbSi.Size = new System.Drawing.Size(35, 19);
            this.chbSi.TabIndex = 6;
            this.chbSi.Text = "SI";
            this.chbSi.UseVisualStyleBackColor = true;
            this.chbSi.Visible = false;
            // 
            // chbNo
            // 
            this.chbNo.AutoSize = true;
            this.chbNo.Location = new System.Drawing.Point(481, 53);
            this.chbNo.Name = "chbNo";
            this.chbNo.Size = new System.Drawing.Size(44, 19);
            this.chbNo.TabIndex = 7;
            this.chbNo.Text = "NO";
            this.chbNo.UseVisualStyleBackColor = true;
            this.chbNo.Visible = false;
            // 
            // chbMacho
            // 
            this.chbMacho.AutoSize = true;
            this.chbMacho.Location = new System.Drawing.Point(379, 53);
            this.chbMacho.Name = "chbMacho";
            this.chbMacho.Size = new System.Drawing.Size(71, 19);
            this.chbMacho.TabIndex = 8;
            this.chbMacho.Text = "MACHO";
            this.chbMacho.UseVisualStyleBackColor = true;
            this.chbMacho.Visible = false;
            // 
            // chbHembra
            // 
            this.chbHembra.AutoSize = true;
            this.chbHembra.Location = new System.Drawing.Point(481, 53);
            this.chbHembra.Name = "chbHembra";
            this.chbHembra.Size = new System.Drawing.Size(74, 19);
            this.chbHembra.TabIndex = 9;
            this.chbHembra.Text = "HEMBRA";
            this.chbHembra.UseVisualStyleBackColor = true;
            this.chbHembra.Visible = false;
            // 
            // chbBien
            // 
            this.chbBien.AutoSize = true;
            this.chbBien.Location = new System.Drawing.Point(379, 53);
            this.chbBien.Name = "chbBien";
            this.chbBien.Size = new System.Drawing.Size(51, 19);
            this.chbBien.TabIndex = 10;
            this.chbBien.Text = "BIEN";
            this.chbBien.UseVisualStyleBackColor = true;
            this.chbBien.Visible = false;
            this.chbBien.CheckedChanged += new System.EventHandler(this.chbBien_CheckedChanged);
            // 
            // chbPoco
            // 
            this.chbPoco.AutoSize = true;
            this.chbPoco.Location = new System.Drawing.Point(481, 53);
            this.chbPoco.Name = "chbPoco";
            this.chbPoco.Size = new System.Drawing.Size(59, 19);
            this.chbPoco.TabIndex = 11;
            this.chbPoco.Text = "POCO";
            this.chbPoco.UseVisualStyleBackColor = true;
            this.chbPoco.Visible = false;
            // 
            // chbNada
            // 
            this.chbNada.AutoSize = true;
            this.chbNada.Location = new System.Drawing.Point(590, 53);
            this.chbNada.Name = "chbNada";
            this.chbNada.Size = new System.Drawing.Size(59, 19);
            this.chbNada.TabIndex = 12;
            this.chbNada.Text = "NADA";
            this.chbNada.UseVisualStyleBackColor = true;
            this.chbNada.Visible = false;
            // 
            // txtCarav
            // 
            this.txtCarav.Location = new System.Drawing.Point(372, 47);
            this.txtCarav.Name = "txtCarav";
            this.txtCarav.Size = new System.Drawing.Size(275, 23);
            this.txtCarav.TabIndex = 13;
            this.txtCarav.Visible = false;
            // 
            // txtOri
            // 
            this.txtOri.Location = new System.Drawing.Point(372, 47);
            this.txtOri.Name = "txtOri";
            this.txtOri.Size = new System.Drawing.Size(275, 23);
            this.txtOri.TabIndex = 14;
            this.txtOri.Visible = false;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(372, 47);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(275, 23);
            this.txtRaza.TabIndex = 15;
            this.txtRaza.Visible = false;
            // 
            // txtVacunas
            // 
            this.txtVacunas.Location = new System.Drawing.Point(372, 47);
            this.txtVacunas.Name = "txtVacunas";
            this.txtVacunas.Size = new System.Drawing.Size(275, 23);
            this.txtVacunas.TabIndex = 16;
            this.txtVacunas.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = ".";
            // 
            // Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 499);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVacunas);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtOri);
            this.Controls.Add(this.txtCarav);
            this.Controls.Add(this.chbNada);
            this.Controls.Add(this.chbPoco);
            this.Controls.Add(this.chbBien);
            this.Controls.Add(this.chbHembra);
            this.Controls.Add(this.chbMacho);
            this.Controls.Add(this.chbNo);
            this.Controls.Add(this.chbSi);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cbxOpciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridDatos);
            this.Name = "Mostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.Mostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridDatos;
        private Label label1;
        private Button btnSalir;
        private Label label2;
        private ComboBox cbxOpciones;
        private Button btnFiltrar;
        private CheckBox chbSi;
        private CheckBox chbNo;
        private CheckBox chbMacho;
        private CheckBox chbHembra;
        private CheckBox chbBien;
        private CheckBox chbPoco;
        private CheckBox chbNada;
        private TextBox txtCarav;
        private TextBox txtOri;
        private TextBox txtRaza;
        private TextBox txtVacunas;
        private Label label3;
        private Label label4;
    }
}