
namespace EBRMS.Priest
{
    partial class frmMainPriest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPriest));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserName = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserRole = new Bunifu.UI.WinForms.BunifuLabel();
            this.panelModule = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.btnSchedules = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnUsers = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pbLogout);
            this.panel1.Controls.Add(this.btnSchedules);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-5, -15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 1010);
            this.panel1.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AllowParentOverrides = false;
            this.lblUserName.AutoEllipsis = false;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUserName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(1468, 38);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserName.Size = new System.Drawing.Size(79, 21);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "user name";
            this.lblUserName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUserName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.lblUserRole);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Location = new System.Drawing.Point(-1, -11);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1715, 98);
            this.panel2.TabIndex = 13;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AllowParentOverrides = false;
            this.lblUserRole.AutoEllipsis = false;
            this.lblUserRole.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUserRole.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.White;
            this.lblUserRole.Location = new System.Drawing.Point(1475, 59);
            this.lblUserRole.Margin = new System.Windows.Forms.Padding(4);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserRole.Size = new System.Drawing.Size(66, 21);
            this.lblUserRole.TabIndex = 13;
            this.lblUserRole.Text = "user role";
            this.lblUserRole.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUserRole.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panelModule
            // 
            this.panelModule.BackColor = System.Drawing.SystemColors.Control;
            this.panelModule.Location = new System.Drawing.Point(408, 81);
            this.panelModule.Margin = new System.Windows.Forms.Padding(4);
            this.panelModule.Name = "panelModule";
            this.panelModule.Size = new System.Drawing.Size(1301, 900);
            this.panelModule.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EBRMS.Properties.Resources.R;
            this.pictureBox3.Location = new System.Drawing.Point(1617, 32);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pbLogout
            // 
            this.pbLogout.Image = global::EBRMS.Properties.Resources.e17b07ddedc0cf14c89e0702946475c5;
            this.pbLogout.Location = new System.Drawing.Point(21, 873);
            this.pbLogout.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(53, 50);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogout.TabIndex = 11;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // btnSchedules
            // 
            this.btnSchedules.AllowAnimations = true;
            this.btnSchedules.AllowMouseEffects = true;
            this.btnSchedules.AllowToggling = false;
            this.btnSchedules.AnimationSpeed = 200;
            this.btnSchedules.AutoGenerateColors = false;
            this.btnSchedules.AutoRoundBorders = false;
            this.btnSchedules.AutoSizeLeftIcon = true;
            this.btnSchedules.AutoSizeRightIcon = true;
            this.btnSchedules.BackColor = System.Drawing.Color.Transparent;
            this.btnSchedules.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnSchedules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSchedules.BackgroundImage")));
            this.btnSchedules.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSchedules.ButtonText = "Schedule \r\nManagement";
            this.btnSchedules.ButtonTextMarginLeft = 0;
            this.btnSchedules.ColorContrastOnClick = 45;
            this.btnSchedules.ColorContrastOnHover = 45;
            this.btnSchedules.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSchedules.CustomizableEdges = borderEdges3;
            this.btnSchedules.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSchedules.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSchedules.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSchedules.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSchedules.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSchedules.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.btnSchedules.ForeColor = System.Drawing.Color.White;
            this.btnSchedules.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedules.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSchedules.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSchedules.IconMarginLeft = 11;
            this.btnSchedules.IconPadding = 10;
            this.btnSchedules.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSchedules.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSchedules.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSchedules.IconSize = 25;
            this.btnSchedules.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSchedules.IdleBorderRadius = 20;
            this.btnSchedules.IdleBorderThickness = 1;
            this.btnSchedules.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSchedules.IdleIconLeftImage = null;
            this.btnSchedules.IdleIconRightImage = null;
            this.btnSchedules.IndicateFocus = false;
            this.btnSchedules.Location = new System.Drawing.Point(63, 708);
            this.btnSchedules.Margin = new System.Windows.Forms.Padding(4);
            this.btnSchedules.Name = "btnSchedules";
            this.btnSchedules.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSchedules.OnDisabledState.BorderRadius = 20;
            this.btnSchedules.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSchedules.OnDisabledState.BorderThickness = 1;
            this.btnSchedules.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSchedules.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSchedules.OnDisabledState.IconLeftImage = null;
            this.btnSchedules.OnDisabledState.IconRightImage = null;
            this.btnSchedules.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSchedules.onHoverState.BorderRadius = 20;
            this.btnSchedules.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSchedules.onHoverState.BorderThickness = 1;
            this.btnSchedules.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSchedules.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSchedules.onHoverState.IconLeftImage = null;
            this.btnSchedules.onHoverState.IconRightImage = null;
            this.btnSchedules.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSchedules.OnIdleState.BorderRadius = 20;
            this.btnSchedules.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSchedules.OnIdleState.BorderThickness = 1;
            this.btnSchedules.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSchedules.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSchedules.OnIdleState.IconLeftImage = null;
            this.btnSchedules.OnIdleState.IconRightImage = null;
            this.btnSchedules.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSchedules.OnPressedState.BorderRadius = 20;
            this.btnSchedules.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSchedules.OnPressedState.BorderThickness = 1;
            this.btnSchedules.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSchedules.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSchedules.OnPressedState.IconLeftImage = null;
            this.btnSchedules.OnPressedState.IconRightImage = null;
            this.btnSchedules.Size = new System.Drawing.Size(300, 85);
            this.btnSchedules.TabIndex = 10;
            this.btnSchedules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSchedules.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSchedules.TextMarginLeft = 0;
            this.btnSchedules.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSchedules.UseDefaultRadiusAndThickness = true;
            this.btnSchedules.Click += new System.EventHandler(this.btnSchedules_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.AllowAnimations = true;
            this.btnUsers.AllowMouseEffects = true;
            this.btnUsers.AllowToggling = false;
            this.btnUsers.AnimationSpeed = 200;
            this.btnUsers.AutoGenerateColors = false;
            this.btnUsers.AutoRoundBorders = false;
            this.btnUsers.AutoSizeLeftIcon = true;
            this.btnUsers.AutoSizeRightIcon = true;
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.BackgroundImage")));
            this.btnUsers.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.ButtonText = "User Management";
            this.btnUsers.ButtonTextMarginLeft = 0;
            this.btnUsers.ColorContrastOnClick = 45;
            this.btnUsers.ColorContrastOnHover = 45;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnUsers.CustomizableEdges = borderEdges4;
            this.btnUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUsers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUsers.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUsers.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUsers.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUsers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUsers.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUsers.IconMarginLeft = 11;
            this.btnUsers.IconPadding = 10;
            this.btnUsers.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUsers.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUsers.IconSize = 25;
            this.btnUsers.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUsers.IdleBorderRadius = 20;
            this.btnUsers.IdleBorderThickness = 1;
            this.btnUsers.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnUsers.IdleIconLeftImage = null;
            this.btnUsers.IdleIconRightImage = null;
            this.btnUsers.IndicateFocus = false;
            this.btnUsers.Location = new System.Drawing.Point(63, 597);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUsers.OnDisabledState.BorderRadius = 20;
            this.btnUsers.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.OnDisabledState.BorderThickness = 1;
            this.btnUsers.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUsers.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUsers.OnDisabledState.IconLeftImage = null;
            this.btnUsers.OnDisabledState.IconRightImage = null;
            this.btnUsers.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnUsers.onHoverState.BorderRadius = 20;
            this.btnUsers.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.onHoverState.BorderThickness = 1;
            this.btnUsers.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnUsers.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUsers.onHoverState.IconLeftImage = null;
            this.btnUsers.onHoverState.IconRightImage = null;
            this.btnUsers.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUsers.OnIdleState.BorderRadius = 20;
            this.btnUsers.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.OnIdleState.BorderThickness = 1;
            this.btnUsers.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnUsers.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnUsers.OnIdleState.IconLeftImage = null;
            this.btnUsers.OnIdleState.IconRightImage = null;
            this.btnUsers.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnUsers.OnPressedState.BorderRadius = 20;
            this.btnUsers.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.OnPressedState.BorderThickness = 1;
            this.btnUsers.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnUsers.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUsers.OnPressedState.IconLeftImage = null;
            this.btnUsers.OnPressedState.IconRightImage = null;
            this.btnUsers.Size = new System.Drawing.Size(300, 85);
            this.btnUsers.TabIndex = 9;
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUsers.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUsers.TextMarginLeft = 0;
            this.btnUsers.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUsers.UseDefaultRadiusAndThickness = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EBRMS.Properties.Resources.received_632071118312447;
            this.pictureBox2.Location = new System.Drawing.Point(21, 129);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 289);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 96);
            this.label2.TabIndex = 14;
            this.label2.Text = "OUR LADY \r\nOF HOPE PARISH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMainPriest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 985);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelModule);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainPriest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Priest Mainform";
            this.Load += new System.EventHandler(this.frmMainPriest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbLogout;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSchedules;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUsers;
        private Bunifu.UI.WinForms.BunifuLabel lblUserName;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel lblUserRole;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelModule;
        private System.Windows.Forms.Label label2;
    }
}