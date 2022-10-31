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
			this.lblDiceNumber = new System.Windows.Forms.Label();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnDice
			// 
			this.btnDice.Location = new System.Drawing.Point(31, 30);
			this.btnDice.Name = "btnDice";
			this.btnDice.Size = new System.Drawing.Size(75, 23);
			this.btnDice.TabIndex = 0;
			this.btnDice.Text = "擲骰子";
			this.btnDice.UseVisualStyleBackColor = true;
			// 
			// lblDiceNumber
			// 
			this.lblDiceNumber.AutoSize = true;
			this.lblDiceNumber.Location = new System.Drawing.Point(29, 74);
			this.lblDiceNumber.Name = "lblDiceNumber";
			this.lblDiceNumber.Size = new System.Drawing.Size(29, 12);
			this.lblDiceNumber.TabIndex = 1;
			this.lblDiceNumber.Text = "投擲";
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(29, 103);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(29, 12);
			this.lblResult.TabIndex = 2;
			this.lblResult.Text = "結果";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(177, 167);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.lblDiceNumber);
			this.Controls.Add(this.btnDice);
			this.Name = "Form1";
			this.Text = "擲骰子遊戲";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDice;
		private System.Windows.Forms.Label lblDiceNumber;
		private System.Windows.Forms.Label lblResult;
	}
}

