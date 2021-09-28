namespace MétodosNumericos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnCorcheteAbre = new System.Windows.Forms.Button();
            this.btnCorcheteCierra = new System.Windows.Forms.Button();
            this.btnExponencial = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.pnlMetodos = new System.Windows.Forms.Panel();
            this.btnNewton = new System.Windows.Forms.Button();
            this.btnBiseccion = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.TextBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.Iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorAbsoluto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorVerdadero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxPreferencias = new System.Windows.Forms.ComboBox();
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnCoseno = new System.Windows.Forms.Button();
            this.btnTangente = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.pnlPreferencias = new System.Windows.Forms.Panel();
            this.cbx3 = new System.Windows.Forms.ComboBox();
            this.cbx2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPref = new System.Windows.Forms.Button();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtER = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtxtAyuda = new System.Windows.Forms.RichTextBox();
            this.btnCerrarAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMetodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.pnlPreferencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = global::MétodosNumericos.Properties.Resources.f_x__white;
            this.pictureBox1.Image = global::MétodosNumericos.Properties.Resources.f_x__black;
            this.pictureBox1.InitialImage = global::MétodosNumericos.Properties.Resources.f_x__black;
            this.pictureBox1.Location = new System.Drawing.Point(36, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtFuncion
            // 
            this.txtFuncion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFuncion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFuncion.Font = new System.Drawing.Font("Maiandra GD", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncion.Location = new System.Drawing.Point(118, 69);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(1179, 49);
            this.txtFuncion.TabIndex = 1;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Azure;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(118, 127);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Azure;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(174, 127);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Azure;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(230, 127);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Azure;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(118, 183);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Azure;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(118, 239);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Azure;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(230, 183);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Azure;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(174, 183);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Azure;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(174, 239);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Azure;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(230, 239);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Azure;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(118, 295);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(106, 50);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.Azure;
            this.btnPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(230, 295);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(50, 50);
            this.btnPunto.TabIndex = 11;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.BtnPunto_Click);
            // 
            // btnMas
            // 
            this.btnMas.BackColor = System.Drawing.Color.Azure;
            this.btnMas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMas.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.Location = new System.Drawing.Point(342, 127);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(50, 50);
            this.btnMas.TabIndex = 12;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = false;
            this.btnMas.Click += new System.EventHandler(this.BtnMas_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.Azure;
            this.btnMenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(342, 183);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(50, 50);
            this.btnMenos.TabIndex = 13;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.BtnMenos_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.Azure;
            this.btnMultiplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(342, 239);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(50, 50);
            this.btnMultiplicacion.TabIndex = 13;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.BtnMultiplicacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.Azure;
            this.btnDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(343, 295);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(50, 50);
            this.btnDivision.TabIndex = 14;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Azure;
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(287, 295);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(50, 50);
            this.btnX.TabIndex = 15;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // btnCorcheteAbre
            // 
            this.btnCorcheteAbre.BackColor = System.Drawing.Color.Azure;
            this.btnCorcheteAbre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorcheteAbre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorcheteAbre.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorcheteAbre.Location = new System.Drawing.Point(287, 183);
            this.btnCorcheteAbre.Name = "btnCorcheteAbre";
            this.btnCorcheteAbre.Size = new System.Drawing.Size(50, 50);
            this.btnCorcheteAbre.TabIndex = 16;
            this.btnCorcheteAbre.Text = "(";
            this.btnCorcheteAbre.UseVisualStyleBackColor = false;
            this.btnCorcheteAbre.Click += new System.EventHandler(this.BtnCorcheteAbre_Click);
            // 
            // btnCorcheteCierra
            // 
            this.btnCorcheteCierra.BackColor = System.Drawing.Color.Azure;
            this.btnCorcheteCierra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorcheteCierra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorcheteCierra.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorcheteCierra.Location = new System.Drawing.Point(286, 239);
            this.btnCorcheteCierra.Name = "btnCorcheteCierra";
            this.btnCorcheteCierra.Size = new System.Drawing.Size(50, 50);
            this.btnCorcheteCierra.TabIndex = 17;
            this.btnCorcheteCierra.Text = ")";
            this.btnCorcheteCierra.UseVisualStyleBackColor = false;
            this.btnCorcheteCierra.Click += new System.EventHandler(this.BtnCorcheteCierra_Click);
            // 
            // btnExponencial
            // 
            this.btnExponencial.BackColor = System.Drawing.Color.Azure;
            this.btnExponencial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExponencial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExponencial.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExponencial.Location = new System.Drawing.Point(287, 127);
            this.btnExponencial.Name = "btnExponencial";
            this.btnExponencial.Size = new System.Drawing.Size(50, 50);
            this.btnExponencial.TabIndex = 18;
            this.btnExponencial.Text = "^";
            this.btnExponencial.UseVisualStyleBackColor = false;
            this.btnExponencial.Click += new System.EventHandler(this.BtnExponencial_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Azure;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(398, 127);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 106);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "DEL";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.Color.Azure;
            this.btnAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAC.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.Location = new System.Drawing.Point(398, 239);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(67, 106);
            this.btnAC.TabIndex = 20;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = false;
            this.btnAC.Click += new System.EventHandler(this.BtnAC_Click);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEvaluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEvaluar.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluar.ForeColor = System.Drawing.Color.White;
            this.btnEvaluar.Location = new System.Drawing.Point(118, 539);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(347, 50);
            this.btnEvaluar.TabIndex = 21;
            this.btnEvaluar.Text = "EVALUAR";
            this.btnEvaluar.UseVisualStyleBackColor = false;
            this.btnEvaluar.Click += new System.EventHandler(this.BtnEvaluar_Click);
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtA.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(251, 482);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(75, 42);
            this.txtA.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "Intervalo:   [          -           ]";
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtB.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(358, 482);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(78, 42);
            this.txtB.TabIndex = 26;
            // 
            // pnlMetodos
            // 
            this.pnlMetodos.BackColor = System.Drawing.Color.Transparent;
            this.pnlMetodos.Controls.Add(this.btnNewton);
            this.pnlMetodos.Controls.Add(this.btnBiseccion);
            this.pnlMetodos.Location = new System.Drawing.Point(174, 539);
            this.pnlMetodos.Name = "pnlMetodos";
            this.pnlMetodos.Size = new System.Drawing.Size(247, 98);
            this.pnlMetodos.TabIndex = 27;
            // 
            // btnNewton
            // 
            this.btnNewton.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewton.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewton.ForeColor = System.Drawing.Color.White;
            this.btnNewton.Location = new System.Drawing.Point(3, 54);
            this.btnNewton.Name = "btnNewton";
            this.btnNewton.Size = new System.Drawing.Size(241, 39);
            this.btnNewton.TabIndex = 29;
            this.btnNewton.Text = "FALSA POSICION";
            this.btnNewton.UseVisualStyleBackColor = false;
            this.btnNewton.Click += new System.EventHandler(this.BtnFalsaPosicion_Click);
            // 
            // btnBiseccion
            // 
            this.btnBiseccion.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBiseccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiseccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBiseccion.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiseccion.ForeColor = System.Drawing.Color.White;
            this.btnBiseccion.Location = new System.Drawing.Point(3, 5);
            this.btnBiseccion.Name = "btnBiseccion";
            this.btnBiseccion.Size = new System.Drawing.Size(241, 39);
            this.btnBiseccion.TabIndex = 28;
            this.btnBiseccion.Text = "BISECCIÓN";
            this.btnBiseccion.UseVisualStyleBackColor = false;
            this.btnBiseccion.Click += new System.EventHandler(this.BtnBiseccion_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSet.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.Transparent;
            this.btnSet.Location = new System.Drawing.Point(21, 176);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(466, 31);
            this.btnSet.TabIndex = 28;
            this.btnSet.Text = "ASIGNAR";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.Color.LightGray;
            this.txtError.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtError.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.Location = new System.Drawing.Point(345, 34);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(142, 30);
            this.txtError.TabIndex = 29;
            this.txtError.Text = "1";
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Crimson;
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.Transparent;
            this.btnAyuda.Location = new System.Drawing.Point(1303, 69);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(54, 49);
            this.btnAyuda.TabIndex = 30;
            this.btnAyuda.Text = "?";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.AllowUserToResizeColumns = false;
            this.dgvTabla.AllowUserToResizeRows = false;
            this.dgvTabla.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.Xi,
            this.Xu,
            this.Xr,
            this.ErrorAbsoluto,
            this.ErrorVerdadero});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTabla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTabla.GridColor = System.Drawing.Color.Navy;
            this.dgvTabla.Location = new System.Drawing.Point(471, 127);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTabla.Size = new System.Drawing.Size(886, 424);
            this.dgvTabla.TabIndex = 31;
            // 
            // Iteracion
            // 
            this.Iteracion.HeaderText = "I";
            this.Iteracion.Name = "Iteracion";
            this.Iteracion.ReadOnly = true;
            this.Iteracion.Width = 45;
            // 
            // Xi
            // 
            this.Xi.HeaderText = "Xi";
            this.Xi.Name = "Xi";
            this.Xi.ReadOnly = true;
            this.Xi.Width = 133;
            // 
            // Xu
            // 
            this.Xu.HeaderText = "Xu";
            this.Xu.Name = "Xu";
            this.Xu.ReadOnly = true;
            this.Xu.Width = 133;
            // 
            // Xr
            // 
            this.Xr.HeaderText = "Xr";
            this.Xr.Name = "Xr";
            this.Xr.ReadOnly = true;
            this.Xr.Width = 133;
            // 
            // ErrorAbsoluto
            // 
            this.ErrorAbsoluto.HeaderText = "Error Relativo (%)";
            this.ErrorAbsoluto.Name = "ErrorAbsoluto";
            this.ErrorAbsoluto.ReadOnly = true;
            this.ErrorAbsoluto.Width = 200;
            // 
            // ErrorVerdadero
            // 
            this.ErrorVerdadero.HeaderText = "Error Verdadero";
            this.ErrorVerdadero.Name = "ErrorVerdadero";
            this.ErrorVerdadero.ReadOnly = true;
            this.ErrorVerdadero.Width = 200;
            // 
            // cbxPreferencias
            // 
            this.cbxPreferencias.BackColor = System.Drawing.Color.White;
            this.cbxPreferencias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxPreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPreferencias.FormattingEnabled = true;
            this.cbxPreferencias.Items.AddRange(new object[] {
            "Error Porcentual",
            "Error Verdadero",
            "Iteración"});
            this.cbxPreferencias.Location = new System.Drawing.Point(21, 34);
            this.cbxPreferencias.Name = "cbxPreferencias";
            this.cbxPreferencias.Size = new System.Drawing.Size(199, 32);
            this.cbxPreferencias.TabIndex = 33;
            this.cbxPreferencias.Text = "Error Porcentual";
            this.cbxPreferencias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxPreferencias_KeyPress);
            // 
            // btnSeno
            // 
            this.btnSeno.BackColor = System.Drawing.Color.Azure;
            this.btnSeno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeno.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeno.Location = new System.Drawing.Point(118, 351);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(84, 50);
            this.btnSeno.TabIndex = 34;
            this.btnSeno.Text = "SEN";
            this.btnSeno.UseVisualStyleBackColor = false;
            this.btnSeno.Click += new System.EventHandler(this.BtnSeno_Click);
            // 
            // btnCoseno
            // 
            this.btnCoseno.BackColor = System.Drawing.Color.Azure;
            this.btnCoseno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoseno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCoseno.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoseno.Location = new System.Drawing.Point(208, 351);
            this.btnCoseno.Name = "btnCoseno";
            this.btnCoseno.Size = new System.Drawing.Size(86, 50);
            this.btnCoseno.TabIndex = 35;
            this.btnCoseno.Text = "COS";
            this.btnCoseno.UseVisualStyleBackColor = false;
            this.btnCoseno.Click += new System.EventHandler(this.BtnCoseno_Click);
            // 
            // btnTangente
            // 
            this.btnTangente.BackColor = System.Drawing.Color.Azure;
            this.btnTangente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTangente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTangente.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangente.Location = new System.Drawing.Point(300, 351);
            this.btnTangente.Name = "btnTangente";
            this.btnTangente.Size = new System.Drawing.Size(93, 50);
            this.btnTangente.TabIndex = 36;
            this.btnTangente.Text = "TAN";
            this.btnTangente.UseVisualStyleBackColor = false;
            this.btnTangente.Click += new System.EventHandler(this.BtnTangente_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.Azure;
            this.btnRaiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(398, 351);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(67, 50);
            this.btnRaiz.TabIndex = 37;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.BtnRaiz_Click);
            // 
            // pnlPreferencias
            // 
            this.pnlPreferencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPreferencias.Controls.Add(this.label8);
            this.pnlPreferencias.Controls.Add(this.cbx3);
            this.pnlPreferencias.Controls.Add(this.cbx2);
            this.pnlPreferencias.Controls.Add(this.label4);
            this.pnlPreferencias.Controls.Add(this.label3);
            this.pnlPreferencias.Controls.Add(this.cbx1);
            this.pnlPreferencias.Controls.Add(this.label2);
            this.pnlPreferencias.Controls.Add(this.cbxPreferencias);
            this.pnlPreferencias.Controls.Add(this.txtError);
            this.pnlPreferencias.Controls.Add(this.btnSet);
            this.pnlPreferencias.Location = new System.Drawing.Point(553, 233);
            this.pnlPreferencias.Name = "pnlPreferencias";
            this.pnlPreferencias.Size = new System.Drawing.Size(500, 221);
            this.pnlPreferencias.TabIndex = 30;
            // 
            // cbx3
            // 
            this.cbx3.BackColor = System.Drawing.Color.White;
            this.cbx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx3.FormattingEnabled = true;
            this.cbx3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbx3.Location = new System.Drawing.Point(345, 103);
            this.cbx3.Name = "cbx3";
            this.cbx3.Size = new System.Drawing.Size(142, 28);
            this.cbx3.TabIndex = 41;
            this.cbx3.Text = "5";
            this.cbx3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbx3_KeyPress);
            // 
            // cbx2
            // 
            this.cbx2.BackColor = System.Drawing.Color.White;
            this.cbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx2.FormattingEnabled = true;
            this.cbx2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbx2.Location = new System.Drawing.Point(345, 69);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(142, 28);
            this.cbx2.TabIndex = 40;
            this.cbx2.Text = "5";
            this.cbx2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbx2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Cifras de redondeo en error porcentual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "Cifras de redondeo en error verdadero";
            // 
            // cbx1
            // 
            this.cbx1.BackColor = System.Drawing.Color.White;
            this.cbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbx1.Location = new System.Drawing.Point(345, 137);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(142, 28);
            this.cbx1.TabIndex = 37;
            this.cbx1.Text = "5";
            this.cbx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbx1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cifras de Redondeo";
            // 
            // btnPref
            // 
            this.btnPref.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPref.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPref.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPref.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPref.ForeColor = System.Drawing.Color.Transparent;
            this.btnPref.Location = new System.Drawing.Point(118, 422);
            this.btnPref.Name = "btnPref";
            this.btnPref.Size = new System.Drawing.Size(347, 41);
            this.btnPref.TabIndex = 34;
            this.btnPref.Text = "PREFERNCIAS";
            this.btnPref.UseVisualStyleBackColor = false;
            this.btnPref.Click += new System.EventHandler(this.BtnPref_Click);
            // 
            // txtRA
            // 
            this.txtRA.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRA.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRA.Location = new System.Drawing.Point(697, 557);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(275, 30);
            this.txtRA.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 28);
            this.label5.TabIndex = 39;
            this.label5.Text = "RAIZ APROXIMADA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(978, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 28);
            this.label6.TabIndex = 41;
            this.label6.Text = "ER(%)";
            // 
            // txtER
            // 
            this.txtER.BackColor = System.Drawing.Color.Gainsboro;
            this.txtER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtER.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtER.Location = new System.Drawing.Point(1061, 557);
            this.txtER.Name = "txtER";
            this.txtER.Size = new System.Drawing.Size(112, 30);
            this.txtER.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1202, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 28);
            this.label7.TabIndex = 43;
            this.label7.Text = "EV";
            // 
            // txtEV
            // 
            this.txtEV.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEV.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEV.Location = new System.Drawing.Point(1245, 557);
            this.txtEV.Name = "txtEV";
            this.txtEV.Size = new System.Drawing.Size(112, 30);
            this.txtEV.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 44;
            this.label8.Text = "ITERAR POR:";
            // 
            // rtxtAyuda
            // 
            this.rtxtAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtAyuda.Location = new System.Drawing.Point(471, 124);
            this.rtxtAyuda.Name = "rtxtAyuda";
            this.rtxtAyuda.Size = new System.Drawing.Size(886, 427);
            this.rtxtAyuda.TabIndex = 44;
            this.rtxtAyuda.Text = resources.GetString("rtxtAyuda.Text");
            // 
            // btnCerrarAyuda
            // 
            this.btnCerrarAyuda.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrarAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarAyuda.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarAyuda.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrarAyuda.Location = new System.Drawing.Point(1325, 127);
            this.btnCerrarAyuda.Name = "btnCerrarAyuda";
            this.btnCerrarAyuda.Size = new System.Drawing.Size(32, 29);
            this.btnCerrarAyuda.TabIndex = 45;
            this.btnCerrarAyuda.Text = "X";
            this.btnCerrarAyuda.UseVisualStyleBackColor = false;
            this.btnCerrarAyuda.Click += new System.EventHandler(this.BtnCerrarAyuda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MétodosNumericos.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnCerrarAyuda);
            this.Controls.Add(this.rtxtAyuda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtER);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.pnlMetodos);
            this.Controls.Add(this.btnPref);
            this.Controls.Add(this.pnlPreferencias);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnTangente);
            this.Controls.Add(this.btnCoseno);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnExponencial);
            this.Controls.Add(this.btnCorcheteCierra);
            this.Controls.Add(this.btnCorcheteAbre);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTabla);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÉTODOS NUMÉRICOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMetodos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.pnlPreferencias.ResumeLayout(false);
            this.pnlPreferencias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnCorcheteAbre;
        private System.Windows.Forms.Button btnCorcheteCierra;
        private System.Windows.Forms.Button btnExponencial;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Panel pnlMetodos;
        private System.Windows.Forms.Button btnNewton;
        private System.Windows.Forms.Button btnBiseccion;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorAbsoluto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorVerdadero;
        private System.Windows.Forms.ComboBox cbxPreferencias;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnCoseno;
        private System.Windows.Forms.Button btnTangente;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Panel pnlPreferencias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPref;
        private System.Windows.Forms.ComboBox cbx3;
        private System.Windows.Forms.ComboBox cbx2;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtER;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtxtAyuda;
        private System.Windows.Forms.Button btnCerrarAyuda;
    }
}

