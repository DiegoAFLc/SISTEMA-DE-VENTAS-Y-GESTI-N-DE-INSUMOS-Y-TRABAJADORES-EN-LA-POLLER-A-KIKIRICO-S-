namespace Sistema_Polleria
{
    partial class Precios_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Precios_Productos));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.spPrecio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gvProductos = new System.Windows.Forms.DataGridView();
            this.IDPROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.spPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos:";
            // 
            // cmbProductos
            // 
            this.cmbProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(126, 60);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(148, 21);
            this.cmbProductos.TabIndex = 1;
            // 
            // spPrecio
            // 
            this.spPrecio.BackColor = System.Drawing.SystemColors.Info;
            this.spPrecio.Location = new System.Drawing.Point(126, 114);
            this.spPrecio.Name = "spPrecio";
            this.spPrecio.Size = new System.Drawing.Size(120, 20);
            this.spPrecio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(302, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gvProductos
            // 
            this.gvProductos.BackgroundColor = System.Drawing.Color.Chocolate;
            this.gvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPROD,
            this.DES,
            this.PRE});
            this.gvProductos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gvProductos.Location = new System.Drawing.Point(322, 60);
            this.gvProductos.Name = "gvProductos";
            this.gvProductos.Size = new System.Drawing.Size(393, 115);
            this.gvProductos.TabIndex = 5;
            this.gvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProductos_CellClick);
            // 
            // IDPROD
            // 
            this.IDPROD.DataPropertyName = "IdProd";
            this.IDPROD.HeaderText = "ID";
            this.IDPROD.Name = "IDPROD";
            // 
            // DES
            // 
            this.DES.DataPropertyName = "Descripcion";
            this.DES.HeaderText = "Descripción";
            this.DES.Name = "DES";
            this.DES.Width = 150;
            // 
            // PRE
            // 
            this.PRE.DataPropertyName = "Precio";
            this.PRE.HeaderText = "Precio";
            this.PRE.Name = "PRE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvProductos);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbProductos);
            this.groupBox1.Controls.Add(this.spPrecio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 409);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de Productos";
            // 
            // Precios_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Precios_Productos";
            this.Text = "Precios_Productos";
            ((System.ComponentModel.ISupportInitialize)(this.spPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.NumericUpDown spPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DES;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRE;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}