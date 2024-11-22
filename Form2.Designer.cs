namespace ADONET
{
    partial class Form2
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
            this.dgvPedidoCompania = new System.Windows.Forms.DataGridView();
            this.btnListarPedidoCompañia = new System.Windows.Forms.Button();
            this.btnListarCategorias = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoCompania)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidoCompania
            // 
            this.dgvPedidoCompania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoCompania.Location = new System.Drawing.Point(45, 100);
            this.dgvPedidoCompania.Name = "dgvPedidoCompania";
            this.dgvPedidoCompania.Size = new System.Drawing.Size(698, 276);
            this.dgvPedidoCompania.TabIndex = 0;
            // 
            // btnListarPedidoCompañia
            // 
            this.btnListarPedidoCompañia.Location = new System.Drawing.Point(609, 33);
            this.btnListarPedidoCompañia.Name = "btnListarPedidoCompañia";
            this.btnListarPedidoCompañia.Size = new System.Drawing.Size(134, 53);
            this.btnListarPedidoCompañia.TabIndex = 1;
            this.btnListarPedidoCompañia.Text = "Listar Pedido-Compañia";
            this.btnListarPedidoCompañia.UseVisualStyleBackColor = true;
            this.btnListarPedidoCompañia.Click += new System.EventHandler(this.btnListarPedidoCompañia_Click);
            // 
            // btnListarCategorias
            // 
            this.btnListarCategorias.Location = new System.Drawing.Point(487, 38);
            this.btnListarCategorias.Name = "btnListarCategorias";
            this.btnListarCategorias.Size = new System.Drawing.Size(78, 48);
            this.btnListarCategorias.TabIndex = 2;
            this.btnListarCategorias.Text = "Listar Categorias";
            this.btnListarCategorias.UseVisualStyleBackColor = true;
            this.btnListarCategorias.Click += new System.EventHandler(this.btnListarCategorias_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(54, 50);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(63, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(262, 50);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(126, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripción";
            // 
            // btnInsertarCategoria
            // 
            this.btnInsertarCategoria.Location = new System.Drawing.Point(406, 38);
            this.btnInsertarCategoria.Name = "btnInsertarCategoria";
            this.btnInsertarCategoria.Size = new System.Drawing.Size(75, 48);
            this.btnInsertarCategoria.TabIndex = 9;
            this.btnInsertarCategoria.Text = "Insertar Categoría";
            this.btnInsertarCategoria.UseVisualStyleBackColor = true;
            this.btnInsertarCategoria.Click += new System.EventHandler(this.btnInsertarCategoria_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertarCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnListarCategorias);
            this.Controls.Add(this.btnListarPedidoCompañia);
            this.Controls.Add(this.dgvPedidoCompania);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoCompania)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidoCompania;
        private System.Windows.Forms.Button btnListarPedidoCompañia;
        private System.Windows.Forms.Button btnListarCategorias;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertarCategoria;
    }
}