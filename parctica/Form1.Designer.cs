namespace parctica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnon = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.txtCorr = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModi = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvCli = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnadi = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCe = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnmax = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnmini = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmini)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(318, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABLA CLIENTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEFONO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "CORREO:";
            // 
            // txtnon
            // 
            this.txtnon.Location = new System.Drawing.Point(212, 92);
            this.txtnon.Name = "txtnon";
            this.txtnon.Size = new System.Drawing.Size(100, 20);
            this.txtnon.TabIndex = 5;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(212, 128);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(100, 20);
            this.txtApe.TabIndex = 6;
            // 
            // txtTele
            // 
            this.txtTele.Location = new System.Drawing.Point(212, 162);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(100, 20);
            this.txtTele.TabIndex = 7;
            // 
            // txtCorr
            // 
            this.txtCorr.Location = new System.Drawing.Point(212, 202);
            this.txtCorr.Name = "txtCorr";
            this.txtCorr.Size = new System.Drawing.Size(100, 20);
            this.txtCorr.TabIndex = 8;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(100, 295);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(109, 38);
            this.btnInsertar.TabIndex = 9;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModi
            // 
            this.btnModi.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModi.Location = new System.Drawing.Point(222, 295);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(109, 38);
            this.btnModi.TabIndex = 10;
            this.btnModi.Text = "MODIFICAR";
            this.btnModi.UseVisualStyleBackColor = true;
            this.btnModi.Click += new System.EventHandler(this.btnModi_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(351, 295);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 38);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvCli
            // 
            this.dgvCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCli.Location = new System.Drawing.Point(59, 366);
            this.dgvCli.Name = "dgvCli";
            this.dgvCli.Size = new System.Drawing.Size(624, 216);
            this.dgvCli.TabIndex = 12;
            this.dgvCli.SelectionChanged += new System.EventHandler(this.dgvCli_SelectionChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(212, 240);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID:";
            // 
            // btnadi
            // 
            this.btnadi.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadi.Location = new System.Drawing.Point(705, 544);
            this.btnadi.Name = "btnadi";
            this.btnadi.Size = new System.Drawing.Size(109, 38);
            this.btnadi.TabIndex = 15;
            this.btnadi.Text = "ADICIONAR";
            this.btnadi.UseVisualStyleBackColor = true;
            this.btnadi.Click += new System.EventHandler(this.btnadi_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(536, 92);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 18;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "BUSCAR USUARIOS:";
            // 
            // btnCe
            // 
            this.btnCe.BackColor = System.Drawing.Color.Transparent;
            this.btnCe.Image = ((System.Drawing.Image)(resources.GetObject("btnCe.Image")));
            this.btnCe.ImageActive = null;
            this.btnCe.Location = new System.Drawing.Point(854, 3);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(50, 50);
            this.btnCe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCe.TabIndex = 19;
            this.btnCe.TabStop = false;
            this.btnCe.Zoom = 10;
            this.btnCe.Click += new System.EventHandler(this.btnCe_Click);
            // 
            // btnmax
            // 
            this.btnmax.BackColor = System.Drawing.Color.Transparent;
            this.btnmax.Image = ((System.Drawing.Image)(resources.GetObject("btnmax.Image")));
            this.btnmax.ImageActive = null;
            this.btnmax.Location = new System.Drawing.Point(798, 0);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(50, 50);
            this.btnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnmax.TabIndex = 20;
            this.btnmax.TabStop = false;
            this.btnmax.Zoom = 10;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btnmini
            // 
            this.btnmini.BackColor = System.Drawing.Color.Transparent;
            this.btnmini.Image = ((System.Drawing.Image)(resources.GetObject("btnmini.Image")));
            this.btnmini.ImageActive = null;
            this.btnmini.Location = new System.Drawing.Point(742, 0);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(50, 50);
            this.btnmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnmini.TabIndex = 21;
            this.btnmini.TabStop = false;
            this.btnmini.Zoom = 10;
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnmini);
            this.panel1.Controls.Add(this.btnCe);
            this.panel1.Controls.Add(this.btnmax);
            this.panel1.Location = new System.Drawing.Point(-12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 49);
            this.panel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(904, 644);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnadi);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvCli);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModi);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtCorr);
            this.Controls.Add(this.txtTele);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtnon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmini)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnon;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.TextBox txtCorr;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModi;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvCli;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnadi;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuImageButton btnCe;
        private Bunifu.Framework.UI.BunifuImageButton btnmax;
        private Bunifu.Framework.UI.BunifuImageButton btnmini;
        private System.Windows.Forms.Panel panel1;
    }
}

