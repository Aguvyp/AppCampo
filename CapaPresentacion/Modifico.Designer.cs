namespace CapaPresentacion
{
    partial class Modifico
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblprueba = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtHembra = new System.Windows.Forms.RadioButton();
            this.rbtMacho = new System.Windows.Forms.RadioButton();
            this.txtVacunas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtInseSi = new System.Windows.Forms.RadioButton();
            this.rbtInseNo = new System.Windows.Forms.RadioButton();
            this.gbxPreña = new System.Windows.Forms.GroupBox();
            this.rbtPreSi = new System.Windows.Forms.RadioButton();
            this.rbtPreNo = new System.Windows.Forms.RadioButton();
            this.gbxCapado = new System.Windows.Forms.GroupBox();
            this.rbtCapSi = new System.Windows.Forms.RadioButton();
            this.rbtCapNo = new System.Windows.Forms.RadioButton();
            this.gbxDestete = new System.Windows.Forms.GroupBox();
            this.rbtDesSi = new System.Windows.Forms.RadioButton();
            this.rbtDesNo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxDiente = new System.Windows.Forms.GroupBox();
            this.rbtBien = new System.Windows.Forms.RadioButton();
            this.rbtPoco = new System.Windows.Forms.RadioButton();
            this.rbtNada = new System.Windows.Forms.RadioButton();
            this.gbxSangrado = new System.Windows.Forms.GroupBox();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtSi = new System.Windows.Forms.RadioButton();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbxSexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxPreña.SuspendLayout();
            this.gbxCapado.SuspendLayout();
            this.gbxDestete.SuspendLayout();
            this.gbxDiente.SuspendLayout();
            this.gbxSangrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(857, 452);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(195, 60);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "DOBLE CLICK EN EL ANIMAL A MODIFICAR";
            // 
            // gridDatos
            // 
            this.gridDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Location = new System.Drawing.Point(12, 36);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.RowTemplate.Height = 25;
            this.gridDatos.Size = new System.Drawing.Size(1041, 146);
            this.gridDatos.StandardTab = true;
            this.gridDatos.TabIndex = 45;
            this.gridDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDatos_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblprueba);
            this.groupBox2.Controls.Add(this.txtRaza);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.gbxSexo);
            this.groupBox2.Controls.Add(this.txtVacunas);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.gbxPreña);
            this.groupBox2.Controls.Add(this.gbxCapado);
            this.groupBox2.Controls.Add(this.gbxDestete);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.gbxDiente);
            this.groupBox2.Controls.Add(this.gbxSangrado);
            this.groupBox2.Controls.Add(this.txtOrigen);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(972, 238);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS A MODIFICAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(32, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "A MODIFICAR";
            // 
            // lblprueba
            // 
            this.lblprueba.AutoSize = true;
            this.lblprueba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblprueba.Location = new System.Drawing.Point(122, 39);
            this.lblprueba.Name = "lblprueba";
            this.lblprueba.Size = new System.Drawing.Size(2, 17);
            this.lblprueba.TabIndex = 41;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(31, 173);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRaza.Multiline = true;
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(176, 29);
            this.txtRaza.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(32, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "RAZA";
            // 
            // gbxSexo
            // 
            this.gbxSexo.BackColor = System.Drawing.Color.LightGray;
            this.gbxSexo.Controls.Add(this.rbtHembra);
            this.gbxSexo.Controls.Add(this.rbtMacho);
            this.gbxSexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxSexo.Location = new System.Drawing.Point(466, 151);
            this.gbxSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxSexo.Size = new System.Drawing.Size(141, 81);
            this.gbxSexo.TabIndex = 38;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "SEXO";
            // 
            // rbtHembra
            // 
            this.rbtHembra.AutoSize = true;
            this.rbtHembra.Location = new System.Drawing.Point(23, 22);
            this.rbtHembra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtHembra.Name = "rbtHembra";
            this.rbtHembra.Size = new System.Drawing.Size(73, 19);
            this.rbtHembra.TabIndex = 1;
            this.rbtHembra.TabStop = true;
            this.rbtHembra.Text = "HEMBRA";
            this.rbtHembra.UseVisualStyleBackColor = true;
            // 
            // rbtMacho
            // 
            this.rbtMacho.AutoSize = true;
            this.rbtMacho.Location = new System.Drawing.Point(23, 48);
            this.rbtMacho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtMacho.Name = "rbtMacho";
            this.rbtMacho.Size = new System.Drawing.Size(70, 19);
            this.rbtMacho.TabIndex = 0;
            this.rbtMacho.TabStop = true;
            this.rbtMacho.Text = "MACHO";
            this.rbtMacho.UseVisualStyleBackColor = true;
            // 
            // txtVacunas
            // 
            this.txtVacunas.Location = new System.Drawing.Point(631, 156);
            this.txtVacunas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVacunas.Multiline = true;
            this.txtVacunas.Name = "txtVacunas";
            this.txtVacunas.Size = new System.Drawing.Size(146, 70);
            this.txtVacunas.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.rbtInseSi);
            this.groupBox1.Controls.Add(this.rbtInseNo);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(799, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(146, 81);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INSEMINACION?";
            // 
            // rbtInseSi
            // 
            this.rbtInseSi.AutoSize = true;
            this.rbtInseSi.Location = new System.Drawing.Point(22, 22);
            this.rbtInseSi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtInseSi.Name = "rbtInseSi";
            this.rbtInseSi.Size = new System.Drawing.Size(34, 19);
            this.rbtInseSi.TabIndex = 1;
            this.rbtInseSi.TabStop = true;
            this.rbtInseSi.Text = "SI";
            this.rbtInseSi.UseVisualStyleBackColor = true;
            // 
            // rbtInseNo
            // 
            this.rbtInseNo.AutoSize = true;
            this.rbtInseNo.Location = new System.Drawing.Point(22, 48);
            this.rbtInseNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtInseNo.Name = "rbtInseNo";
            this.rbtInseNo.Size = new System.Drawing.Size(43, 19);
            this.rbtInseNo.TabIndex = 0;
            this.rbtInseNo.TabStop = true;
            this.rbtInseNo.Text = "NO";
            this.rbtInseNo.UseVisualStyleBackColor = true;
            // 
            // gbxPreña
            // 
            this.gbxPreña.BackColor = System.Drawing.Color.LightGray;
            this.gbxPreña.Controls.Add(this.rbtPreSi);
            this.gbxPreña.Controls.Add(this.rbtPreNo);
            this.gbxPreña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxPreña.Location = new System.Drawing.Point(799, 145);
            this.gbxPreña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPreña.Name = "gbxPreña";
            this.gbxPreña.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPreña.Size = new System.Drawing.Size(146, 81);
            this.gbxPreña.TabIndex = 30;
            this.gbxPreña.TabStop = false;
            this.gbxPreña.Text = "PREÑADA";
            // 
            // rbtPreSi
            // 
            this.rbtPreSi.AutoSize = true;
            this.rbtPreSi.Location = new System.Drawing.Point(22, 22);
            this.rbtPreSi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtPreSi.Name = "rbtPreSi";
            this.rbtPreSi.Size = new System.Drawing.Size(34, 19);
            this.rbtPreSi.TabIndex = 1;
            this.rbtPreSi.TabStop = true;
            this.rbtPreSi.Text = "SI";
            this.rbtPreSi.UseVisualStyleBackColor = true;
            // 
            // rbtPreNo
            // 
            this.rbtPreNo.AutoSize = true;
            this.rbtPreNo.Location = new System.Drawing.Point(22, 48);
            this.rbtPreNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtPreNo.Name = "rbtPreNo";
            this.rbtPreNo.Size = new System.Drawing.Size(43, 19);
            this.rbtPreNo.TabIndex = 0;
            this.rbtPreNo.TabStop = true;
            this.rbtPreNo.Text = "NO";
            this.rbtPreNo.UseVisualStyleBackColor = true;
            // 
            // gbxCapado
            // 
            this.gbxCapado.BackColor = System.Drawing.Color.LightGray;
            this.gbxCapado.Controls.Add(this.rbtCapSi);
            this.gbxCapado.Controls.Add(this.rbtCapNo);
            this.gbxCapado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxCapado.Location = new System.Drawing.Point(631, 39);
            this.gbxCapado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCapado.Name = "gbxCapado";
            this.gbxCapado.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCapado.Size = new System.Drawing.Size(146, 81);
            this.gbxCapado.TabIndex = 31;
            this.gbxCapado.TabStop = false;
            this.gbxCapado.Text = "CAPADO";
            // 
            // rbtCapSi
            // 
            this.rbtCapSi.AutoSize = true;
            this.rbtCapSi.Location = new System.Drawing.Point(22, 22);
            this.rbtCapSi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtCapSi.Name = "rbtCapSi";
            this.rbtCapSi.Size = new System.Drawing.Size(34, 19);
            this.rbtCapSi.TabIndex = 1;
            this.rbtCapSi.TabStop = true;
            this.rbtCapSi.Text = "SI";
            this.rbtCapSi.UseVisualStyleBackColor = true;
            // 
            // rbtCapNo
            // 
            this.rbtCapNo.AutoSize = true;
            this.rbtCapNo.Location = new System.Drawing.Point(22, 48);
            this.rbtCapNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtCapNo.Name = "rbtCapNo";
            this.rbtCapNo.Size = new System.Drawing.Size(43, 19);
            this.rbtCapNo.TabIndex = 0;
            this.rbtCapNo.TabStop = true;
            this.rbtCapNo.Text = "NO";
            this.rbtCapNo.UseVisualStyleBackColor = true;
            // 
            // gbxDestete
            // 
            this.gbxDestete.BackColor = System.Drawing.Color.LightGray;
            this.gbxDestete.Controls.Add(this.rbtDesSi);
            this.gbxDestete.Controls.Add(this.rbtDesNo);
            this.gbxDestete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxDestete.Location = new System.Drawing.Point(461, 39);
            this.gbxDestete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxDestete.Name = "gbxDestete";
            this.gbxDestete.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxDestete.Size = new System.Drawing.Size(146, 81);
            this.gbxDestete.TabIndex = 28;
            this.gbxDestete.TabStop = false;
            this.gbxDestete.Text = "DESTETADO";
            // 
            // rbtDesSi
            // 
            this.rbtDesSi.AutoSize = true;
            this.rbtDesSi.Location = new System.Drawing.Point(22, 22);
            this.rbtDesSi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtDesSi.Name = "rbtDesSi";
            this.rbtDesSi.Size = new System.Drawing.Size(34, 19);
            this.rbtDesSi.TabIndex = 1;
            this.rbtDesSi.TabStop = true;
            this.rbtDesSi.Text = "SI";
            this.rbtDesSi.UseVisualStyleBackColor = true;
            // 
            // rbtDesNo
            // 
            this.rbtDesNo.AutoSize = true;
            this.rbtDesNo.Location = new System.Drawing.Point(22, 48);
            this.rbtDesNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtDesNo.Name = "rbtDesNo";
            this.rbtDesNo.Size = new System.Drawing.Size(43, 19);
            this.rbtDesNo.TabIndex = 0;
            this.rbtDesNo.TabStop = true;
            this.rbtDesNo.Text = "NO";
            this.rbtDesNo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cornsilk;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(651, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "VACUNAS APLICADAS";
            // 
            // gbxDiente
            // 
            this.gbxDiente.BackColor = System.Drawing.Color.LightGray;
            this.gbxDiente.Controls.Add(this.rbtBien);
            this.gbxDiente.Controls.Add(this.rbtPoco);
            this.gbxDiente.Controls.Add(this.rbtNada);
            this.gbxDiente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxDiente.Location = new System.Drawing.Point(273, 36);
            this.gbxDiente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxDiente.Name = "gbxDiente";
            this.gbxDiente.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxDiente.Size = new System.Drawing.Size(180, 84);
            this.gbxDiente.TabIndex = 32;
            this.gbxDiente.TabStop = false;
            this.gbxDiente.Text = "DIENTES";
            // 
            // rbtBien
            // 
            this.rbtBien.AutoSize = true;
            this.rbtBien.Location = new System.Drawing.Point(16, 51);
            this.rbtBien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtBien.Name = "rbtBien";
            this.rbtBien.Size = new System.Drawing.Size(50, 19);
            this.rbtBien.TabIndex = 2;
            this.rbtBien.TabStop = true;
            this.rbtBien.Text = "BIEN";
            this.rbtBien.UseVisualStyleBackColor = true;
            // 
            // rbtPoco
            // 
            this.rbtPoco.AutoSize = true;
            this.rbtPoco.Location = new System.Drawing.Point(16, 25);
            this.rbtPoco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtPoco.Name = "rbtPoco";
            this.rbtPoco.Size = new System.Drawing.Size(58, 19);
            this.rbtPoco.TabIndex = 1;
            this.rbtPoco.TabStop = true;
            this.rbtPoco.Text = "POCO";
            this.rbtPoco.UseVisualStyleBackColor = true;
            // 
            // rbtNada
            // 
            this.rbtNada.AutoSize = true;
            this.rbtNada.Location = new System.Drawing.Point(115, 25);
            this.rbtNada.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtNada.Name = "rbtNada";
            this.rbtNada.Size = new System.Drawing.Size(58, 19);
            this.rbtNada.TabIndex = 0;
            this.rbtNada.TabStop = true;
            this.rbtNada.Text = "NADA";
            this.rbtNada.UseVisualStyleBackColor = true;
            // 
            // gbxSangrado
            // 
            this.gbxSangrado.BackColor = System.Drawing.Color.LightGray;
            this.gbxSangrado.Controls.Add(this.rbtNo);
            this.gbxSangrado.Controls.Add(this.rbtSi);
            this.gbxSangrado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxSangrado.Location = new System.Drawing.Point(321, 151);
            this.gbxSangrado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxSangrado.Name = "gbxSangrado";
            this.gbxSangrado.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxSangrado.Size = new System.Drawing.Size(132, 70);
            this.gbxSangrado.TabIndex = 29;
            this.gbxSangrado.TabStop = false;
            this.gbxSangrado.Text = "SANGRADO";
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.Location = new System.Drawing.Point(22, 48);
            this.rbtNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(43, 19);
            this.rbtNo.TabIndex = 1;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "NO";
            this.rbtNo.UseVisualStyleBackColor = true;
            // 
            // rbtSi
            // 
            this.rbtSi.AutoSize = true;
            this.rbtSi.Location = new System.Drawing.Point(22, 22);
            this.rbtSi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtSi.Name = "rbtSi";
            this.rbtSi.Size = new System.Drawing.Size(34, 19);
            this.rbtSi.TabIndex = 0;
            this.rbtSi.TabStop = true;
            this.rbtSi.Text = "SI";
            this.rbtSi.UseVisualStyleBackColor = true;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(31, 101);
            this.txtOrigen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOrigen.Multiline = true;
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(165, 33);
            this.txtOrigen.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(32, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "ORIGEN";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Orange;
            this.btnModificar.Location = new System.Drawing.Point(622, 452);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(195, 60);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Modifico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 524);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnModificar);
            this.Name = "Modifico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifico";
            this.Load += new System.EventHandler(this.Modifico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxPreña.ResumeLayout(false);
            this.gbxPreña.PerformLayout();
            this.gbxCapado.ResumeLayout(false);
            this.gbxCapado.PerformLayout();
            this.gbxDestete.ResumeLayout(false);
            this.gbxDestete.PerformLayout();
            this.gbxDiente.ResumeLayout(false);
            this.gbxDiente.PerformLayout();
            this.gbxSangrado.ResumeLayout(false);
            this.gbxSangrado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalir;
        private Label label1;
        private DataGridView gridDatos;
        private GroupBox groupBox2;
        private Label label2;
        private Label lblprueba;
        private TextBox txtRaza;
        private Label label3;
        private GroupBox gbxSexo;
        private RadioButton rbtHembra;
        private RadioButton rbtMacho;
        private TextBox txtVacunas;
        private GroupBox groupBox1;
        private RadioButton rbtInseSi;
        private RadioButton rbtInseNo;
        private GroupBox gbxPreña;
        private RadioButton rbtPreSi;
        private RadioButton rbtPreNo;
        private GroupBox gbxCapado;
        private RadioButton rbtCapSi;
        private RadioButton rbtCapNo;
        private GroupBox gbxDestete;
        private RadioButton rbtDesSi;
        private RadioButton rbtDesNo;
        private Label label5;
        private GroupBox gbxDiente;
        private RadioButton rbtBien;
        private RadioButton rbtPoco;
        private RadioButton rbtNada;
        private GroupBox gbxSangrado;
        private RadioButton rbtNo;
        private RadioButton rbtSi;
        private TextBox txtOrigen;
        private Label label4;
        private Button btnModificar;
    }
}