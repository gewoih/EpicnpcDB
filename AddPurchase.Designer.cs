namespace EpicnpcDB
{
	partial class AddPurchase
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
			this.label1 = new System.Windows.Forms.Label();
			this.games_list = new System.Windows.Forms.ComboBox();
			this.description = new System.Windows.Forms.TextBox();
			this.funpay_link = new System.Windows.Forms.TextBox();
			this.date_time = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.price = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(77, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(296, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Добавление покупки";
			// 
			// games_list
			// 
			this.games_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.games_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.games_list.FormattingEnabled = true;
			this.games_list.Items.AddRange(new object[] {
            "Valorant",
            "Apex Legends",
            "Counter-Strike:GO",
            "Dota 2"});
			this.games_list.Location = new System.Drawing.Point(226, 88);
			this.games_list.Name = "games_list";
			this.games_list.Size = new System.Drawing.Size(199, 32);
			this.games_list.TabIndex = 1;
			// 
			// description
			// 
			this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.description.Location = new System.Drawing.Point(226, 126);
			this.description.Name = "description";
			this.description.Size = new System.Drawing.Size(199, 29);
			this.description.TabIndex = 2;
			// 
			// funpay_link
			// 
			this.funpay_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.funpay_link.Location = new System.Drawing.Point(226, 161);
			this.funpay_link.Name = "funpay_link";
			this.funpay_link.Size = new System.Drawing.Size(199, 29);
			this.funpay_link.TabIndex = 3;
			// 
			// date_time
			// 
			this.date_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.date_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.date_time.Location = new System.Drawing.Point(226, 196);
			this.date_time.MaxDate = new System.DateTime(2025, 7, 6, 0, 0, 0, 0);
			this.date_time.MinDate = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
			this.date_time.Name = "date_time";
			this.date_time.Size = new System.Drawing.Size(199, 29);
			this.date_time.TabIndex = 4;
			this.date_time.Value = new System.DateTime(2020, 7, 6, 0, 0, 0, 0);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(104, 300);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(257, 54);
			this.button1.TabIndex = 5;
			this.button1.Text = "Добавить покупку\r\n";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(162, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "Игра:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(47, 129);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(173, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "Описание товара:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(208, 24);
			this.label4.TabIndex = 8;
			this.label4.Text = "Номер заказа FunPay:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(84, 196);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 24);
			this.label5.TabIndex = 9;
			this.label5.Text = "Дата и время:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(161, 231);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 24);
			this.label7.TabIndex = 13;
			this.label7.Text = "Цена:";
			// 
			// price
			// 
			this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.price.Location = new System.Drawing.Point(226, 231);
			this.price.Name = "price";
			this.price.Size = new System.Drawing.Size(199, 29);
			this.price.TabIndex = 12;
			// 
			// AddPurchase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(441, 366);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.price);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.date_time);
			this.Controls.Add(this.funpay_link);
			this.Controls.Add(this.description);
			this.Controls.Add(this.games_list);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AddPurchase";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddPurchase";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox games_list;
		private System.Windows.Forms.TextBox description;
		private System.Windows.Forms.TextBox funpay_link;
		private System.Windows.Forms.DateTimePicker date_time;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox price;
	}
}