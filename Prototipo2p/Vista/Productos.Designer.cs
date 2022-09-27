
namespace Vista
{
    partial class Productos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdescri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(545, 101);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(147, 41);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(235, 22);
            this.txtBusqueda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtmarca);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtcategoria);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtdescri);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtnombre);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(13, 136);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(545, 200);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Personales";
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(178, 121);
            this.txtcategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(285, 22);
            this.txtcategoria.TabIndex = 7;
            this.txtcategoria.Tag = "Categoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Categoria";
            // 
            // txtdescri
            // 
            this.txtdescri.Location = new System.Drawing.Point(178, 82);
            this.txtdescri.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescri.Name = "txtdescri";
            this.txtdescri.Size = new System.Drawing.Size(285, 22);
            this.txtdescri.TabIndex = 5;
            this.txtdescri.Tag = "descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descripcion";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(178, 41);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(285, 22);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.Tag = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(178, 166);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(285, 22);
            this.txtmarca.TabIndex = 9;
            this.txtmarca.Tag = "marca";
            this.txtmarca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marca";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 241);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(605, 108);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(103, 43);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(605, 214);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(103, 43);
            this.btnmodificar.TabIndex = 10;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(605, 340);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(103, 43);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnver
            // 
            this.btnver.Location = new System.Drawing.Point(605, 464);
            this.btnver.Margin = new System.Windows.Forms.Padding(4);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(103, 43);
            this.btnver.TabIndex = 12;
            this.btnver.Text = "Visualizar";
            this.btnver.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 624);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Productos";
            this.Text = "Productos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdescri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnver;
    }
}