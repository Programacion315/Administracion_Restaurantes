namespace AdminRestaurantes.vista
{
    partial class GUI_Primera
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
            this.btn_AgregarRestuarante = new System.Windows.Forms.Button();
            this.cb_Restuarantes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Menu = new System.Windows.Forms.ComboBox();
            this.btn_GeneraVenta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Capacidad = new System.Windows.Forms.Label();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AgregarRestuarante
            // 
            this.btn_AgregarRestuarante.Location = new System.Drawing.Point(651, 12);
            this.btn_AgregarRestuarante.Name = "btn_AgregarRestuarante";
            this.btn_AgregarRestuarante.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarRestuarante.TabIndex = 1;
            this.btn_AgregarRestuarante.Text = "Agregar";
            this.btn_AgregarRestuarante.UseVisualStyleBackColor = true;
            this.btn_AgregarRestuarante.Click += new System.EventHandler(this.btn_AgregarRestuarante_Click);
            // 
            // cb_Restuarantes
            // 
            this.cb_Restuarantes.FormattingEnabled = true;
            this.cb_Restuarantes.Location = new System.Drawing.Point(35, 27);
            this.cb_Restuarantes.Name = "cb_Restuarantes";
            this.cb_Restuarantes.Size = new System.Drawing.Size(121, 21);
            this.cb_Restuarantes.TabIndex = 2;
            this.cb_Restuarantes.Text = "Restuarantes";
            this.cb_Restuarantes.SelectedIndexChanged += new System.EventHandler(this.cb_Restuarantes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Direccion:";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Direccion.Location = new System.Drawing.Point(324, 93);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(20, 24);
            this.lbl_Direccion.TabIndex = 4;
            this.lbl_Direccion.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menu:";
            // 
            // cb_Menu
            // 
            this.cb_Menu.FormattingEnabled = true;
            this.cb_Menu.Location = new System.Drawing.Point(328, 221);
            this.cb_Menu.Name = "cb_Menu";
            this.cb_Menu.Size = new System.Drawing.Size(121, 21);
            this.cb_Menu.TabIndex = 6;
            // 
            // btn_GeneraVenta
            // 
            this.btn_GeneraVenta.Location = new System.Drawing.Point(541, 12);
            this.btn_GeneraVenta.Name = "btn_GeneraVenta";
            this.btn_GeneraVenta.Size = new System.Drawing.Size(75, 23);
            this.btn_GeneraVenta.TabIndex = 7;
            this.btn_GeneraVenta.Text = "Venta";
            this.btn_GeneraVenta.UseVisualStyleBackColor = true;
            this.btn_GeneraVenta.Click += new System.EventHandler(this.btn_GeneraVenta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Capacidad:";
            // 
            // lbl_Capacidad
            // 
            this.lbl_Capacidad.AutoSize = true;
            this.lbl_Capacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Capacidad.Location = new System.Drawing.Point(324, 157);
            this.lbl_Capacidad.Name = "lbl_Capacidad";
            this.lbl_Capacidad.Size = new System.Drawing.Size(20, 24);
            this.lbl_Capacidad.TabIndex = 9;
            this.lbl_Capacidad.Text = "?";
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Location = new System.Drawing.Point(194, 300);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(118, 23);
            this.btn_Entrar.TabIndex = 10;
            this.btn_Entrar.Text = "Entro cliente";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(346, 300);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(121, 23);
            this.btn_Salir.TabIndex = 11;
            this.btn_Salir.Text = "Salir cliente";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // GUI_Primera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(738, 354);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.lbl_Capacidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_GeneraVenta);
            this.Controls.Add(this.cb_Menu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Restuarantes);
            this.Controls.Add(this.btn_AgregarRestuarante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Primera";
            this.Text = "GUI_Primera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarRestuarante;
        private System.Windows.Forms.ComboBox cb_Restuarantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Menu;
        private System.Windows.Forms.Button btn_GeneraVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Capacidad;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button btn_Salir;
    }
}