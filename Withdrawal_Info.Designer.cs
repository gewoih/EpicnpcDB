namespace EpicnpcDB
{
	partial class Withdrawal_Info
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
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.amount = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.date_time = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.is_transferred = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.to_transfer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(108, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(278, 29);
			this.label9.TabIndex = 24;
			this.label9.Text = "Информация о выводе";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(67, 91);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(166, 25);
			this.label11.TabIndex = 25;
			this.label11.Text = "Дата и время:";
			// 
			// amount
			// 
			this.amount.AutoSize = true;
			this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.amount.Location = new System.Drawing.Point(230, 60);
			this.amount.Name = "amount";
			this.amount.Size = new System.Drawing.Size(78, 25);
			this.amount.TabIndex = 28;
			this.amount.Text = "7100р.";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label18.Location = new System.Drawing.Point(55, 60);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(178, 25);
			this.label18.TabIndex = 26;
			this.label18.Text = "Сумма вывода:";
			// 
			// date_time
			// 
			this.date_time.AutoSize = true;
			this.date_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.date_time.Location = new System.Drawing.Point(230, 91);
			this.date_time.Name = "date_time";
			this.date_time.Size = new System.Drawing.Size(210, 25);
			this.date_time.TabIndex = 27;
			this.date_time.Text = "01.07.2020 13:56:00";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(108, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 25);
			this.label1.TabIndex = 29;
			this.label1.Text = "Перевел?:";
			// 
			// is_transferred
			// 
			this.is_transferred.AutoSize = true;
			this.is_transferred.BackColor = System.Drawing.Color.Crimson;
			this.is_transferred.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.is_transferred.Location = new System.Drawing.Point(230, 154);
			this.is_transferred.Name = "is_transferred";
			this.is_transferred.Size = new System.Drawing.Size(49, 25);
			this.is_transferred.TabIndex = 30;
			this.is_transferred.Text = "Нет";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(136, 204);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(197, 44);
			this.button1.TabIndex = 31;
			this.button1.Text = "Перевести";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(13, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(220, 25);
			this.label3.TabIndex = 32;
			this.label3.Text = "Сумма к переводу:";
			// 
			// to_transfer
			// 
			this.to_transfer.AutoSize = true;
			this.to_transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.to_transfer.Location = new System.Drawing.Point(230, 122);
			this.to_transfer.Name = "to_transfer";
			this.to_transfer.Size = new System.Drawing.Size(78, 25);
			this.to_transfer.TabIndex = 33;
			this.to_transfer.Text = "3615р.";
			// 
			// Withdrawal_Info
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(458, 260);
			this.Controls.Add(this.to_transfer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.is_transferred);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.amount);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.date_time);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Withdrawal_Info";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Withdrawal_Info";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label amount;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label date_time;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label is_transferred;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label to_transfer;
	}
}