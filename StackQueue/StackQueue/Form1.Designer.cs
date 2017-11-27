namespace StackQueue
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.txtStack = new System.Windows.Forms.TextBox();
			this.txtQueue = new System.Windows.Forms.TextBox();
			this.btnPush = new System.Windows.Forms.Button();
			this.btnPOP = new System.Windows.Forms.Button();
			this.btnEnQueue = new System.Windows.Forms.Button();
			this.btnDeQueue = new System.Windows.Forms.Button();
			this.lblStack = new System.Windows.Forms.Label();
			this.lblQueue = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtStack
			// 
			this.txtStack.Location = new System.Drawing.Point(58, 80);
			this.txtStack.Name = "txtStack";
			this.txtStack.Size = new System.Drawing.Size(100, 19);
			this.txtStack.TabIndex = 0;
			// 
			// txtQueue
			// 
			this.txtQueue.Location = new System.Drawing.Point(199, 80);
			this.txtQueue.Name = "txtQueue";
			this.txtQueue.Size = new System.Drawing.Size(100, 19);
			this.txtQueue.TabIndex = 1;
			// 
			// btnPush
			// 
			this.btnPush.Location = new System.Drawing.Point(58, 117);
			this.btnPush.Name = "btnPush";
			this.btnPush.Size = new System.Drawing.Size(75, 23);
			this.btnPush.TabIndex = 2;
			this.btnPush.Text = "PUSH";
			this.btnPush.UseVisualStyleBackColor = true;
			// 
			// btnPOP
			// 
			this.btnPOP.Location = new System.Drawing.Point(58, 157);
			this.btnPOP.Name = "btnPOP";
			this.btnPOP.Size = new System.Drawing.Size(75, 23);
			this.btnPOP.TabIndex = 3;
			this.btnPOP.Text = "POP";
			this.btnPOP.UseVisualStyleBackColor = true;
			// 
			// btnEnQueue
			// 
			this.btnEnQueue.Location = new System.Drawing.Point(199, 117);
			this.btnEnQueue.Name = "btnEnQueue";
			this.btnEnQueue.Size = new System.Drawing.Size(75, 23);
			this.btnEnQueue.TabIndex = 4;
			this.btnEnQueue.Text = "ENQUEUE";
			this.btnEnQueue.UseVisualStyleBackColor = true;
			// 
			// btnDeQueue
			// 
			this.btnDeQueue.Location = new System.Drawing.Point(199, 157);
			this.btnDeQueue.Name = "btnDeQueue";
			this.btnDeQueue.Size = new System.Drawing.Size(75, 23);
			this.btnDeQueue.TabIndex = 5;
			this.btnDeQueue.Text = "DEQUEUE";
			this.btnDeQueue.UseVisualStyleBackColor = true;
			// 
			// lblStack
			// 
			this.lblStack.AutoSize = true;
			this.lblStack.Location = new System.Drawing.Point(56, 202);
			this.lblStack.Name = "lblStack";
			this.lblStack.Size = new System.Drawing.Size(67, 12);
			this.lblStack.TabIndex = 6;
			this.lblStack.Text = "StackResult";
			// 
			// lblQueue
			// 
			this.lblQueue.AutoSize = true;
			this.lblQueue.Location = new System.Drawing.Point(197, 202);
			this.lblQueue.Name = "lblQueue";
			this.lblQueue.Size = new System.Drawing.Size(70, 12);
			this.lblQueue.TabIndex = 7;
			this.lblQueue.Text = "QueueResult";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 311);
			this.Controls.Add(this.lblQueue);
			this.Controls.Add(this.lblStack);
			this.Controls.Add(this.btnDeQueue);
			this.Controls.Add(this.btnEnQueue);
			this.Controls.Add(this.btnPOP);
			this.Controls.Add(this.btnPush);
			this.Controls.Add(this.txtQueue);
			this.Controls.Add(this.txtStack);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtStack;
		private System.Windows.Forms.TextBox txtQueue;
		private System.Windows.Forms.Button btnPush;
		private System.Windows.Forms.Button btnPOP;
		private System.Windows.Forms.Button btnEnQueue;
		private System.Windows.Forms.Button btnDeQueue;
		private System.Windows.Forms.Label lblStack;
		private System.Windows.Forms.Label lblQueue;
	}
}

