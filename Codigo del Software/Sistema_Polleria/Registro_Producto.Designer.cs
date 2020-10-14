namespace Sistema_Polleria
{
    partial class Registro_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Producto));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbInsumo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbKilo = new System.Windows.Forms.RadioButton();
            this.rbLitro = new System.Windows.Forms.RadioButton();
            this.rbUnidad = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.spCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescrip = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtIngreso = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedores:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DisplayMember = "Idempresa";
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(124, 46);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 25);
            this.cmbProveedor.TabIndex = 1;
            this.cmbProveedor.ValueMember = "Idempresa";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtDescrip);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtIngreso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbProveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 390);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Insumos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbInsumo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rbKilo);
            this.groupBox2.Controls.Add(this.rbLitro);
            this.groupBox2.Controls.Add(this.rbUnidad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.spCantidad);
            this.groupBox2.Location = new System.Drawing.Point(41, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cantidades";
            // 
            // cmbInsumo
            // 
            this.cmbInsumo.FormattingEnabled = true;
            this.cmbInsumo.Items.AddRange(new object[] {
            "Pollo",
            "Salsas",
            "Aceite",
            "Carbón",
            "Papas",
            "Verduras"});
            this.cmbInsumo.Location = new System.Drawing.Point(119, 45);
            this.cmbInsumo.Name = "cmbInsumo";
            this.cmbInsumo.Size = new System.Drawing.Size(121, 25);
            this.cmbInsumo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Insumo:";
            // 
            // rbKilo
            // 
            this.rbKilo.AutoSize = true;
            this.rbKilo.Location = new System.Drawing.Point(297, 52);
            this.rbKilo.Name = "rbKilo";
            this.rbKilo.Size = new System.Drawing.Size(45, 23);
            this.rbKilo.TabIndex = 10;
            this.rbKilo.TabStop = true;
            this.rbKilo.Text = "KG";
            this.rbKilo.UseVisualStyleBackColor = true;
            // 
            // rbLitro
            // 
            this.rbLitro.AutoSize = true;
            this.rbLitro.Location = new System.Drawing.Point(297, 75);
            this.rbLitro.Name = "rbLitro";
            this.rbLitro.Size = new System.Drawing.Size(34, 23);
            this.rbLitro.TabIndex = 11;
            this.rbLitro.TabStop = true;
            this.rbLitro.Text = "L";
            this.rbLitro.UseVisualStyleBackColor = true;
            // 
            // rbUnidad
            // 
            this.rbUnidad.AutoSize = true;
            this.rbUnidad.Location = new System.Drawing.Point(297, 29);
            this.rbUnidad.Name = "rbUnidad";
            this.rbUnidad.Size = new System.Drawing.Size(84, 23);
            this.rbUnidad.TabIndex = 9;
            this.rbUnidad.TabStop = true;
            this.rbUnidad.Text = "Unidades";
            this.rbUnidad.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            // 
            // spCantidad
            // 
            this.spCantidad.Location = new System.Drawing.Point(479, 47);
            this.spCantidad.Name = "spCantidad";
            this.spCantidad.Size = new System.Drawing.Size(120, 25);
            this.spCantidad.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(323, 349);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 35);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(41, 235);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(640, 96);
            this.txtDescrip.TabIndex = 7;
            this.txtDescrip.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripción";
            // 
            // dtIngreso
            // 
            this.dtIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIngreso.Location = new System.Drawing.Point(454, 47);
            this.dtIngreso.Name = "dtIngreso";
            this.dtIngreso.Size = new System.Drawing.Size(200, 25);
            this.dtIngreso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Ingreso:";
            // 
            // Registro_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_Producto";
            this.Text = "Registro_Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown spCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbKilo;
        private System.Windows.Forms.RadioButton rbLitro;
        private System.Windows.Forms.RadioButton rbUnidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RichTextBox txtDescrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbInsumo;
        private System.Windows.Forms.Label label5;
    }
}