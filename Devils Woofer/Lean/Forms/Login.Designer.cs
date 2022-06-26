namespace Lean.Forms
{
	// Token: 0x0200000B RID: 11
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x060000BF RID: 191 RVA: 0x0000F1EC File Offset: 0x0000D3EC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000F228 File Offset: 0x0000D428
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Lean.Forms.Login));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.PingButton = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneButton1 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.UsernameTB = new global::Siticone.UI.WinForms.SiticoneTextBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.siticoneTextBox2 = new global::Siticone.UI.WinForms.SiticoneTextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.siticoneTextBox3 = new global::Siticone.UI.WinForms.SiticoneTextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.siticoneTextBox4 = new global::Siticone.UI.WinForms.SiticoneTextBox();
			this.siticoneButton2 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneButton3 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneTextBox1 = new global::Siticone.UI.WinForms.SiticoneTextBox();
			this.siticoneLabel8 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.timer210 = new global::System.Windows.Forms.Timer(this.components);
			this.timer2310 = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, 0);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(190, 7);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.PressedColor = global::System.Drawing.Color.DarkRed;
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = 0;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, 0);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(139, 7);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.PressedColor = global::System.Drawing.Color.DarkRed;
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneControlBox2.Click += new global::System.EventHandler(this.siticoneControlBox2_Click);
			this.siticoneTransition1.AnimationType = 1;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.siticoneTransition1.DefaultAnimation = animation;
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, 0);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.label2.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label2, 0);
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(9, 9);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(98, 19);
			this.label2.TabIndex = 27;
			this.label2.Text = "Devils Woofer";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.PingButton.BorderColor = global::System.Drawing.Color.Red;
			this.PingButton.BorderRadius = 4;
			this.PingButton.BorderThickness = 2;
			this.PingButton.CheckedState.Parent = this.PingButton;
			this.PingButton.CustomImages.Parent = this.PingButton;
			this.siticoneTransition1.SetDecoration(this.PingButton, 0);
			this.PingButton.FillColor = global::System.Drawing.Color.Black;
			this.PingButton.Font = new global::System.Drawing.Font("Segoe UI Black", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.PingButton.ForeColor = global::System.Drawing.Color.White;
			this.PingButton.HoveredState.Parent = this.PingButton;
			this.PingButton.Location = new global::System.Drawing.Point(36, 178);
			this.PingButton.Name = "PingButton";
			this.PingButton.PressedColor = global::System.Drawing.Color.FromArgb(26, 32, 54);
			this.PingButton.ShadowDecoration.Parent = this.PingButton;
			this.PingButton.Size = new global::System.Drawing.Size(72, 32);
			this.PingButton.TabIndex = 36;
			this.PingButton.Text = "LOGIN";
			this.PingButton.Click += new global::System.EventHandler(this.PingButton_Click);
			this.siticoneButton1.BorderColor = global::System.Drawing.Color.Red;
			this.siticoneButton1.BorderRadius = 4;
			this.siticoneButton1.BorderThickness = 2;
			this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
			this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
			this.siticoneTransition1.SetDecoration(this.siticoneButton1, 0);
			this.siticoneButton1.FillColor = global::System.Drawing.Color.Black;
			this.siticoneButton1.Font = new global::System.Drawing.Font("Segoe UI Black", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
			this.siticoneButton1.Location = new global::System.Drawing.Point(114, 178);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.PressedColor = global::System.Drawing.Color.FromArgb(26, 32, 54);
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new global::System.Drawing.Size(81, 32);
			this.siticoneButton1.TabIndex = 37;
			this.siticoneButton1.Text = "REGISTER";
			this.siticoneButton1.Click += new global::System.EventHandler(this.siticoneButton1_Click);
			this.UsernameTB.BorderColor = global::System.Drawing.Color.White;
			this.UsernameTB.BorderRadius = 3;
			this.UsernameTB.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.UsernameTB, 0);
			this.UsernameTB.DefaultText = "";
			this.UsernameTB.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.UsernameTB.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.UsernameTB.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.UsernameTB.DisabledState.Parent = this.UsernameTB;
			this.UsernameTB.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.UsernameTB.FillColor = global::System.Drawing.Color.Black;
			this.UsernameTB.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.UsernameTB.FocusedState.Parent = this.UsernameTB;
			this.UsernameTB.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.UsernameTB.HoveredState.Parent = this.UsernameTB;
			this.UsernameTB.Location = new global::System.Drawing.Point(37, 64);
			this.UsernameTB.Margin = new global::System.Windows.Forms.Padding(4);
			this.UsernameTB.Name = "UsernameTB";
			this.UsernameTB.PasswordChar = '\0';
			this.UsernameTB.PlaceholderText = "";
			this.UsernameTB.SelectedText = "";
			this.UsernameTB.ShadowDecoration.Parent = this.UsernameTB;
			this.UsernameTB.Size = new global::System.Drawing.Size(159, 37);
			this.UsernameTB.TabIndex = 39;
			this.UsernameTB.TextChanged += new global::System.EventHandler(this.UsernameTB_TextChanged);
			this.label10.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label10, 0);
			this.label10.Font = new global::System.Drawing.Font("Segoe UI Black", 10f, global::System.Drawing.FontStyle.Bold);
			this.label10.ForeColor = global::System.Drawing.Color.Red;
			this.label10.Location = new global::System.Drawing.Point(34, 41);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(78, 19);
			this.label10.TabIndex = 38;
			this.label10.Text = "Username";
			this.label10.Click += new global::System.EventHandler(this.label10_Click);
			this.label3.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label3, 0);
			this.label3.Font = new global::System.Drawing.Font("Segoe UI Black", 10f, global::System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = global::System.Drawing.Color.Red;
			this.label3.Location = new global::System.Drawing.Point(32, 105);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(76, 19);
			this.label3.TabIndex = 41;
			this.label3.Text = "Password";
			this.siticoneTextBox2.BorderColor = global::System.Drawing.Color.White;
			this.siticoneTextBox2.BorderRadius = 3;
			this.siticoneTextBox2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.siticoneTextBox2, 0);
			this.siticoneTextBox2.DefaultText = "";
			this.siticoneTextBox2.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.siticoneTextBox2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.siticoneTextBox2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.siticoneTextBox2.DisabledState.Parent = this.siticoneTextBox2;
			this.siticoneTextBox2.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.siticoneTextBox2.FillColor = global::System.Drawing.Color.Black;
			this.siticoneTextBox2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.siticoneTextBox2.FocusedState.Parent = this.siticoneTextBox2;
			this.siticoneTextBox2.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.siticoneTextBox2.HoveredState.Parent = this.siticoneTextBox2;
			this.siticoneTextBox2.Location = new global::System.Drawing.Point(37, 64);
			this.siticoneTextBox2.Margin = new global::System.Windows.Forms.Padding(4);
			this.siticoneTextBox2.Name = "siticoneTextBox2";
			this.siticoneTextBox2.PasswordChar = '\0';
			this.siticoneTextBox2.PlaceholderText = "";
			this.siticoneTextBox2.SelectedText = "";
			this.siticoneTextBox2.ShadowDecoration.Parent = this.siticoneTextBox2;
			this.siticoneTextBox2.Size = new global::System.Drawing.Size(159, 37);
			this.siticoneTextBox2.TabIndex = 43;
			this.label4.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label4, 0);
			this.label4.Font = new global::System.Drawing.Font("Segoe UI Black", 10f, global::System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = global::System.Drawing.Color.Red;
			this.label4.Location = new global::System.Drawing.Point(34, 41);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(78, 19);
			this.label4.TabIndex = 42;
			this.label4.Text = "Username";
			this.label5.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label5, 0);
			this.label5.Font = new global::System.Drawing.Font("Segoe UI Black", 10f, global::System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = global::System.Drawing.Color.Red;
			this.label5.Location = new global::System.Drawing.Point(32, 105);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(76, 19);
			this.label5.TabIndex = 45;
			this.label5.Text = "Password";
			this.siticoneTextBox3.BorderColor = global::System.Drawing.Color.White;
			this.siticoneTextBox3.BorderRadius = 3;
			this.siticoneTextBox3.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.siticoneTextBox3, 0);
			this.siticoneTextBox3.DefaultText = "";
			this.siticoneTextBox3.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.siticoneTextBox3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.siticoneTextBox3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.siticoneTextBox3.DisabledState.Parent = this.siticoneTextBox3;
			this.siticoneTextBox3.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.siticoneTextBox3.FillColor = global::System.Drawing.Color.Black;
			this.siticoneTextBox3.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.siticoneTextBox3.FocusedState.Parent = this.siticoneTextBox3;
			this.siticoneTextBox3.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.siticoneTextBox3.HoveredState.Parent = this.siticoneTextBox3;
			this.siticoneTextBox3.Location = new global::System.Drawing.Point(36, 128);
			this.siticoneTextBox3.Margin = new global::System.Windows.Forms.Padding(4);
			this.siticoneTextBox3.Name = "siticoneTextBox3";
			this.siticoneTextBox3.PasswordChar = '\0';
			this.siticoneTextBox3.PlaceholderText = "";
			this.siticoneTextBox3.SelectedText = "";
			this.siticoneTextBox3.ShadowDecoration.Parent = this.siticoneTextBox3;
			this.siticoneTextBox3.Size = new global::System.Drawing.Size(159, 37);
			this.siticoneTextBox3.TabIndex = 44;
			this.siticoneTextBox3.UseSystemPasswordChar = true;
			this.label6.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label6, 0);
			this.label6.Font = new global::System.Drawing.Font("Segoe UI Black", 10f, global::System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = global::System.Drawing.Color.Red;
			this.label6.Location = new global::System.Drawing.Point(33, 169);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(35, 19);
			this.label6.TabIndex = 47;
			this.label6.Text = "Key";
			this.siticoneTextBox4.BorderColor = global::System.Drawing.Color.White;
			this.siticoneTextBox4.BorderRadius = 3;
			this.siticoneTextBox4.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.siticoneTextBox4, 0);
			this.siticoneTextBox4.DefaultText = "";
			this.siticoneTextBox4.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.siticoneTextBox4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.siticoneTextBox4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.siticoneTextBox4.DisabledState.Parent = this.siticoneTextBox4;
			this.siticoneTextBox4.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.siticoneTextBox4.FillColor = global::System.Drawing.Color.Black;
			this.siticoneTextBox4.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.siticoneTextBox4.FocusedState.Parent = this.siticoneTextBox4;
			this.siticoneTextBox4.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.siticoneTextBox4.HoveredState.Parent = this.siticoneTextBox4;
			this.siticoneTextBox4.Location = new global::System.Drawing.Point(36, 188);
			this.siticoneTextBox4.Margin = new global::System.Windows.Forms.Padding(4);
			this.siticoneTextBox4.Name = "siticoneTextBox4";
			this.siticoneTextBox4.PasswordChar = '\0';
			this.siticoneTextBox4.PlaceholderText = "";
			this.siticoneTextBox4.SelectedText = "";
			this.siticoneTextBox4.ShadowDecoration.Parent = this.siticoneTextBox4;
			this.siticoneTextBox4.Size = new global::System.Drawing.Size(159, 37);
			this.siticoneTextBox4.TabIndex = 46;
			this.siticoneTextBox4.UseSystemPasswordChar = true;
			this.siticoneTextBox4.TextChanged += new global::System.EventHandler(this.siticoneTextBox4_TextChanged);
			this.siticoneButton2.BorderColor = global::System.Drawing.Color.Red;
			this.siticoneButton2.BorderRadius = 4;
			this.siticoneButton2.BorderThickness = 2;
			this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
			this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
			this.siticoneTransition1.SetDecoration(this.siticoneButton2, 0);
			this.siticoneButton2.FillColor = global::System.Drawing.Color.Black;
			this.siticoneButton2.Font = new global::System.Drawing.Font("Segoe UI Black", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton2.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
			this.siticoneButton2.Location = new global::System.Drawing.Point(38, 228);
			this.siticoneButton2.Name = "siticoneButton2";
			this.siticoneButton2.PressedColor = global::System.Drawing.Color.FromArgb(26, 32, 54);
			this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
			this.siticoneButton2.Size = new global::System.Drawing.Size(70, 32);
			this.siticoneButton2.TabIndex = 49;
			this.siticoneButton2.Text = "REGISTER";
			this.siticoneButton2.Click += new global::System.EventHandler(this.siticoneButton2_Click);
			this.siticoneButton3.BorderColor = global::System.Drawing.Color.Red;
			this.siticoneButton3.BorderRadius = 4;
			this.siticoneButton3.BorderThickness = 2;
			this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
			this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
			this.siticoneTransition1.SetDecoration(this.siticoneButton3, 0);
			this.siticoneButton3.FillColor = global::System.Drawing.Color.Black;
			this.siticoneButton3.Font = new global::System.Drawing.Font("Segoe UI Black", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton3.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
			this.siticoneButton3.Location = new global::System.Drawing.Point(114, 228);
			this.siticoneButton3.Name = "siticoneButton3";
			this.siticoneButton3.PressedColor = global::System.Drawing.Color.FromArgb(26, 32, 54);
			this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
			this.siticoneButton3.Size = new global::System.Drawing.Size(76, 32);
			this.siticoneButton3.TabIndex = 48;
			this.siticoneButton3.Text = "LOGIN";
			this.siticoneButton3.Click += new global::System.EventHandler(this.siticoneButton3_Click);
			this.siticoneTextBox1.BorderColor = global::System.Drawing.Color.White;
			this.siticoneTextBox1.BorderRadius = 3;
			this.siticoneTextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.siticoneTextBox1, 0);
			this.siticoneTextBox1.DefaultText = "";
			this.siticoneTextBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.siticoneTextBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.siticoneTextBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.siticoneTextBox1.DisabledState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.siticoneTextBox1.FillColor = global::System.Drawing.Color.Black;
			this.siticoneTextBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.siticoneTextBox1.FocusedState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.siticoneTextBox1.HoveredState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.Location = new global::System.Drawing.Point(36, 128);
			this.siticoneTextBox1.Margin = new global::System.Windows.Forms.Padding(4);
			this.siticoneTextBox1.Name = "siticoneTextBox1";
			this.siticoneTextBox1.PasswordChar = '\0';
			this.siticoneTextBox1.PlaceholderText = "";
			this.siticoneTextBox1.SelectedText = "";
			this.siticoneTextBox1.ShadowDecoration.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.Size = new global::System.Drawing.Size(159, 37);
			this.siticoneTextBox1.TabIndex = 40;
			this.siticoneTextBox1.UseSystemPasswordChar = true;
			this.siticoneTextBox1.TextChanged += new global::System.EventHandler(this.siticoneTextBox1_TextChanged);
			this.siticoneLabel8.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.siticoneLabel8, 0);
			this.siticoneLabel8.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 161);
			this.siticoneLabel8.ForeColor = global::System.Drawing.Color.Red;
			this.siticoneLabel8.Location = new global::System.Drawing.Point(50, 215);
			this.siticoneLabel8.Margin = new global::System.Windows.Forms.Padding(2);
			this.siticoneLabel8.Name = "siticoneLabel8";
			this.siticoneLabel8.Size = new global::System.Drawing.Size(127, 17);
			this.siticoneLabel8.TabIndex = 50;
			this.siticoneLabel8.Text = "discord.gg/devilwoofer";
			this.siticoneLabel8.Click += new global::System.EventHandler(this.siticoneLabel8_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(236, 266);
			base.Controls.Add(this.siticoneLabel8);
			base.Controls.Add(this.siticoneButton2);
			base.Controls.Add(this.siticoneButton3);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.siticoneTextBox4);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.siticoneTextBox2);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.siticoneTextBox1);
			base.Controls.Add(this.UsernameTB);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.siticoneButton1);
			base.Controls.Add(this.PingButton);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			base.Controls.Add(this.siticoneTextBox3);
			this.siticoneTransition1.SetDecoration(this, 1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Login";
			base.Opacity = 0.85;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lean Main";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Login_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000067 RID: 103
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000068 RID: 104
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000069 RID: 105
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400006A RID: 106
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x0400006B RID: 107
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400006E RID: 110
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x0400006F RID: 111
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton1;

		// Token: 0x04000070 RID: 112
		private global::Siticone.UI.WinForms.SiticoneButton PingButton;

		// Token: 0x04000071 RID: 113
		private global::Siticone.UI.WinForms.SiticoneTextBox UsernameTB;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000074 RID: 116
		private global::Siticone.UI.WinForms.SiticoneTextBox siticoneTextBox2;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000077 RID: 119
		private global::Siticone.UI.WinForms.SiticoneTextBox siticoneTextBox4;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000079 RID: 121
		private global::Siticone.UI.WinForms.SiticoneTextBox siticoneTextBox3;

		// Token: 0x0400007A RID: 122
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton2;

		// Token: 0x0400007B RID: 123
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton3;

		// Token: 0x0400007C RID: 124
		private global::Siticone.UI.WinForms.SiticoneTextBox siticoneTextBox1;

		// Token: 0x0400007D RID: 125
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel8;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.Timer timer210;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Timer timer2310;
	}
}
