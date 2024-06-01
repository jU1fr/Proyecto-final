namespace RM.Model
{
    partial class frmProductAdd
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cbCat = new Guna.UI2.WinForms.Guna2ComboBox();
            label4 = new Label();
            txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            txtImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtImage).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2Panel1.Size = new Size(800, 100);
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.Image = Properties.Resources.pngwing_com__12_;
            guna2PictureBox1.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Location = new Point(0, 379);
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel2.Size = new Size(800, 71);
            // 
            // label1
            // 
            label1.Size = new Size(169, 25);
            label1.Text = "Detalles Productos";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.None;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.None;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges5;
            // 
            // cbCat
            // 
            cbCat.BackColor = Color.Transparent;
            cbCat.CustomizableEdges = customizableEdges6;
            cbCat.DrawMode = DrawMode.OwnerDrawFixed;
            cbCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCat.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCat.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCat.Font = new Font("Segoe UI", 10F);
            cbCat.ForeColor = Color.FromArgb(68, 88, 112);
            cbCat.ItemHeight = 30;
            cbCat.Location = new Point(44, 256);
            cbCat.Name = "cbCat";
            cbCat.ShadowDecoration.CustomizableEdges = customizableEdges7;
            cbCat.Size = new Size(244, 36);
            cbCat.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 226);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 13;
            label4.Text = "Categoria";
            // 
            // txtPrice
            // 
            txtPrice.CustomizableEdges = customizableEdges8;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Font = new Font("Segoe UI", 9F);
            txtPrice.ForeColor = Color.FromArgb(64, 64, 64);
            txtPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Location = new Point(321, 166);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderText = "";
            txtPrice.SelectedText = "";
            txtPrice.ShadowDecoration.CustomizableEdges = customizableEdges9;
            txtPrice.Size = new Size(244, 36);
            txtPrice.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 146);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 12;
            label3.Text = "Precio";
            // 
            // txtName
            // 
            txtName.CustomizableEdges = customizableEdges10;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.ForeColor = Color.FromArgb(64, 64, 64);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(44, 166);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges11;
            txtName.Size = new Size(244, 36);
            txtName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 146);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // txtImage
            // 
            txtImage.Image = Properties.Resources.pngwing_com__13_;
            txtImage.ImageRotate = 0F;
            txtImage.Location = new Point(608, 146);
            txtImage.Name = "txtImage";
            txtImage.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            txtImage.Size = new Size(141, 145);
            txtImage.SizeMode = PictureBoxSizeMode.Zoom;
            txtImage.TabIndex = 14;
            txtImage.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.AutoRoundedCorners = true;
            btnBrowse.BorderRadius = 21;
            btnBrowse.CustomizableEdges = customizableEdges13;
            btnBrowse.DisabledState.BorderColor = Color.DarkGray;
            btnBrowse.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBrowse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBrowse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBrowse.Font = new Font("Segoe UI", 9F);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(608, 297);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnBrowse.Size = new Size(141, 45);
            btnBrowse.TabIndex = 15;
            btnBrowse.Text = "Buscar";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // frmProductAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBrowse);
            Controls.Add(txtImage);
            Controls.Add(cbCat);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Name = "frmProductAdd";
            Text = "frmProductAdd";
            Load += frmProductAdd_Load;
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(guna2Panel2, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtPrice, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(cbCat, 0);
            Controls.SetChildIndex(txtImage, 0);
            Controls.SetChildIndex(btnBrowse, 0);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Guna.UI2.WinForms.Guna2ComboBox cbCat;
        private Label label4;
        public Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Label label3;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox txtImage;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
    }
}