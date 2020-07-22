namespace EpicnpcDB
{
	partial class AddWithdrawal
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
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.date_time = new System.Windows.Forms.DateTimePicker();
			this.price = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(9, 99);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 24);
			this.label5.TabIndex = 15;
			this.label5.Text = "Дата и время:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(72, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 24);
			this.label4.TabIndex = 14;
			this.label4.Text = "Сумма:";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(109, 159);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(172, 54);
			this.button1.TabIndex = 13;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// date_time
			// 
			this.date_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.date_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.date_time.Location = new System.Drawing.Point(151, 99);
			this.date_time.MaxDate = new System.DateTime(2025, 7, 6, 0, 0, 0, 0);
			this.date_time.MinDate = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
			this.date_time.Name = "date_time";
			this.date_time.Size = new System.Drawing.Size(199, 29);
			this.date_time.TabIndex = 12;
			this.date_time.Value = new System.DateTime(2020, 7, 6, 0, 0, 0, 0);
			// 
			// price
			// 
			this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.price.Location = new System.Drawing.Point(151, 64);
			this.price.Name = "price";
			this.price.Size = new System.Drawing.Size(199, 29);
			this.price.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(44, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(286, 31);
			this.label1.TabIndex = 10;
			this.label1.Text = "Добавление вывода";
			// 
			// AddWithdrawal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(369, 225);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.date_time);
			this.Controls.Add(this.price);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "AddWithdrawal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddWithdrawal";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DateTimePicker date_time;
		private System.Windows.Forms.TextBox price;
		private System.Windows.Forms.Label label1;
	}
}