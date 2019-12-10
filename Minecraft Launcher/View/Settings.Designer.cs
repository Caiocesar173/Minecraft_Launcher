namespace Minecraft_Launcher.View
{
    partial class Tela_Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Settings));
            this.Drag_Tela_Configurações = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Elipse_Tela_Settings = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Config_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Img_HappyLogo = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Fechar_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Salvar_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Elipse_Salvar_btn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipse_Fechar_btn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TxTBox_Altura = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxTBox_Largura = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CheckBox_FullScreen = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Label_FullScreen = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Label_Largura = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Label_Altura = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_HappyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Drag_Tela_Configurações
            // 
            this.Drag_Tela_Configurações.Fixed = true;
            this.Drag_Tela_Configurações.Horizontal = true;
            this.Drag_Tela_Configurações.TargetControl = this;
            this.Drag_Tela_Configurações.Vertical = true;
            // 
            // Elipse_Tela_Settings
            // 
            this.Elipse_Tela_Settings.ElipseRadius = 5;
            this.Elipse_Tela_Settings.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Config_btn);
            this.panel1.Controls.Add(this.Img_HappyLogo);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 448);
            this.panel1.TabIndex = 0;
            // 
            // Config_btn
            // 
            this.Config_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Config_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Config_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Config_btn.BorderRadius = 0;
            this.Config_btn.ButtonText = "Configurações do Jogo";
            this.Config_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Config_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Config_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Config_btn.Iconimage = global::Minecraft_Launcher.Properties.Resources.Controller_Icon;
            this.Config_btn.Iconimage_right = null;
            this.Config_btn.Iconimage_right_Selected = null;
            this.Config_btn.Iconimage_Selected = null;
            this.Config_btn.IconMarginLeft = 0;
            this.Config_btn.IconMarginRight = 0;
            this.Config_btn.IconRightVisible = true;
            this.Config_btn.IconRightZoom = 0D;
            this.Config_btn.IconVisible = true;
            this.Config_btn.IconZoom = 90D;
            this.Config_btn.IsTab = false;
            this.Config_btn.Location = new System.Drawing.Point(0, 137);
            this.Config_btn.Name = "Config_btn";
            this.Config_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Config_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Config_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Config_btn.selected = false;
            this.Config_btn.Size = new System.Drawing.Size(223, 65);
            this.Config_btn.TabIndex = 5;
            this.Config_btn.Text = "Configurações do Jogo";
            this.Config_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Config_btn.Textcolor = System.Drawing.Color.White;
            this.Config_btn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Img_HappyLogo
            // 
            this.Img_HappyLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_HappyLogo.Image = global::Minecraft_Launcher.Properties.Resources.Happy_Code_Logo;
            this.Img_HappyLogo.Location = new System.Drawing.Point(0, 0);
            this.Img_HappyLogo.Name = "Img_HappyLogo";
            this.Img_HappyLogo.Size = new System.Drawing.Size(223, 131);
            this.Img_HappyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_HappyLogo.TabIndex = 4;
            this.Img_HappyLogo.TabStop = false;
            this.Img_HappyLogo.Click += new System.EventHandler(this.Img_HappyLogo_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Configurações Avançadas";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 213);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(223, 65);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "Configurações Avançadas";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Fechar_btn
            // 
            this.Fechar_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Fechar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Fechar_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fechar_btn.BorderRadius = 0;
            this.Fechar_btn.ButtonText = "Fechar";
            this.Fechar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Fechar_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Fechar_btn.Iconimage = null;
            this.Fechar_btn.Iconimage_right = null;
            this.Fechar_btn.Iconimage_right_Selected = null;
            this.Fechar_btn.Iconimage_Selected = null;
            this.Fechar_btn.IconMarginLeft = 0;
            this.Fechar_btn.IconMarginRight = 0;
            this.Fechar_btn.IconRightVisible = true;
            this.Fechar_btn.IconRightZoom = 0D;
            this.Fechar_btn.IconVisible = true;
            this.Fechar_btn.IconZoom = 90D;
            this.Fechar_btn.IsTab = false;
            this.Fechar_btn.Location = new System.Drawing.Point(249, 390);
            this.Fechar_btn.Name = "Fechar_btn";
            this.Fechar_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Fechar_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Fechar_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Fechar_btn.selected = false;
            this.Fechar_btn.Size = new System.Drawing.Size(187, 48);
            this.Fechar_btn.TabIndex = 1;
            this.Fechar_btn.Text = "Fechar";
            this.Fechar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Fechar_btn.Textcolor = System.Drawing.Color.White;
            this.Fechar_btn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechar_btn.Click += new System.EventHandler(this.Fechar_btn_Click);
            // 
            // Salvar_btn
            // 
            this.Salvar_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Salvar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Salvar_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Salvar_btn.BorderRadius = 0;
            this.Salvar_btn.ButtonText = "Salvar";
            this.Salvar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salvar_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Salvar_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Salvar_btn.Iconimage = null;
            this.Salvar_btn.Iconimage_right = null;
            this.Salvar_btn.Iconimage_right_Selected = null;
            this.Salvar_btn.Iconimage_Selected = null;
            this.Salvar_btn.IconMarginLeft = 0;
            this.Salvar_btn.IconMarginRight = 0;
            this.Salvar_btn.IconRightVisible = true;
            this.Salvar_btn.IconRightZoom = 0D;
            this.Salvar_btn.IconVisible = true;
            this.Salvar_btn.IconZoom = 90D;
            this.Salvar_btn.IsTab = false;
            this.Salvar_btn.Location = new System.Drawing.Point(544, 390);
            this.Salvar_btn.Name = "Salvar_btn";
            this.Salvar_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Salvar_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Salvar_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Salvar_btn.selected = false;
            this.Salvar_btn.Size = new System.Drawing.Size(187, 48);
            this.Salvar_btn.TabIndex = 2;
            this.Salvar_btn.Text = "Salvar";
            this.Salvar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Salvar_btn.Textcolor = System.Drawing.Color.White;
            this.Salvar_btn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salvar_btn.Click += new System.EventHandler(this.Salvar_btn_Click);
            // 
            // Elipse_Salvar_btn
            // 
            this.Elipse_Salvar_btn.ElipseRadius = 15;
            this.Elipse_Salvar_btn.TargetControl = this.Salvar_btn;
            // 
            // Elipse_Fechar_btn
            // 
            this.Elipse_Fechar_btn.ElipseRadius = 15;
            this.Elipse_Fechar_btn.TargetControl = this.Fechar_btn;
            // 
            // TxTBox_Altura
            // 
            this.TxTBox_Altura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxTBox_Altura.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxTBox_Altura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxTBox_Altura.HintForeColor = System.Drawing.Color.Silver;
            this.TxTBox_Altura.HintText = "640";
            this.TxTBox_Altura.isPassword = false;
            this.TxTBox_Altura.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxTBox_Altura.LineIdleColor = System.Drawing.Color.Gray;
            this.TxTBox_Altura.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxTBox_Altura.LineThickness = 3;
            this.TxTBox_Altura.Location = new System.Drawing.Point(249, 138);
            this.TxTBox_Altura.Margin = new System.Windows.Forms.Padding(4);
            this.TxTBox_Altura.Name = "TxTBox_Altura";
            this.TxTBox_Altura.Size = new System.Drawing.Size(415, 44);
            this.TxTBox_Altura.TabIndex = 3;
            this.TxTBox_Altura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxTBox_Altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTBox_Altura_KeyPress);
            // 
            // TxTBox_Largura
            // 
            this.TxTBox_Largura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxTBox_Largura.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxTBox_Largura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxTBox_Largura.HintForeColor = System.Drawing.Color.Silver;
            this.TxTBox_Largura.HintText = "800";
            this.TxTBox_Largura.isPassword = false;
            this.TxTBox_Largura.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxTBox_Largura.LineIdleColor = System.Drawing.Color.Gray;
            this.TxTBox_Largura.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxTBox_Largura.LineThickness = 3;
            this.TxTBox_Largura.Location = new System.Drawing.Point(249, 224);
            this.TxTBox_Largura.Margin = new System.Windows.Forms.Padding(4);
            this.TxTBox_Largura.Name = "TxTBox_Largura";
            this.TxTBox_Largura.Size = new System.Drawing.Size(415, 44);
            this.TxTBox_Largura.TabIndex = 4;
            this.TxTBox_Largura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxTBox_Largura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTBox_Largura_KeyPress);
            // 
            // CheckBox_FullScreen
            // 
            this.CheckBox_FullScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckBox_FullScreen.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckBox_FullScreen.Checked = false;
            this.CheckBox_FullScreen.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CheckBox_FullScreen.ForeColor = System.Drawing.Color.White;
            this.CheckBox_FullScreen.Location = new System.Drawing.Point(644, 275);
            this.CheckBox_FullScreen.Name = "CheckBox_FullScreen";
            this.CheckBox_FullScreen.Size = new System.Drawing.Size(20, 20);
            this.CheckBox_FullScreen.TabIndex = 5;
            this.CheckBox_FullScreen.OnChange += new System.EventHandler(this.CheckBox_FullScreen_OnChange);
            // 
            // Label_FullScreen
            // 
            this.Label_FullScreen.AutoSize = true;
            this.Label_FullScreen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FullScreen.Location = new System.Drawing.Point(540, 275);
            this.Label_FullScreen.Name = "Label_FullScreen";
            this.Label_FullScreen.Size = new System.Drawing.Size(95, 21);
            this.Label_FullScreen.TabIndex = 6;
            this.Label_FullScreen.Text = "Full Screen:";
            // 
            // Label_Largura
            // 
            this.Label_Largura.AutoSize = true;
            this.Label_Largura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Largura.Location = new System.Drawing.Point(245, 214);
            this.Label_Largura.Name = "Label_Largura";
            this.Label_Largura.Size = new System.Drawing.Size(136, 21);
            this.Label_Largura.TabIndex = 7;
            this.Label_Largura.Text = "Largura da Tela:";
            // 
            // Label_Altura
            // 
            this.Label_Altura.AutoSize = true;
            this.Label_Altura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Altura.Location = new System.Drawing.Point(245, 128);
            this.Label_Altura.Name = "Label_Altura";
            this.Label_Altura.Size = new System.Drawing.Size(125, 21);
            this.Label_Altura.TabIndex = 8;
            this.Label_Altura.Text = "Altura da Tela:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Teal;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(309, 18);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(326, 33);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "Configurações de Jogo";
            // 
            // Tela_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Label_Altura);
            this.Controls.Add(this.Label_Largura);
            this.Controls.Add(this.Label_FullScreen);
            this.Controls.Add(this.CheckBox_FullScreen);
            this.Controls.Add(this.TxTBox_Largura);
            this.Controls.Add(this.TxTBox_Altura);
            this.Controls.Add(this.Salvar_btn);
            this.Controls.Add(this.Fechar_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Img_HappyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl Drag_Tela_Configurações;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Tela_Settings;
        private Bunifu.Framework.UI.BunifuFlatButton Salvar_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Fechar_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Img_HappyLogo;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Salvar_btn;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Fechar_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Config_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_FullScreen;
        private Bunifu.Framework.UI.BunifuCheckbox CheckBox_FullScreen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxTBox_Largura;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxTBox_Altura;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_Altura;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_Largura;
    }
}