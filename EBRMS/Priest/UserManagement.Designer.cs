
namespace EBRMS.Priest
{
    partial class ucUserManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUserManagement));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvUsers = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txtViewUsers = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAddUser = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowCustomTheming = false;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 40;
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsers.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvUsers.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvUsers.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvUsers.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvUsers.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsers.CurrentTheme.Name = null;
            this.dgvUsers.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvUsers.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvUsers.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvUsers.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvUsers.HeaderForeColor = System.Drawing.Color.White;
            this.dgvUsers.Location = new System.Drawing.Point(57, 295);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 40;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1176, 518);
            this.dgvUsers.TabIndex = 13;
            this.dgvUsers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // txtViewUsers
            // 
            this.txtViewUsers.AcceptsReturn = false;
            this.txtViewUsers.AcceptsTab = false;
            this.txtViewUsers.AnimationSpeed = 200;
            this.txtViewUsers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtViewUsers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtViewUsers.BackColor = System.Drawing.Color.Transparent;
            this.txtViewUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtViewUsers.BackgroundImage")));
            this.txtViewUsers.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtViewUsers.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtViewUsers.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtViewUsers.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtViewUsers.BorderRadius = 10;
            this.txtViewUsers.BorderThickness = 1;
            this.txtViewUsers.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtViewUsers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtViewUsers.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtViewUsers.DefaultText = "";
            this.txtViewUsers.FillColor = System.Drawing.Color.White;
            this.txtViewUsers.HideSelection = true;
            this.txtViewUsers.IconLeft = null;
            this.txtViewUsers.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtViewUsers.IconPadding = 10;
            this.txtViewUsers.IconRight = null;
            this.txtViewUsers.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtViewUsers.Lines = new string[0];
            this.txtViewUsers.Location = new System.Drawing.Point(57, 182);
            this.txtViewUsers.Margin = new System.Windows.Forms.Padding(4);
            this.txtViewUsers.MaxLength = 32767;
            this.txtViewUsers.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtViewUsers.Modified = false;
            this.txtViewUsers.Multiline = false;
            this.txtViewUsers.Name = "txtViewUsers";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtViewUsers.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtViewUsers.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtViewUsers.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtViewUsers.OnIdleState = stateProperties4;
            this.txtViewUsers.Padding = new System.Windows.Forms.Padding(4);
            this.txtViewUsers.PasswordChar = '\0';
            this.txtViewUsers.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtViewUsers.PlaceholderText = "Search Users";
            this.txtViewUsers.ReadOnly = false;
            this.txtViewUsers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtViewUsers.SelectedText = "";
            this.txtViewUsers.SelectionLength = 0;
            this.txtViewUsers.SelectionStart = 0;
            this.txtViewUsers.ShortcutsEnabled = true;
            this.txtViewUsers.Size = new System.Drawing.Size(1017, 46);
            this.txtViewUsers.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtViewUsers.TabIndex = 11;
            this.txtViewUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtViewUsers.TextMarginBottom = 0;
            this.txtViewUsers.TextMarginLeft = 3;
            this.txtViewUsers.TextMarginTop = 0;
            this.txtViewUsers.TextPlaceholder = "Search Users";
            this.txtViewUsers.UseSystemPasswordChar = false;
            this.txtViewUsers.WordWrap = true;
            this.txtViewUsers.TextChange += new System.EventHandler(this.txtViewUsers_TextChange);
            // 
            // btnAddUser
            // 
            this.btnAddUser.AllowAnimations = true;
            this.btnAddUser.AllowMouseEffects = true;
            this.btnAddUser.AllowToggling = false;
            this.btnAddUser.AnimationSpeed = 200;
            this.btnAddUser.AutoGenerateColors = false;
            this.btnAddUser.AutoRoundBorders = false;
            this.btnAddUser.AutoSizeLeftIcon = true;
            this.btnAddUser.AutoSizeRightIcon = true;
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.BackgroundImage")));
            this.btnAddUser.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddUser.ButtonText = "Add User";
            this.btnAddUser.ButtonTextMarginLeft = 0;
            this.btnAddUser.ColorContrastOnClick = 45;
            this.btnAddUser.ColorContrastOnHover = 45;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddUser.CustomizableEdges = borderEdges1;
            this.btnAddUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddUser.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddUser.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddUser.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddUser.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddUser.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddUser.IconMarginLeft = 11;
            this.btnAddUser.IconPadding = 10;
            this.btnAddUser.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddUser.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddUser.IconSize = 25;
            this.btnAddUser.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUser.IdleBorderRadius = 10;
            this.btnAddUser.IdleBorderThickness = 1;
            this.btnAddUser.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUser.IdleIconLeftImage = null;
            this.btnAddUser.IdleIconRightImage = null;
            this.btnAddUser.IndicateFocus = false;
            this.btnAddUser.Location = new System.Drawing.Point(1099, 180);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddUser.OnDisabledState.BorderRadius = 10;
            this.btnAddUser.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddUser.OnDisabledState.BorderThickness = 1;
            this.btnAddUser.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddUser.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddUser.OnDisabledState.IconLeftImage = null;
            this.btnAddUser.OnDisabledState.IconRightImage = null;
            this.btnAddUser.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddUser.onHoverState.BorderRadius = 10;
            this.btnAddUser.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddUser.onHoverState.BorderThickness = 1;
            this.btnAddUser.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddUser.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.onHoverState.IconLeftImage = null;
            this.btnAddUser.onHoverState.IconRightImage = null;
            this.btnAddUser.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUser.OnIdleState.BorderRadius = 10;
            this.btnAddUser.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddUser.OnIdleState.BorderThickness = 1;
            this.btnAddUser.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUser.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.OnIdleState.IconLeftImage = null;
            this.btnAddUser.OnIdleState.IconRightImage = null;
            this.btnAddUser.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddUser.OnPressedState.BorderRadius = 10;
            this.btnAddUser.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddUser.OnPressedState.BorderThickness = 1;
            this.btnAddUser.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddUser.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.OnPressedState.IconLeftImage = null;
            this.btnAddUser.OnPressedState.IconRightImage = null;
            this.btnAddUser.Size = new System.Drawing.Size(135, 48);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddUser.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddUser.TextMarginLeft = 0;
            this.btnAddUser.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddUser.UseDefaultRadiusAndThickness = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 75);
            this.label2.TabIndex = 14;
            this.label2.Text = "USER MANAGEMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "List of Users";
            // 
            // ucUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.txtViewUsers);
            this.Controls.Add(this.btnAddUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucUserManagement";
            this.Size = new System.Drawing.Size(1301, 911);
            this.Load += new System.EventHandler(this.ucUserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddUser;
        private Bunifu.UI.WinForms.BunifuTextBox txtViewUsers;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvUsers;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
