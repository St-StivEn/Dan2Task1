namespace Dan2Task1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.PanelVkladok = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PanelInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelDateComparer = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelDateWorkingCounter = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelLeapCounter = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelTImeConverter = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelBirthdayInformer = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelVkladok.SuspendLayout();
            this.PanelInfo.SuspendLayout();
            this.PanelDateComparer.SuspendLayout();
            this.PanelDateWorkingCounter.SuspendLayout();
            this.PanelLeapCounter.SuspendLayout();
            this.PanelTImeConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.PanelVkladok;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(231)))), ((int)(((byte)(15)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // PanelVkladok
            // 
            this.PanelVkladok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PanelVkladok.Controls.Add(this.guna2GradientButton2);
            this.PanelVkladok.Controls.Add(this.guna2GradientButton3);
            this.PanelVkladok.Controls.Add(this.guna2GradientButton4);
            this.PanelVkladok.Controls.Add(this.guna2GradientButton5);
            this.PanelVkladok.Controls.Add(this.guna2GradientButton6);
            this.PanelVkladok.Controls.Add(this.guna2ControlBox2);
            this.PanelVkladok.Controls.Add(this.guna2ControlBox1);
            this.PanelVkladok.Controls.Add(this.guna2GradientButton1);
            this.PanelVkladok.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelVkladok.Location = new System.Drawing.Point(0, 0);
            this.PanelVkladok.Name = "PanelVkladok";
            this.PanelVkladok.Size = new System.Drawing.Size(754, 91);
            this.PanelVkladok.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(726, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(25, 25);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.UseTransparentBackground = true;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 8;
            this.guna2Elipse2.TargetControl = this.guna2ControlBox1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 8;
            this.guna2Elipse3.TargetControl = this.guna2ControlBox2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(695, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(25, 25);
            this.guna2ControlBox2.TabIndex = 1;
            this.guna2ControlBox2.UseTransparentBackground = true;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 8;
            this.guna2GradientButton1.CustomImages.Image = global::Dan2Task1.Properties.Resources.information;
            this.guna2GradientButton1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(231)))), ((int)(((byte)(15)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(231)))), ((int)(((byte)(15)))));
            this.guna2GradientButton1.HoverState.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.Location = new System.Drawing.Point(1, 43);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(76, 45);
            this.guna2GradientButton1.TabIndex = 2;
            this.guna2GradientButton1.Text = "Info";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton1.UseTransparentBackground = true;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderRadius = 8;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(231)))), ((int)(((byte)(15)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(231)))), ((int)(((byte)(15)))));
            this.guna2GradientButton2.HoverState.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GradientButton2.Location = new System.Drawing.Point(622, 43);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(129, 45);
            this.guna2GradientButton2.TabIndex = 3;
            this.guna2GradientButton2.Text = "Birthday Informer";
            this.guna2GradientButton2.UseTransparentBackground = true;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.BorderRadius = 8;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(231)))), ((int)(((byte)(15)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(231)))), ((int)(((byte)(15)))));
            this.guna2GradientButton3.HoverState.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GradientButton3.Location = new System.Drawing.Point(353, 43);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(129, 45);
            this.guna2GradientButton3.TabIndex = 4;
            this.guna2GradientButton3.Text = "Leap Counter";
            this.guna2GradientButton3.UseTransparentBackground = true;
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.Animated = true;
            this.guna2GradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.BorderRadius = 8;
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(231)))), ((int)(((byte)(15)))));
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton4.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton4.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(231)))), ((int)(((byte)(15)))));
            this.guna2GradientButton4.HoverState.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GradientButton4.Location = new System.Drawing.Point(218, 43);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Size = new System.Drawing.Size(129, 45);
            this.guna2GradientButton4.TabIndex = 5;
            this.guna2GradientButton4.Text = "Date Working Counter";
            this.guna2GradientButton4.UseTransparentBackground = true;
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.Animated = true;
            this.guna2GradientButton5.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton5.BorderRadius = 8;
            this.guna2GradientButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(231)))), ((int)(((byte)(15)))));
            this.guna2GradientButton5.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton5.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GradientButton5.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton5.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton5.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(231)))), ((int)(((byte)(15)))));
            this.guna2GradientButton5.HoverState.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GradientButton5.Location = new System.Drawing.Point(83, 43);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.Size = new System.Drawing.Size(129, 45);
            this.guna2GradientButton5.TabIndex = 6;
            this.guna2GradientButton5.Text = "Date Comparer";
            this.guna2GradientButton5.UseTransparentBackground = true;
            // 
            // guna2GradientButton6
            // 
            this.guna2GradientButton6.Animated = true;
            this.guna2GradientButton6.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton6.BorderRadius = 8;
            this.guna2GradientButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton6.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(231)))), ((int)(((byte)(15)))));
            this.guna2GradientButton6.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton6.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GradientButton6.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton6.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton6.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(231)))), ((int)(((byte)(15)))));
            this.guna2GradientButton6.HoverState.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GradientButton6.Location = new System.Drawing.Point(487, 43);
            this.guna2GradientButton6.Name = "guna2GradientButton6";
            this.guna2GradientButton6.Size = new System.Drawing.Size(129, 45);
            this.guna2GradientButton6.TabIndex = 7;
            this.guna2GradientButton6.Text = "Time Converter";
            this.guna2GradientButton6.UseTransparentBackground = true;
            // 
            // PanelInfo
            // 
            this.PanelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PanelInfo.Controls.Add(this.PanelDateComparer);
            this.PanelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInfo.Location = new System.Drawing.Point(0, 89);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(754, 511);
            this.PanelInfo.TabIndex = 1;
            // 
            // PanelDateComparer
            // 
            this.PanelDateComparer.Controls.Add(this.PanelDateWorkingCounter);
            this.PanelDateComparer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelDateComparer.Location = new System.Drawing.Point(0, 0);
            this.PanelDateComparer.Name = "PanelDateComparer";
            this.PanelDateComparer.Size = new System.Drawing.Size(754, 511);
            this.PanelDateComparer.TabIndex = 0;
            // 
            // PanelDateWorkingCounter
            // 
            this.PanelDateWorkingCounter.Controls.Add(this.PanelLeapCounter);
            this.PanelDateWorkingCounter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelDateWorkingCounter.Location = new System.Drawing.Point(0, 0);
            this.PanelDateWorkingCounter.Name = "PanelDateWorkingCounter";
            this.PanelDateWorkingCounter.Size = new System.Drawing.Size(754, 511);
            this.PanelDateWorkingCounter.TabIndex = 1;
            // 
            // PanelLeapCounter
            // 
            this.PanelLeapCounter.Controls.Add(this.PanelTImeConverter);
            this.PanelLeapCounter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelLeapCounter.Location = new System.Drawing.Point(0, 0);
            this.PanelLeapCounter.Name = "PanelLeapCounter";
            this.PanelLeapCounter.Size = new System.Drawing.Size(754, 511);
            this.PanelLeapCounter.TabIndex = 1;
            // 
            // PanelTImeConverter
            // 
            this.PanelTImeConverter.Controls.Add(this.PanelBirthdayInformer);
            this.PanelTImeConverter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelTImeConverter.Location = new System.Drawing.Point(0, 0);
            this.PanelTImeConverter.Name = "PanelTImeConverter";
            this.PanelTImeConverter.Size = new System.Drawing.Size(754, 511);
            this.PanelTImeConverter.TabIndex = 1;
            // 
            // PanelBirthdayInformer
            // 
            this.PanelBirthdayInformer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBirthdayInformer.Location = new System.Drawing.Point(0, 0);
            this.PanelBirthdayInformer.Name = "PanelBirthdayInformer";
            this.PanelBirthdayInformer.Size = new System.Drawing.Size(754, 511);
            this.PanelBirthdayInformer.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 600);
            this.Controls.Add(this.PanelInfo);
            this.Controls.Add(this.PanelVkladok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelVkladok.ResumeLayout(false);
            this.PanelInfo.ResumeLayout(false);
            this.PanelDateComparer.ResumeLayout(false);
            this.PanelDateWorkingCounter.ResumeLayout(false);
            this.PanelLeapCounter.ResumeLayout(false);
            this.PanelTImeConverter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel PanelVkladok;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton6;
        private Guna.UI2.WinForms.Guna2Panel PanelInfo;
        private Guna.UI2.WinForms.Guna2Panel PanelDateComparer;
        private Guna.UI2.WinForms.Guna2Panel PanelDateWorkingCounter;
        private Guna.UI2.WinForms.Guna2Panel PanelLeapCounter;
        private Guna.UI2.WinForms.Guna2Panel PanelTImeConverter;
        private Guna.UI2.WinForms.Guna2Panel PanelBirthdayInformer;
    }
}

