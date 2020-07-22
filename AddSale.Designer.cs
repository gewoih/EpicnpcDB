namespace EpicnpcDB
{
	partial class AddSale
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.sell_price = new System.Windows.Forms.TextBox();
			this.buyer_discord = new System.Windows.Forms.TextBox();
			this.paypal_operation_id = new System.Windows.Forms.TextBox();
			this.date_time = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(78, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(304, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Добавление продажи";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(129, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Цена:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(34, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Buyer\'s discord:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(17, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(182, 25);
			this.label4.TabIndex = 3;
			this.label4.Text = "PayPal operation:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(38, 236);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(161, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "Дата продажи:";
			// 
			// sell_price
			// 
			this.sell_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sell_price.Location = new System.Drawing.Point(205, 124);
			this.sell_price.Name = "sell_price";
			this.sell_price.Size = new System.Drawing.Size(225, 31);
			this.sell_price.TabIndex = 6;
			// 
			// buyer_discord
			// 
			this.buyer_discord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buyer_discord.Location = new System.Drawing.Point(205, 161);
			this.buyer_discord.Name = "buyer_discord";
			this.buyer_discord.Size = new System.Drawing.Size(225, 31);
			this.buyer_discord.TabIndex = 7;
			// 
			// paypal_operation_id
			// 
			this.paypal_operation_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.paypal_operation_id.Location = new System.Drawing.Point(205, 198);
			this.paypal_operation_id.Name = "paypal_operation_id";
			this.paypal_operation_id.Size = new System.Drawing.Size(225, 31);
			this.paypal_operation_id.TabIndex = 8;
			// 
			// date_time
			// 
			this.date_time.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.date_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.date_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.date_time.Location = new System.Drawing.Point(203, 235);
			this.date_time.Name = "date_time";
			this.date_time.Size = new System.Drawing.Size(227, 31);
			this.date_time.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(109, 322);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(257, 54);
			this.button1.TabIndex = 10;
			this.button1.Text = "Добавить продажу\r\n";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// AddSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(442, 388);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.date_time);
			this.Controls.Add(this.paypal_operation_id);
			this.Controls.Add(this.buyer_discord);
			this.Controls.Add(this.sell_price);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AddSale";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddSale";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox sell_price;
		private System.Windows.Forms.TextBox buyer_discord;
		private System.Windows.Forms.TextBox paypal_operation_id;
		private System.Windows.Forms.DateTimePicker date_time;
		private System.Windows.Forms.Button button1;
	}
}