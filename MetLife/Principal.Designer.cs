namespace MetLife
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGestorMovil = new System.Windows.Forms.TabPage();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpInicioSesion = new System.Windows.Forms.GroupBox();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.tabGrupoRegio = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbrirArchivo2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasena2 = new System.Windows.Forms.TextBox();
            this.txtUsuario2 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabGestorMovil.SuspendLayout();
            this.grpInicioSesion.SuspendLayout();
            this.tabGrupoRegio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Abrir";
            this.openFileDialog1.Filter = "Archivos Excel (* .xlsx)|*.xlsx";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "|*.xlsx";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGestorMovil);
            this.tabControl.Controls.Add(this.tabGrupoRegio);
            this.tabControl.Location = new System.Drawing.Point(12, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(426, 156);
            this.tabControl.TabIndex = 0;
            // 
            // tabGestorMovil
            // 
            this.tabGestorMovil.Controls.Add(this.txtActual);
            this.tabGestorMovil.Controls.Add(this.txtTotal);
            this.tabGestorMovil.Controls.Add(this.label4);
            this.tabGestorMovil.Controls.Add(this.grpInicioSesion);
            this.tabGestorMovil.Location = new System.Drawing.Point(4, 22);
            this.tabGestorMovil.Name = "tabGestorMovil";
            this.tabGestorMovil.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestorMovil.Size = new System.Drawing.Size(418, 130);
            this.tabGestorMovil.TabIndex = 0;
            this.tabGestorMovil.Text = "Gestor Móvil";
            this.tabGestorMovil.UseVisualStyleBackColor = true;
            this.tabGestorMovil.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtActual
            // 
            this.txtActual.Location = new System.Drawing.Point(101, 98);
            this.txtActual.Name = "txtActual";
            this.txtActual.ReadOnly = true;
            this.txtActual.Size = new System.Drawing.Size(52, 20);
            this.txtActual.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(191, 98);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(52, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "/";
            // 
            // grpInicioSesion
            // 
            this.grpInicioSesion.Controls.Add(this.btnAbrirArchivo);
            this.grpInicioSesion.Controls.Add(this.lblUsuario);
            this.grpInicioSesion.Controls.Add(this.lblContrasena);
            this.grpInicioSesion.Controls.Add(this.txtContrasena);
            this.grpInicioSesion.Controls.Add(this.txtUsuario);
            this.grpInicioSesion.Location = new System.Drawing.Point(3, 20);
            this.grpInicioSesion.Name = "grpInicioSesion";
            this.grpInicioSesion.Size = new System.Drawing.Size(409, 72);
            this.grpInicioSesion.TabIndex = 1;
            this.grpInicioSesion.TabStop = false;
            this.grpInicioSesion.Text = "Inicio de sesión";
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArchivo.Location = new System.Drawing.Point(286, 16);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(113, 48);
            this.btnAbrirArchivo.TabIndex = 3;
            this.btnAbrirArchivo.Text = "Abrir archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click_1);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(15, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(15, 48);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(77, 16);
            this.lblContrasena.TabIndex = 1;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(98, 42);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(167, 22);
            this.txtContrasena.TabIndex = 2;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(98, 16);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(167, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // tabGrupoRegio
            // 
            this.tabGrupoRegio.Controls.Add(this.groupBox1);
            this.tabGrupoRegio.Location = new System.Drawing.Point(4, 22);
            this.tabGrupoRegio.Name = "tabGrupoRegio";
            this.tabGrupoRegio.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrupoRegio.Size = new System.Drawing.Size(418, 130);
            this.tabGrupoRegio.TabIndex = 1;
            this.tabGrupoRegio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAbrirArchivo2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtContrasena2);
            this.groupBox1.Controls.Add(this.txtUsuario2);
            this.groupBox1.Location = new System.Drawing.Point(3, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio de sesión";
            // 
            // btnAbrirArchivo2
            // 
            this.btnAbrirArchivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArchivo2.Location = new System.Drawing.Point(286, 16);
            this.btnAbrirArchivo2.Name = "btnAbrirArchivo2";
            this.btnAbrirArchivo2.Size = new System.Drawing.Size(113, 48);
            this.btnAbrirArchivo2.TabIndex = 3;
            this.btnAbrirArchivo2.Text = "Abrir archivo";
            this.btnAbrirArchivo2.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo2.Click += new System.EventHandler(this.btnAbrirArchivo2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txtContrasena2
            // 
            this.txtContrasena2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena2.Location = new System.Drawing.Point(98, 42);
            this.txtContrasena2.Name = "txtContrasena2";
            this.txtContrasena2.PasswordChar = '*';
            this.txtContrasena2.Size = new System.Drawing.Size(167, 22);
            this.txtContrasena2.TabIndex = 2;
            // 
            // txtUsuario2
            // 
            this.txtUsuario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario2.Location = new System.Drawing.Point(98, 16);
            this.txtUsuario2.Name = "txtUsuario2";
            this.txtUsuario2.Size = new System.Drawing.Size(167, 22);
            this.txtUsuario2.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "MetLife-Automatic";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarToolStripMenuItem,
            this.minimizarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 70);
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.minimizarToolStripMenuItem.Text = "Minimizar";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(471, 166);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.SizeChanged += new System.EventHandler(this.Principal_SizeChanged);
            this.tabControl.ResumeLayout(false);
            this.tabGestorMovil.ResumeLayout(false);
            this.tabGestorMovil.PerformLayout();
            this.grpInicioSesion.ResumeLayout(false);
            this.grpInicioSesion.PerformLayout();
            this.tabGrupoRegio.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGestorMovil;
        private System.Windows.Forms.GroupBox grpInicioSesion;
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TabPage tabGrupoRegio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAbrirArchivo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasena2;
        private System.Windows.Forms.TextBox txtUsuario2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

