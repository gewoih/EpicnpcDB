namespace EpicnpcDB
{
	partial class Main_Form
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.top_panel = new System.Windows.Forms.Panel();
			this.change_list = new System.Windows.Forms.ComboBox();
			this.top_border_panel = new System.Windows.Forms.Panel();
			this.middle_panel = new System.Windows.Forms.Panel();
			this.add_withdrawal_button = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.auth_panel = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.add_purchase_button = new System.Windows.Forms.Button();
			this.top_panel.SuspendLayout();
			this.middle_panel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.auth_panel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(93, 97);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(221, 20);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(93, 123);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(221, 20);
			this.textBox2.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(93, 149);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(221, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Войти";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// top_panel
			// 
			this.top_panel.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.top_panel.Controls.Add(this.change_list);
			this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.top_panel.Location = new System.Drawing.Point(0, 32);
			this.top_panel.Name = "top_panel";
			this.top_panel.Size = new System.Drawing.Size(800, 64);
			this.top_panel.TabIndex = 5;
			// 
			// change_list
			// 
			this.change_list.BackColor = System.Drawing.SystemColors.Window;
			this.change_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.change_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.change_list.FormattingEnabled = true;
			this.change_list.Items.AddRange(new object[] {
            "Покупки",
            "В наличии",
            "Продажи",
            "Выводы"});
			this.change_list.Location = new System.Drawing.Point(12, 20);
			this.change_list.Name = "change_list";
			this.change_list.Size = new System.Drawing.Size(252, 28);
			this.change_list.TabIndex = 0;
			this.change_list.SelectedIndexChanged += new System.EventHandler(this.change_list_SelectedIndexChanged);
			// 
			// top_border_panel
			// 
			this.top_border_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.top_border_panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.top_border_panel.Location = new System.Drawing.Point(0, 0);
			this.top_border_panel.Name = "top_border_panel";
			this.top_border_panel.Size = new System.Drawing.Size(800, 32);
			this.top_border_panel.TabIndex = 2;
			this.top_border_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_border_panel_MouseDown);
			this.top_border_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_border_panel_MouseMove);
			// 
			// middle_panel
			// 
			this.middle_panel.Controls.Add(this.add_withdrawal_button);
			this.middle_panel.Controls.Add(this.panel1);
			this.middle_panel.Controls.Add(this.panel3);
			this.middle_panel.Controls.Add(this.add_purchase_button);
			this.middle_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.middle_panel.Location = new System.Drawing.Point(0, 96);
			this.middle_panel.Name = "middle_panel";
			this.middle_panel.Size = new System.Drawing.Size(800, 354);
			this.middle_panel.TabIndex = 6;
			// 
			// add_withdrawal_button
			// 
			this.add_withdrawal_button.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.add_withdrawal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add_withdrawal_button.Location = new System.Drawing.Point(0, 246);
			this.add_withdrawal_button.Name = "add_withdrawal_button";
			this.add_withdrawal_button.Size = new System.Drawing.Size(800, 54);
			this.add_withdrawal_button.TabIndex = 8;
			this.add_withdrawal_button.Text = "Добавить вывод";
			this.add_withdrawal_button.UseVisualStyleBackColor = true;
			this.add_withdrawal_button.Visible = false;
			this.add_withdrawal_button.Click += new System.EventHandler(this.add_withdrawal_button_Click);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.auth_panel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 268);
			this.panel1.TabIndex = 7;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 64);
			this.panel2.TabIndex = 5;
			this.panel2.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(594, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(189, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "88.88.8888 13:13:13";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(412, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(168, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "Counter-Strike:GO";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(300, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "20000,99";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(130, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(141, 23);
			this.label7.TabIndex = 1;
			this.label7.Text = "Сюзанночька)";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(42, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 23);
			this.label8.TabIndex = 0;
			this.label8.Text = "9999";
			// 
			// auth_panel
			// 
			this.auth_panel.Controls.Add(this.label3);
			this.auth_panel.Controls.Add(this.label2);
			this.auth_panel.Controls.Add(this.label1);
			this.auth_panel.Controls.Add(this.button1);
			this.auth_panel.Controls.Add(this.textBox1);
			this.auth_panel.Controls.Add(this.textBox2);
			this.auth_panel.Location = new System.Drawing.Point(213, 84);
			this.auth_panel.Name = "auth_panel";
			this.auth_panel.Size = new System.Drawing.Size(367, 178);
			this.auth_panel.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(19, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Пароль:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(31, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Логин:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(120, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "Авторизация";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label13);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(800, 32);
			this.panel3.TabIndex = 0;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(635, 7);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(111, 17);
			this.label13.TabIndex = 4;
			this.label13.Text = "Дата и время";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(463, 7);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(62, 17);
			this.label12.TabIndex = 3;
			this.label12.Text = "Игра";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(308, 7);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(75, 17);
			this.label11.TabIndex = 2;
			this.label11.Text = "Сумма";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(141, 7);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(118, 17);
			this.label10.TabIndex = 1;
			this.label10.Text = "Покупатель";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(16, 7);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(102, 17);
			this.label9.TabIndex = 0;
			this.label9.Text = "ID покупки";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// add_purchase_button
			// 
			this.add_purchase_button.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.add_purchase_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add_purchase_button.Location = new System.Drawing.Point(0, 300);
			this.add_purchase_button.Name = "add_purchase_button";
			this.add_purchase_button.Size = new System.Drawing.Size(800, 54);
			this.add_purchase_button.TabIndex = 6;
			this.add_purchase_button.Text = "Добавить покупку";
			this.add_purchase_button.UseVisualStyleBackColor = true;
			this.add_purchase_button.Visible = false;
			this.add_purchase_button.Click += new System.EventHandler(this.add_purchase_button_Click);
			// 
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.middle_panel);
			this.Controls.Add(this.top_panel);
			this.Controls.Add(this.top_border_panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "Main_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EpicNPC DataBase";
			this.top_panel.ResumeLayout(false);
			this.middle_panel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.auth_panel.ResumeLayout(false);
			this.auth_panel.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel top_panel;
		private System.Windows.Forms.Panel middle_panel;
		private System.Windows.Forms.Panel auth_panel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox change_list;
		private System.Windows.Forms.Button add_purchase_button;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel top_border_panel;
		private System.Windows.Forms.Button add_withdrawal_button;
	}
}

