namespace ProExchange.OrderbookClient
{
	partial class Form1
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
			this.gvSell = new System.Windows.Forms.DataGridView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.gvBuy = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gvSell)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvBuy)).BeginInit();
			this.SuspendLayout();
			// 
			// gvSell
			// 
			this.gvSell.AllowUserToAddRows = false;
			this.gvSell.AllowUserToDeleteRows = false;
			this.gvSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvSell.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvSell.Location = new System.Drawing.Point(0, 0);
			this.gvSell.Name = "gvSell";
			this.gvSell.ReadOnly = true;
			this.gvSell.Size = new System.Drawing.Size(497, 237);
			this.gvSell.TabIndex = 0;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.gvSell);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.gvBuy);
			this.splitContainer1.Size = new System.Drawing.Size(497, 474);
			this.splitContainer1.SplitterDistance = 237;
			this.splitContainer1.TabIndex = 1;
			// 
			// gvBuy
			// 
			this.gvBuy.AllowUserToAddRows = false;
			this.gvBuy.AllowUserToDeleteRows = false;
			this.gvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvBuy.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvBuy.Location = new System.Drawing.Point(0, 0);
			this.gvBuy.Name = "gvBuy";
			this.gvBuy.ReadOnly = true;
			this.gvBuy.Size = new System.Drawing.Size(497, 233);
			this.gvBuy.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 474);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.gvSell)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvBuy)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gvSell;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView gvBuy;
	}
}

