﻿namespace MetaComissions
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tbMenu = new System.Windows.Forms.TabControl();
            this.tbPutClie = new System.Windows.Forms.TabPage();
            this.btnBuscarFile = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chComi = new System.Windows.Forms.CheckBox();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtRefer = new System.Windows.Forms.TextBox();
            this.txtArti = new System.Windows.Forms.TextBox();
            this.txtIden = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.txtNomClie = new System.Windows.Forms.TextBox();
            this.lblComi = new System.Windows.Forms.Label();
            this.lblRefer = new System.Windows.Forms.Label();
            this.lblArti = new System.Windows.Forms.Label();
            this.lblIden = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelef = new System.Windows.Forms.Label();
            this.lblNomClie = new System.Windows.Forms.Label();
            this.gbDatosGen = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGetClie = new System.Windows.Forms.TabPage();
            this.btnDeleteGrid = new System.Windows.Forms.Button();
            this.btnSaveGrid = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbFilComi = new System.Windows.Forms.CheckBox();
            this.txtFilRefer = new System.Windows.Forms.TextBox();
            this.txtFilArtiVendi = new System.Windows.Forms.TextBox();
            this.txtFilIden = new System.Windows.Forms.TextBox();
            this.txtFilCorreo = new System.Windows.Forms.TextBox();
            this.txtFilTelef = new System.Windows.Forms.TextBox();
            this.txtFilNomClie = new System.Windows.Forms.TextBox();
            this.lblFilComi = new System.Windows.Forms.Label();
            this.lblFilRefer = new System.Windows.Forms.Label();
            this.lblArtiVendi = new System.Windows.Forms.Label();
            this.lblFilIden = new System.Windows.Forms.Label();
            this.lblFilCorreo = new System.Windows.Forms.Label();
            this.lblFilTelef = new System.Windows.Forms.Label();
            this.lblFilNomClie = new System.Windows.Forms.Label();
            this.tbReport = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbDtSql = new System.Windows.Forms.TabPage();
            this.btnRegristar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDataBase = new System.Windows.Forms.Label();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.tbMenu.SuspendLayout();
            this.tbPutClie.SuspendLayout();
            this.gbDatosGen.SuspendLayout();
            this.tbGetClie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbReport.SuspendLayout();
            this.tbDtSql.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tbPutClie);
            this.tbMenu.Controls.Add(this.tbGetClie);
            this.tbMenu.Controls.Add(this.tbReport);
            this.tbMenu.Controls.Add(this.tbDtSql);
            this.tbMenu.Location = new System.Drawing.Point(13, 25);
            this.tbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(906, 595);
            this.tbMenu.TabIndex = 0;
            // 
            // tbPutClie
            // 
            this.tbPutClie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPutClie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPutClie.Controls.Add(this.btnBuscarFile);
            this.tbPutClie.Controls.Add(this.progressBar1);
            this.tbPutClie.Controls.Add(this.chComi);
            this.tbPutClie.Controls.Add(this.lblMsgError);
            this.tbPutClie.Controls.Add(this.btnGuardar);
            this.tbPutClie.Controls.Add(this.btnClean);
            this.tbPutClie.Controls.Add(this.txtRefer);
            this.tbPutClie.Controls.Add(this.txtArti);
            this.tbPutClie.Controls.Add(this.txtIden);
            this.tbPutClie.Controls.Add(this.txtCorreo);
            this.tbPutClie.Controls.Add(this.txtTelef);
            this.tbPutClie.Controls.Add(this.txtNomClie);
            this.tbPutClie.Controls.Add(this.lblComi);
            this.tbPutClie.Controls.Add(this.lblRefer);
            this.tbPutClie.Controls.Add(this.lblArti);
            this.tbPutClie.Controls.Add(this.lblIden);
            this.tbPutClie.Controls.Add(this.lblCorreo);
            this.tbPutClie.Controls.Add(this.lblTelef);
            this.tbPutClie.Controls.Add(this.lblNomClie);
            this.tbPutClie.Controls.Add(this.gbDatosGen);
            this.tbPutClie.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPutClie.ForeColor = System.Drawing.Color.Transparent;
            this.tbPutClie.Location = new System.Drawing.Point(4, 25);
            this.tbPutClie.Margin = new System.Windows.Forms.Padding(4);
            this.tbPutClie.Name = "tbPutClie";
            this.tbPutClie.Padding = new System.Windows.Forms.Padding(4);
            this.tbPutClie.Size = new System.Drawing.Size(898, 566);
            this.tbPutClie.TabIndex = 0;
            this.tbPutClie.Text = "Insertar Clientes";
            // 
            // btnBuscarFile
            // 
            this.btnBuscarFile.BackColor = System.Drawing.Color.Red;
            this.btnBuscarFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarFile.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarFile.Image = global::MetaComissions.Properties.Resources.arrow_curve_270;
            this.btnBuscarFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarFile.Location = new System.Drawing.Point(765, 68);
            this.btnBuscarFile.Name = "btnBuscarFile";
            this.btnBuscarFile.Size = new System.Drawing.Size(96, 35);
            this.btnBuscarFile.TabIndex = 20;
            this.btnBuscarFile.Text = "Importar";
            this.btnBuscarFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarFile.UseVisualStyleBackColor = true;
            this.btnBuscarFile.Click += new System.EventHandler(this.btnBuscarFile_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(206, 107);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(551, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Visible = false;
            // 
            // chComi
            // 
            this.chComi.AutoSize = true;
            this.chComi.BackColor = System.Drawing.Color.Transparent;
            this.chComi.Location = new System.Drawing.Point(629, 326);
            this.chComi.Name = "chComi";
            this.chComi.Size = new System.Drawing.Size(15, 14);
            this.chComi.TabIndex = 19;
            this.chComi.UseVisualStyleBackColor = false;
            // 
            // lblMsgError
            // 
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.BackColor = System.Drawing.Color.LightCoral;
            this.lblMsgError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsgError.Enabled = false;
            this.lblMsgError.ForeColor = System.Drawing.Color.Maroon;
            this.lblMsgError.Location = new System.Drawing.Point(354, 68);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(2, 20);
            this.lblMsgError.TabIndex = 18;
            this.lblMsgError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsgError.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Red;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(479, 506);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 35);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Red;
            this.btnClean.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(354, 506);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(112, 35);
            this.btnClean.TabIndex = 16;
            this.btnClean.Text = "Limpiar Todo";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txtRefer
            // 
            this.txtRefer.Location = new System.Drawing.Point(629, 235);
            this.txtRefer.Multiline = true;
            this.txtRefer.Name = "txtRefer";
            this.txtRefer.Size = new System.Drawing.Size(260, 34);
            this.txtRefer.TabIndex = 13;
            // 
            // txtArti
            // 
            this.txtArti.Location = new System.Drawing.Point(629, 149);
            this.txtArti.Multiline = true;
            this.txtArti.Name = "txtArti";
            this.txtArti.Size = new System.Drawing.Size(260, 33);
            this.txtArti.TabIndex = 12;
            // 
            // txtIden
            // 
            this.txtIden.Location = new System.Drawing.Point(206, 406);
            this.txtIden.Multiline = true;
            this.txtIden.Name = "txtIden";
            this.txtIden.Size = new System.Drawing.Size(260, 36);
            this.txtIden.TabIndex = 11;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(206, 323);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(260, 35);
            this.txtCorreo.TabIndex = 10;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtTelef
            // 
            this.txtTelef.Location = new System.Drawing.Point(206, 241);
            this.txtTelef.Multiline = true;
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(260, 34);
            this.txtTelef.TabIndex = 9;
            this.txtTelef.TextChanged += new System.EventHandler(this.txtTelef_TextChanged);
            // 
            // txtNomClie
            // 
            this.txtNomClie.Location = new System.Drawing.Point(206, 149);
            this.txtNomClie.Multiline = true;
            this.txtNomClie.Name = "txtNomClie";
            this.txtNomClie.Size = new System.Drawing.Size(260, 33);
            this.txtNomClie.TabIndex = 8;
            this.txtNomClie.TextChanged += new System.EventHandler(this.txtNomClie_TextChanged);
            // 
            // lblComi
            // 
            this.lblComi.AutoSize = true;
            this.lblComi.BackColor = System.Drawing.Color.Transparent;
            this.lblComi.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblComi.Location = new System.Drawing.Point(475, 323);
            this.lblComi.Name = "lblComi";
            this.lblComi.Size = new System.Drawing.Size(85, 19);
            this.lblComi.TabIndex = 7;
            this.lblComi.Text = "Comision:";
            // 
            // lblRefer
            // 
            this.lblRefer.AutoSize = true;
            this.lblRefer.BackColor = System.Drawing.Color.Transparent;
            this.lblRefer.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRefer.Location = new System.Drawing.Point(475, 238);
            this.lblRefer.Name = "lblRefer";
            this.lblRefer.Size = new System.Drawing.Size(95, 19);
            this.lblRefer.TabIndex = 6;
            this.lblRefer.Text = "Referencia:";
            // 
            // lblArti
            // 
            this.lblArti.AutoSize = true;
            this.lblArti.BackColor = System.Drawing.Color.Transparent;
            this.lblArti.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArti.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblArti.Location = new System.Drawing.Point(475, 149);
            this.lblArti.Name = "lblArti";
            this.lblArti.Size = new System.Drawing.Size(139, 19);
            this.lblArti.TabIndex = 5;
            this.lblArti.Text = "Articulo vendido:";
            // 
            // lblIden
            // 
            this.lblIden.AutoSize = true;
            this.lblIden.BackColor = System.Drawing.Color.Transparent;
            this.lblIden.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIden.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblIden.Location = new System.Drawing.Point(18, 409);
            this.lblIden.Name = "lblIden";
            this.lblIden.Size = new System.Drawing.Size(182, 19);
            this.lblIden.TabIndex = 4;
            this.lblIden.Text = "Identifiacion(opcional):";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCorreo.Location = new System.Drawing.Point(18, 323);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(65, 19);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblTelef
            // 
            this.lblTelef.AutoSize = true;
            this.lblTelef.BackColor = System.Drawing.Color.Transparent;
            this.lblTelef.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelef.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTelef.Location = new System.Drawing.Point(18, 238);
            this.lblTelef.Name = "lblTelef";
            this.lblTelef.Size = new System.Drawing.Size(78, 19);
            this.lblTelef.TabIndex = 2;
            this.lblTelef.Text = "Telefono:";
            // 
            // lblNomClie
            // 
            this.lblNomClie.AutoSize = true;
            this.lblNomClie.BackColor = System.Drawing.Color.Transparent;
            this.lblNomClie.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomClie.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNomClie.Location = new System.Drawing.Point(18, 149);
            this.lblNomClie.Name = "lblNomClie";
            this.lblNomClie.Size = new System.Drawing.Size(158, 19);
            this.lblNomClie.TabIndex = 1;
            this.lblNomClie.Text = "Nombre del cliente:";
            // 
            // gbDatosGen
            // 
            this.gbDatosGen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbDatosGen.Controls.Add(this.label1);
            this.gbDatosGen.Location = new System.Drawing.Point(-1, 2);
            this.gbDatosGen.Name = "gbDatosGen";
            this.gbDatosGen.Size = new System.Drawing.Size(895, 54);
            this.gbDatosGen.TabIndex = 0;
            this.gbDatosGen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos Generales";
            // 
            // tbGetClie
            // 
            this.tbGetClie.BackColor = System.Drawing.Color.Gainsboro;
            this.tbGetClie.Controls.Add(this.btnDeleteGrid);
            this.tbGetClie.Controls.Add(this.btnSaveGrid);
            this.tbGetClie.Controls.Add(this.btnBuscar);
            this.tbGetClie.Controls.Add(this.dataGridView1);
            this.tbGetClie.Controls.Add(this.cbFilComi);
            this.tbGetClie.Controls.Add(this.txtFilRefer);
            this.tbGetClie.Controls.Add(this.txtFilArtiVendi);
            this.tbGetClie.Controls.Add(this.txtFilIden);
            this.tbGetClie.Controls.Add(this.txtFilCorreo);
            this.tbGetClie.Controls.Add(this.txtFilTelef);
            this.tbGetClie.Controls.Add(this.txtFilNomClie);
            this.tbGetClie.Controls.Add(this.lblFilComi);
            this.tbGetClie.Controls.Add(this.lblFilRefer);
            this.tbGetClie.Controls.Add(this.lblArtiVendi);
            this.tbGetClie.Controls.Add(this.lblFilIden);
            this.tbGetClie.Controls.Add(this.lblFilCorreo);
            this.tbGetClie.Controls.Add(this.lblFilTelef);
            this.tbGetClie.Controls.Add(this.lblFilNomClie);
            this.tbGetClie.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGetClie.Location = new System.Drawing.Point(4, 25);
            this.tbGetClie.Margin = new System.Windows.Forms.Padding(4);
            this.tbGetClie.Name = "tbGetClie";
            this.tbGetClie.Padding = new System.Windows.Forms.Padding(4);
            this.tbGetClie.Size = new System.Drawing.Size(898, 566);
            this.tbGetClie.TabIndex = 1;
            this.tbGetClie.Text = "Buscar Clientes";
            // 
            // btnDeleteGrid
            // 
            this.btnDeleteGrid.BackColor = System.Drawing.Color.Red;
            this.btnDeleteGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteGrid.Enabled = false;
            this.btnDeleteGrid.ForeColor = System.Drawing.Color.White;
            this.btnDeleteGrid.Location = new System.Drawing.Point(514, 509);
            this.btnDeleteGrid.Name = "btnDeleteGrid";
            this.btnDeleteGrid.Size = new System.Drawing.Size(100, 37);
            this.btnDeleteGrid.TabIndex = 37;
            this.btnDeleteGrid.Text = "Eliminar";
            this.btnDeleteGrid.UseVisualStyleBackColor = false;
            this.btnDeleteGrid.Click += new System.EventHandler(this.btnDeleteGrid_Click);
            // 
            // btnSaveGrid
            // 
            this.btnSaveGrid.BackColor = System.Drawing.Color.Red;
            this.btnSaveGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveGrid.Enabled = false;
            this.btnSaveGrid.ForeColor = System.Drawing.Color.White;
            this.btnSaveGrid.Location = new System.Drawing.Point(402, 509);
            this.btnSaveGrid.Name = "btnSaveGrid";
            this.btnSaveGrid.Size = new System.Drawing.Size(100, 37);
            this.btnSaveGrid.TabIndex = 36;
            this.btnSaveGrid.Text = "Guardar";
            this.btnSaveGrid.UseVisualStyleBackColor = false;
            this.btnSaveGrid.Click += new System.EventHandler(this.btnSaveGrid_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Red;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(287, 509);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 37);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(29, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 203);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // cbFilComi
            // 
            this.cbFilComi.AutoSize = true;
            this.cbFilComi.BackColor = System.Drawing.Color.Transparent;
            this.cbFilComi.Location = new System.Drawing.Point(614, 170);
            this.cbFilComi.Name = "cbFilComi";
            this.cbFilComi.Size = new System.Drawing.Size(15, 14);
            this.cbFilComi.TabIndex = 33;
            this.cbFilComi.UseVisualStyleBackColor = false;
            // 
            // txtFilRefer
            // 
            this.txtFilRefer.Location = new System.Drawing.Point(614, 98);
            this.txtFilRefer.Multiline = true;
            this.txtFilRefer.Name = "txtFilRefer";
            this.txtFilRefer.Size = new System.Drawing.Size(260, 34);
            this.txtFilRefer.TabIndex = 32;
            // 
            // txtFilArtiVendi
            // 
            this.txtFilArtiVendi.Location = new System.Drawing.Point(614, 37);
            this.txtFilArtiVendi.Multiline = true;
            this.txtFilArtiVendi.Name = "txtFilArtiVendi";
            this.txtFilArtiVendi.Size = new System.Drawing.Size(260, 33);
            this.txtFilArtiVendi.TabIndex = 31;
            // 
            // txtFilIden
            // 
            this.txtFilIden.Location = new System.Drawing.Point(191, 229);
            this.txtFilIden.Multiline = true;
            this.txtFilIden.Name = "txtFilIden";
            this.txtFilIden.Size = new System.Drawing.Size(260, 36);
            this.txtFilIden.TabIndex = 30;
            // 
            // txtFilCorreo
            // 
            this.txtFilCorreo.Location = new System.Drawing.Point(191, 163);
            this.txtFilCorreo.Multiline = true;
            this.txtFilCorreo.Name = "txtFilCorreo";
            this.txtFilCorreo.Size = new System.Drawing.Size(260, 35);
            this.txtFilCorreo.TabIndex = 29;
            // 
            // txtFilTelef
            // 
            this.txtFilTelef.Location = new System.Drawing.Point(191, 98);
            this.txtFilTelef.Multiline = true;
            this.txtFilTelef.Name = "txtFilTelef";
            this.txtFilTelef.Size = new System.Drawing.Size(260, 34);
            this.txtFilTelef.TabIndex = 28;
            // 
            // txtFilNomClie
            // 
            this.txtFilNomClie.Location = new System.Drawing.Point(191, 37);
            this.txtFilNomClie.Multiline = true;
            this.txtFilNomClie.Name = "txtFilNomClie";
            this.txtFilNomClie.Size = new System.Drawing.Size(260, 33);
            this.txtFilNomClie.TabIndex = 27;
            // 
            // lblFilComi
            // 
            this.lblFilComi.AutoSize = true;
            this.lblFilComi.BackColor = System.Drawing.Color.Transparent;
            this.lblFilComi.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilComi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFilComi.Location = new System.Drawing.Point(514, 170);
            this.lblFilComi.Name = "lblFilComi";
            this.lblFilComi.Size = new System.Drawing.Size(85, 19);
            this.lblFilComi.TabIndex = 26;
            this.lblFilComi.Text = "Comision:";
            // 
            // lblFilRefer
            // 
            this.lblFilRefer.AutoSize = true;
            this.lblFilRefer.BackColor = System.Drawing.Color.Transparent;
            this.lblFilRefer.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilRefer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFilRefer.Location = new System.Drawing.Point(504, 105);
            this.lblFilRefer.Name = "lblFilRefer";
            this.lblFilRefer.Size = new System.Drawing.Size(95, 19);
            this.lblFilRefer.TabIndex = 25;
            this.lblFilRefer.Text = "Referencia:";
            // 
            // lblArtiVendi
            // 
            this.lblArtiVendi.AutoSize = true;
            this.lblArtiVendi.BackColor = System.Drawing.Color.Transparent;
            this.lblArtiVendi.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtiVendi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblArtiVendi.Location = new System.Drawing.Point(460, 37);
            this.lblArtiVendi.Name = "lblArtiVendi";
            this.lblArtiVendi.Size = new System.Drawing.Size(139, 19);
            this.lblArtiVendi.TabIndex = 24;
            this.lblArtiVendi.Text = "Articulo vendido:";
            // 
            // lblFilIden
            // 
            this.lblFilIden.AutoSize = true;
            this.lblFilIden.BackColor = System.Drawing.Color.Transparent;
            this.lblFilIden.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilIden.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFilIden.Location = new System.Drawing.Point(3, 236);
            this.lblFilIden.Name = "lblFilIden";
            this.lblFilIden.Size = new System.Drawing.Size(182, 19);
            this.lblFilIden.TabIndex = 23;
            this.lblFilIden.Text = "Identifiacion(opcional):";
            // 
            // lblFilCorreo
            // 
            this.lblFilCorreo.AutoSize = true;
            this.lblFilCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblFilCorreo.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilCorreo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFilCorreo.Location = new System.Drawing.Point(96, 170);
            this.lblFilCorreo.Name = "lblFilCorreo";
            this.lblFilCorreo.Size = new System.Drawing.Size(65, 19);
            this.lblFilCorreo.TabIndex = 22;
            this.lblFilCorreo.Text = "Correo:";
            // 
            // lblFilTelef
            // 
            this.lblFilTelef.AutoSize = true;
            this.lblFilTelef.BackColor = System.Drawing.Color.Transparent;
            this.lblFilTelef.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilTelef.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFilTelef.Location = new System.Drawing.Point(83, 98);
            this.lblFilTelef.Name = "lblFilTelef";
            this.lblFilTelef.Size = new System.Drawing.Size(78, 19);
            this.lblFilTelef.TabIndex = 21;
            this.lblFilTelef.Text = "Telefono:";
            // 
            // lblFilNomClie
            // 
            this.lblFilNomClie.AutoSize = true;
            this.lblFilNomClie.BackColor = System.Drawing.Color.Transparent;
            this.lblFilNomClie.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilNomClie.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFilNomClie.Location = new System.Drawing.Point(3, 37);
            this.lblFilNomClie.Name = "lblFilNomClie";
            this.lblFilNomClie.Size = new System.Drawing.Size(158, 19);
            this.lblFilNomClie.TabIndex = 20;
            this.lblFilNomClie.Text = "Nombre del cliente:";
            // 
            // tbReport
            // 
            this.tbReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReport.Controls.Add(this.reportViewer1);
            this.tbReport.Location = new System.Drawing.Point(4, 25);
            this.tbReport.Name = "tbReport";
            this.tbReport.Padding = new System.Windows.Forms.Padding(3);
            this.tbReport.Size = new System.Drawing.Size(898, 566);
            this.tbReport.TabIndex = 3;
            this.tbReport.Text = "Reporte";
            this.tbReport.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.reportViewer1.Cursor = System.Windows.Forms.Cursors.No;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.EnableHyperlinks = true;
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(890, 558);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // tbDtSql
            // 
            this.tbDtSql.BackColor = System.Drawing.Color.Gainsboro;
            this.tbDtSql.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDtSql.Controls.Add(this.btnRegristar);
            this.tbDtSql.Controls.Add(this.txtPassword);
            this.tbDtSql.Controls.Add(this.txtUser);
            this.tbDtSql.Controls.Add(this.txtDataBase);
            this.tbDtSql.Controls.Add(this.txtDataSource);
            this.tbDtSql.Controls.Add(this.lblPass);
            this.tbDtSql.Controls.Add(this.lblUser);
            this.tbDtSql.Controls.Add(this.lblDataBase);
            this.tbDtSql.Controls.Add(this.lblDataSource);
            this.tbDtSql.Controls.Add(this.lblDatos);
            this.tbDtSql.Location = new System.Drawing.Point(4, 25);
            this.tbDtSql.Name = "tbDtSql";
            this.tbDtSql.Padding = new System.Windows.Forms.Padding(3);
            this.tbDtSql.Size = new System.Drawing.Size(898, 566);
            this.tbDtSql.TabIndex = 2;
            this.tbDtSql.Text = "Datos SQL";
            // 
            // btnRegristar
            // 
            this.btnRegristar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegristar.Location = new System.Drawing.Point(444, 476);
            this.btnRegristar.Name = "btnRegristar";
            this.btnRegristar.Size = new System.Drawing.Size(110, 29);
            this.btnRegristar.TabIndex = 9;
            this.btnRegristar.Text = "Registrar";
            this.btnRegristar.UseVisualStyleBackColor = true;
            this.btnRegristar.Click += new System.EventHandler(this.btnRegristar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(188, 311);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(309, 33);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(188, 229);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(309, 33);
            this.txtUser.TabIndex = 7;
            // 
            // txtDataBase
            // 
            this.txtDataBase.Location = new System.Drawing.Point(188, 396);
            this.txtDataBase.Multiline = true;
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(309, 33);
            this.txtDataBase.TabIndex = 6;
            this.txtDataBase.Visible = false;
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(188, 150);
            this.txtDataSource.Multiline = true;
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(309, 33);
            this.txtDataSource.TabIndex = 5;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(60, 313);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(82, 18);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(60, 231);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(47, 18);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User:";
            // 
            // lblDataBase
            // 
            this.lblDataBase.AutoSize = true;
            this.lblDataBase.BackColor = System.Drawing.Color.Transparent;
            this.lblDataBase.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBase.Location = new System.Drawing.Point(60, 398);
            this.lblDataBase.Name = "lblDataBase";
            this.lblDataBase.Size = new System.Drawing.Size(82, 18);
            this.lblDataBase.TabIndex = 2;
            this.lblDataBase.Text = "DataBase:";
            this.lblDataBase.Visible = false;
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.BackColor = System.Drawing.Color.Transparent;
            this.lblDataSource.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSource.Location = new System.Drawing.Point(60, 152);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(97, 18);
            this.lblDataSource.TabIndex = 1;
            this.lblDataSource.Text = "DataSource:";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(57, 34);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(92, 33);
            this.lblDatos.TabIndex = 0;
            this.lblDatos.Text = "Datos";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 633);
            this.Controls.Add(this.tbMenu);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tbMenu.ResumeLayout(false);
            this.tbPutClie.ResumeLayout(false);
            this.tbPutClie.PerformLayout();
            this.gbDatosGen.ResumeLayout(false);
            this.gbDatosGen.PerformLayout();
            this.tbGetClie.ResumeLayout(false);
            this.tbGetClie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbReport.ResumeLayout(false);
            this.tbDtSql.ResumeLayout(false);
            this.tbDtSql.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMenu;
        private System.Windows.Forms.TabPage tbPutClie;
        private System.Windows.Forms.TabPage tbGetClie;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelef;
        private System.Windows.Forms.Label lblNomClie;
        private System.Windows.Forms.GroupBox gbDatosGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComi;
        private System.Windows.Forms.Label lblRefer;
        private System.Windows.Forms.Label lblArti;
        private System.Windows.Forms.Label lblIden;
        private System.Windows.Forms.TextBox txtRefer;
        private System.Windows.Forms.TextBox txtArti;
        private System.Windows.Forms.TextBox txtIden;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.TextBox txtNomClie;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label lblMsgError;
        private System.Windows.Forms.CheckBox chComi;
        private System.Windows.Forms.TabPage tbDtSql;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblDataBase;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegristar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbFilComi;
        private System.Windows.Forms.TextBox txtFilRefer;
        private System.Windows.Forms.TextBox txtFilArtiVendi;
        private System.Windows.Forms.TextBox txtFilIden;
        private System.Windows.Forms.TextBox txtFilCorreo;
        private System.Windows.Forms.TextBox txtFilTelef;
        private System.Windows.Forms.TextBox txtFilNomClie;
        private System.Windows.Forms.Label lblFilComi;
        private System.Windows.Forms.Label lblFilRefer;
        private System.Windows.Forms.Label lblArtiVendi;
        private System.Windows.Forms.Label lblFilIden;
        private System.Windows.Forms.Label lblFilCorreo;
        private System.Windows.Forms.Label lblFilTelef;
        private System.Windows.Forms.Label lblFilNomClie;
        private System.Windows.Forms.Button btnSaveGrid;
        private System.Windows.Forms.Button btnDeleteGrid;
        private System.Windows.Forms.TabPage tbReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnBuscarFile;
    }
}