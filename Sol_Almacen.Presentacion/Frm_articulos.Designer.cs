namespace Sol_Almacen.Presentacion
{
    partial class Frm_articulos
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
            this.Dgv_articulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_descripcion_ar = new System.Windows.Forms.TextBox();
            this.Txt_marca_ar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_descripcion_um = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Txt_descripcion_ca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_stock_actual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_articulos
            // 
            this.Dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_articulos.Location = new System.Drawing.Point(1, 201);
            this.Dgv_articulos.Name = "Dgv_articulos";
            this.Dgv_articulos.Size = new System.Drawing.Size(989, 286);
            this.Dgv_articulos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Articulo:";
            // 
            // Txt_descripcion_ar
            // 
            this.Txt_descripcion_ar.Location = new System.Drawing.Point(75, 14);
            this.Txt_descripcion_ar.Name = "Txt_descripcion_ar";
            this.Txt_descripcion_ar.Size = new System.Drawing.Size(364, 20);
            this.Txt_descripcion_ar.TabIndex = 2;
            // 
            // Txt_marca_ar
            // 
            this.Txt_marca_ar.Location = new System.Drawing.Point(539, 12);
            this.Txt_marca_ar.Name = "Txt_marca_ar";
            this.Txt_marca_ar.Size = new System.Drawing.Size(264, 20);
            this.Txt_marca_ar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca:";
            // 
            // Txt_descripcion_um
            // 
            this.Txt_descripcion_um.Location = new System.Drawing.Point(75, 67);
            this.Txt_descripcion_um.Name = "Txt_descripcion_um";
            this.Txt_descripcion_um.Size = new System.Drawing.Size(200, 20);
            this.Txt_descripcion_um.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medida:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = ":::";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(745, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = ":::";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Txt_descripcion_ca
            // 
            this.Txt_descripcion_ca.Location = new System.Drawing.Point(539, 67);
            this.Txt_descripcion_ca.Name = "Txt_descripcion_ca";
            this.Txt_descripcion_ca.Size = new System.Drawing.Size(200, 20);
            this.Txt_descripcion_ca.TabIndex = 9;
            this.Txt_descripcion_ca.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoria:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Txt_stock_actual
            // 
            this.Txt_stock_actual.Location = new System.Drawing.Point(359, 152);
            this.Txt_stock_actual.Name = "Txt_stock_actual";
            this.Txt_stock_actual.Size = new System.Drawing.Size(200, 20);
            this.Txt_stock_actual.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stock Actual:";
            // 
            // Frm_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 526);
            this.Controls.Add(this.Txt_stock_actual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Txt_descripcion_ca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_descripcion_um);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_marca_ar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_descripcion_ar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_articulos);
            this.Name = "Frm_articulos";
            this.Text = "Frm_articulos";
            this.Load += new System.EventHandler(this.Frm_articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_articulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_descripcion_ar;
        private System.Windows.Forms.TextBox Txt_marca_ar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_descripcion_um;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Txt_descripcion_ca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_stock_actual;
        private System.Windows.Forms.Label label5;
    }
}