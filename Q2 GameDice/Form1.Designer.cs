namespace Q2_GameDice
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnDice = new System.Windows.Forms.Button();
			this.lblDiceNumber1 = new System.Windows.Forms.Label();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnDice
			// 
			this.btnDice.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDice.Location = new System.Drawing.Point(120, 12);
			this.btnDice.Name = "btnDice";
			this.btnDice.Size = new System.Drawing.Size(75, 72);
			this.btnDice.TabIndex = 0;
			this.btnDice.Text = "擲骰子";
			this.btnDice.UseVisualStyleBackColor = true;
			this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
			// 
			// lblDiceNumber1
			// 
			this.lblDiceNumber1.AutoSize = true;
			this.lblDiceNumber1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblDiceNumber1.Location = new System.Drawing.Point(12, 55);
			this.lblDiceNumber1.Name = "lblDiceNumber1";
			this.lblDiceNumber1.Size = new System.Drawing.Size(55, 16);
			this.lblDiceNumber1.TabIndex = 1;
			this.lblDiceNumber1.Text = "投擲結果";
			this.lblDiceNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblResult.Location = new System.Drawing.Point(12, 90);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(31, 16);
			this.lblResult.TabIndex = 2;
			this.lblResult.Text = "結果";
			this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(207, 154);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.lblDiceNumber1);
			this.Controls.Add(this.btnDice);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "擲骰子遊戲";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDice;
		private System.Windows.Forms.Label lblDiceNumber1;
		private System.Windows.Forms.Label lblResult;
	}
}

