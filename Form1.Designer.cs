namespace ADONET
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
            this.btnListarProductos = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnListarProductosUsuario = new System.Windows.Forms.Button();
            this.btnListarProductosUsing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.Location = new System.Drawing.Point(29, 26);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(117, 44);
            this.btnListarProductos.TabIndex = 0;
            this.btnListarProductos.Text = "Listar Productos";
            this.btnListarProductos.UseVisualStyleBackColor = true;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(29, 103);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(741, 318);
            this.dgvProductos.TabIndex = 1;
            // 
            // btnListarProductosUsuario
            // 
            this.btnListarProductosUsuario.Location = new System.Drawing.Point(225, 26);
            this.btnListarProductosUsuario.Name = "btnListarProductosUsuario";
            this.btnListarProductosUsuario.Size = new System.Drawing.Size(146, 43);
            this.btnListarProductosUsuario.TabIndex = 2;
            this.btnListarProductosUsuario.Text = "Listar Productos con Usuario";
            this.btnListarProductosUsuario.UseVisualStyleBackColor = true;
            this.btnListarProductosUsuario.Click += new System.EventHandler(this.btnListarProductosUsuario_Click);
            // 
            // btnListarProductosUsing
            // 
            this.btnListarProductosUsing.Location = new System.Drawing.Point(438, 26);
            this.btnListarProductosUsing.Name = "btnListarProductosUsing";
            this.btnListarProductosUsing.Size = new System.Drawing.Size(133, 44);
            this.btnListarProductosUsing.TabIndex = 3;
            this.btnListarProductosUsing.Text = "Listar Productos con USING";
            this.btnListarProductosUsing.UseVisualStyleBackColor = true;
            this.btnListarProductosUsing.Click += new System.EventHandler(this.btnListarProductosUsing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarProductosUsing);
            this.Controls.Add(this.btnListarProductosUsuario);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnListarProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnListarProductosUsuario;
        private System.Windows.Forms.Button btnListarProductosUsing;
    }
}

