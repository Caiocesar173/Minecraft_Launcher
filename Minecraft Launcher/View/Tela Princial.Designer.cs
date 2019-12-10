namespace Minecraft_Launcher
{
    partial class Tela_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.Framework.UI.BunifuImageButton Settings_Btn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Principal));
            this.Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Nick_Name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Exit_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Label_Error = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Label_ErrorVazio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Drag_TelaPrincipal = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Elipse_Login_Btn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipse_Tela_Principal = new Bunifu.Framework.UI.BunifuElipse(this.components);
            Settings_Btn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(Settings_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Settings_Btn
            // 
            Settings_Btn.BackColor = System.Drawing.Color.Transparent;
            Settings_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Settings_Btn.ErrorImage = global::Minecraft_Launcher.Properties.Resources.Settings_icon1;
            Settings_Btn.Image = global::Minecraft_Launcher.Properties.Resources.Settings_icon1;
            Settings_Btn.ImageActive = global::Minecraft_Launcher.Properties.Resources.Settings_icon1;
            Settings_Btn.InitialImage = global::Minecraft_Launcher.Properties.Resources.Settings_icon1;
            Settings_Btn.Location = new System.Drawing.Point(734, 383);
            Settings_Btn.Name = "Settings_Btn";
            Settings_Btn.Size = new System.Drawing.Size(54, 55);
            Settings_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Settings_Btn.TabIndex = 5;
            Settings_Btn.TabStop = false;
            Settings_Btn.UseWaitCursor = true;
            Settings_Btn.Zoom = 5;
            Settings_Btn.Click += new System.EventHandler(this.Settings_Btn_Click);
            // 
            // Login
            // 
            this.Login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(227)))));
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login.BorderRadius = 0;
            this.Login.ButtonText = "Login";
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.DisabledColor = System.Drawing.Color.Gray;
            this.Login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Iconcolor = System.Drawing.Color.Transparent;
            this.Login.Iconimage = null;
            this.Login.Iconimage_right = null;
            this.Login.Iconimage_right_Selected = null;
            this.Login.Iconimage_Selected = null;
            this.Login.IconMarginLeft = 0;
            this.Login.IconMarginRight = 0;
            this.Login.IconRightVisible = true;
            this.Login.IconRightZoom = 0D;
            this.Login.IconVisible = true;
            this.Login.IconZoom = 90D;
            this.Login.IsTab = false;
            this.Login.Location = new System.Drawing.Point(319, 299);
            this.Login.Margin = new System.Windows.Forms.Padding(5);
            this.Login.Name = "Login";
            this.Login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.Login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(227)))));
            this.Login.OnHoverTextColor = System.Drawing.Color.Gray;
            this.Login.selected = false;
            this.Login.Size = new System.Drawing.Size(183, 42);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login.Textcolor = System.Drawing.Color.White;
            this.Login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Nick_Name
            // 
            this.Nick_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nick_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nick_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nick_Name.HintForeColor = System.Drawing.Color.Empty;
            this.Nick_Name.HintText = "Seu Nick Name";
            this.Nick_Name.isPassword = false;
            this.Nick_Name.LineFocusedColor = System.Drawing.Color.Blue;
            this.Nick_Name.LineIdleColor = System.Drawing.Color.Gray;
            this.Nick_Name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Nick_Name.LineThickness = 3;
            this.Nick_Name.Location = new System.Drawing.Point(183, 235);
            this.Nick_Name.Margin = new System.Windows.Forms.Padding(5);
            this.Nick_Name.Name = "Nick_Name";
            this.Nick_Name.Size = new System.Drawing.Size(462, 54);
            this.Nick_Name.TabIndex = 1;
            this.Nick_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Nick_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Nick_Name_KeyDown);
            this.Nick_Name.Leave += new System.EventHandler(this.Nick_Name_Leave);
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.Exit_Btn.BackColor = System.Drawing.Color.Gainsboro;
            this.Exit_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_Btn.BorderRadius = 0;
            this.Exit_Btn.ButtonText = "x";
            this.Exit_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Btn.DisabledColor = System.Drawing.Color.Gray;
            this.Exit_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Exit_Btn.Iconimage = null;
            this.Exit_Btn.Iconimage_right = null;
            this.Exit_Btn.Iconimage_right_Selected = null;
            this.Exit_Btn.Iconimage_Selected = null;
            this.Exit_Btn.IconMarginLeft = 0;
            this.Exit_Btn.IconMarginRight = 0;
            this.Exit_Btn.IconRightVisible = true;
            this.Exit_Btn.IconRightZoom = 0D;
            this.Exit_Btn.IconVisible = true;
            this.Exit_Btn.IconZoom = 90D;
            this.Exit_Btn.IsTab = false;
            this.Exit_Btn.Location = new System.Drawing.Point(754, 2);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Normalcolor = System.Drawing.Color.Gainsboro;
            this.Exit_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.Exit_Btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Exit_Btn.selected = false;
            this.Exit_Btn.Size = new System.Drawing.Size(44, 24);
            this.Exit_Btn.TabIndex = 2;
            this.Exit_Btn.Text = "x";
            this.Exit_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_Btn.Textcolor = System.Drawing.Color.White;
            this.Exit_Btn.TextFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // Label_Error
            // 
            this.Label_Error.AutoSize = true;
            this.Label_Error.BackColor = System.Drawing.Color.Transparent;
            this.Label_Error.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Error.ForeColor = System.Drawing.Color.Red;
            this.Label_Error.Location = new System.Drawing.Point(179, 209);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(349, 19);
            this.Label_Error.TabIndex = 3;
            this.Label_Error.Text = "*Nome de Usuario não pode ser \"Username\"";
            this.Label_Error.Visible = false;
            // 
            // Label_ErrorVazio
            // 
            this.Label_ErrorVazio.AutoSize = true;
            this.Label_ErrorVazio.BackColor = System.Drawing.Color.Transparent;
            this.Label_ErrorVazio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ErrorVazio.ForeColor = System.Drawing.Color.Red;
            this.Label_ErrorVazio.Location = new System.Drawing.Point(179, 190);
            this.Label_ErrorVazio.Name = "Label_ErrorVazio";
            this.Label_ErrorVazio.Size = new System.Drawing.Size(0, 19);
            this.Label_ErrorVazio.TabIndex = 4;
            this.Label_ErrorVazio.Visible = false;
            // 
            // Drag_TelaPrincipal
            // 
            this.Drag_TelaPrincipal.Fixed = true;
            this.Drag_TelaPrincipal.Horizontal = true;
            this.Drag_TelaPrincipal.TargetControl = this;
            this.Drag_TelaPrincipal.Vertical = true;
            // 
            // Elipse_Login_Btn
            // 
            this.Elipse_Login_Btn.ElipseRadius = 15;
            this.Elipse_Login_Btn.TargetControl = this.Login;
            // 
            // Elipse_Tela_Principal
            // 
            this.Elipse_Tela_Principal.ElipseRadius = 5;
            this.Elipse_Tela_Principal.TargetControl = this;
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minecraft_Launcher.Properties.Resources.Minecraft_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(Settings_Btn);
            this.Controls.Add(this.Label_ErrorVazio);
            this.Controls.Add(this.Label_Error);
            this.Controls.Add(this.Exit_Btn);
            this.Controls.Add(this.Nick_Name);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Principal";
            this.Text = "Minecraft Launcher";
            ((System.ComponentModel.ISupportInitialize)(Settings_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton Login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Nick_Name;
        private Bunifu.Framework.UI.BunifuFlatButton Exit_Btn;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_Error;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_ErrorVazio;
        private Bunifu.Framework.UI.BunifuDragControl Drag_TelaPrincipal;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Login_Btn;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Tela_Principal;
    }
}

