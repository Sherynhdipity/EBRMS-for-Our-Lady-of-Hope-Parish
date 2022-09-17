
namespace EBRMS.Priest
{
    partial class ucScheduleManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucScheduleManagement));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAvailSchedule = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddDateTime = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(57, 169);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1177, 574);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvAvailSchedule);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1169, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Date and Time Schedule";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Schedule";
            // 
            // dgvAvailSchedule
            // 
            this.dgvAvailSchedule.AllowCustomTheming = false;
            this.dgvAvailSchedule.AllowUserToAddRows = false;
            this.dgvAvailSchedule.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvAvailSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvailSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvailSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAvailSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAvailSchedule.ColumnHeadersHeight = 40;
            this.dgvAvailSchedule.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvAvailSchedule.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAvailSchedule.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAvailSchedule.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAvailSchedule.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAvailSchedule.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvAvailSchedule.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAvailSchedule.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvAvailSchedule.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvAvailSchedule.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAvailSchedule.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvAvailSchedule.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAvailSchedule.CurrentTheme.Name = null;
            this.dgvAvailSchedule.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAvailSchedule.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAvailSchedule.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAvailSchedule.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAvailSchedule.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvailSchedule.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAvailSchedule.EnableHeadersVisualStyles = false;
            this.dgvAvailSchedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAvailSchedule.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvAvailSchedule.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvAvailSchedule.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAvailSchedule.Location = new System.Drawing.Point(72, 130);
            this.dgvAvailSchedule.Name = "dgvAvailSchedule";
            this.dgvAvailSchedule.ReadOnly = true;
            this.dgvAvailSchedule.RowHeadersVisible = false;
            this.dgvAvailSchedule.RowHeadersWidth = 51;
            this.dgvAvailSchedule.RowTemplate.Height = 40;
            this.dgvAvailSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailSchedule.Size = new System.Drawing.Size(1029, 345);
            this.dgvAvailSchedule.TabIndex = 0;
            this.dgvAvailSchedule.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvAvailSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailSchedule_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1169, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Booking";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddDateTime
            // 
            this.btnAddDateTime.AllowAnimations = true;
            this.btnAddDateTime.AllowMouseEffects = true;
            this.btnAddDateTime.AllowToggling = false;
            this.btnAddDateTime.AnimationSpeed = 200;
            this.btnAddDateTime.AutoGenerateColors = false;
            this.btnAddDateTime.AutoRoundBorders = false;
            this.btnAddDateTime.AutoSizeLeftIcon = true;
            this.btnAddDateTime.AutoSizeRightIcon = true;
            this.btnAddDateTime.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDateTime.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnAddDateTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDateTime.BackgroundImage")));
            this.btnAddDateTime.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDateTime.ButtonText = "Add Date and Time";
            this.btnAddDateTime.ButtonTextMarginLeft = 0;
            this.btnAddDateTime.ColorContrastOnClick = 45;
            this.btnAddDateTime.ColorContrastOnHover = 45;
            this.btnAddDateTime.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddDateTime.CustomizableEdges = borderEdges1;
            this.btnAddDateTime.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddDateTime.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddDateTime.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddDateTime.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddDateTime.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddDateTime.ForeColor = System.Drawing.Color.White;
            this.btnAddDateTime.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDateTime.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddDateTime.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddDateTime.IconMarginLeft = 11;
            this.btnAddDateTime.IconPadding = 10;
            this.btnAddDateTime.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDateTime.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddDateTime.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddDateTime.IconSize = 25;
            this.btnAddDateTime.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddDateTime.IdleBorderRadius = 1;
            this.btnAddDateTime.IdleBorderThickness = 1;
            this.btnAddDateTime.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddDateTime.IdleIconLeftImage = null;
            this.btnAddDateTime.IdleIconRightImage = null;
            this.btnAddDateTime.IndicateFocus = false;
            this.btnAddDateTime.Location = new System.Drawing.Point(1030, 750);
            this.btnAddDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDateTime.Name = "btnAddDateTime";
            this.btnAddDateTime.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddDateTime.OnDisabledState.BorderRadius = 1;
            this.btnAddDateTime.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDateTime.OnDisabledState.BorderThickness = 1;
            this.btnAddDateTime.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddDateTime.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddDateTime.OnDisabledState.IconLeftImage = null;
            this.btnAddDateTime.OnDisabledState.IconRightImage = null;
            this.btnAddDateTime.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddDateTime.onHoverState.BorderRadius = 1;
            this.btnAddDateTime.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDateTime.onHoverState.BorderThickness = 1;
            this.btnAddDateTime.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddDateTime.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddDateTime.onHoverState.IconLeftImage = null;
            this.btnAddDateTime.onHoverState.IconRightImage = null;
            this.btnAddDateTime.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddDateTime.OnIdleState.BorderRadius = 1;
            this.btnAddDateTime.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDateTime.OnIdleState.BorderThickness = 1;
            this.btnAddDateTime.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddDateTime.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddDateTime.OnIdleState.IconLeftImage = null;
            this.btnAddDateTime.OnIdleState.IconRightImage = null;
            this.btnAddDateTime.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddDateTime.OnPressedState.BorderRadius = 1;
            this.btnAddDateTime.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDateTime.OnPressedState.BorderThickness = 1;
            this.btnAddDateTime.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddDateTime.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddDateTime.OnPressedState.IconLeftImage = null;
            this.btnAddDateTime.OnPressedState.IconRightImage = null;
            this.btnAddDateTime.Size = new System.Drawing.Size(200, 36);
            this.btnAddDateTime.TabIndex = 5;
            this.btnAddDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddDateTime.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddDateTime.TextMarginLeft = 0;
            this.btnAddDateTime.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddDateTime.UseDefaultRadiusAndThickness = true;
            this.btnAddDateTime.Click += new System.EventHandler(this.btnAddDateTime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 60);
            this.label2.TabIndex = 13;
            this.label2.Text = "SCHEDULE MANAGEMENT";
            // 
            // ucScheduleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddDateTime);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucScheduleManagement";
            this.Size = new System.Drawing.Size(1301, 911);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddDateTime;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvAvailSchedule;
        private System.Windows.Forms.Label label2;
    }
}
