namespace RM.Model
{
    partial class ucProduct
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            panel1 = new Panel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            lblName = new Label();
            txtImage = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2ShadowPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtImage).BeginInit();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(panel1);
            guna2ShadowPanel1.Controls.Add(txtImage);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(3, 3);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(174, 178);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(guna2Separator1);
            panel1.Controls.Add(lblName);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 52);
            panel1.TabIndex = 1;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(5, 0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(165, 10);
            guna2Separator1.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(9, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(158, 43);
            lblName.TabIndex = 2;
            lblName.Text = "Product Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtImage
            // 
            txtImage.CustomizableEdges = customizableEdges1;
            txtImage.Image = Properties.Resources.pngwing_com__25_;
            txtImage.ImageRotate = 0F;
            txtImage.Location = new Point(39, 27);
            txtImage.Name = "txtImage";
            txtImage.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtImage.Size = new Size(96, 81);
            txtImage.SizeMode = PictureBoxSizeMode.Zoom;
            txtImage.TabIndex = 0;
            txtImage.TabStop = false;
            txtImage.Click += txtImage_Click;
            // 
            // ucProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(guna2ShadowPanel1);
            Name = "ucProduct";
            Size = new Size(180, 184);
            guna2ShadowPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Panel panel1;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2PictureBox txtImage;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
