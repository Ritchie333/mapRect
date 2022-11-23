namespace MapRect
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmdOpen = new System.Windows.Forms.Button();
			this.cmdClose = new System.Windows.Forms.Button();
			this.pnl = new System.Windows.Forms.Panel();
			this.picMap = new System.Windows.Forms.PictureBox();
			this.lblTrack = new System.Windows.Forms.Label();
			this.cmdClear = new System.Windows.Forms.Button();
			this.cmdUndo = new System.Windows.Forms.Button();
			this.txtTrack = new System.Windows.Forms.TextBox();
			this.cmdConfig = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.pnl.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize ) ( this.picMap ) ).BeginInit();
			this.SuspendLayout();
			// 
			// cmdOpen
			// 
			this.cmdOpen.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.cmdOpen.Location = new System.Drawing.Point( 13, 408 );
			this.cmdOpen.Name = "cmdOpen";
			this.cmdOpen.Size = new System.Drawing.Size( 75, 23 );
			this.cmdOpen.TabIndex = 2;
			this.cmdOpen.Text = "Open";
			this.cmdOpen.UseVisualStyleBackColor = true;
			this.cmdOpen.Click += new System.EventHandler( this.cmdOpen_Click );
			// 
			// cmdClose
			// 
			this.cmdClose.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.cmdClose.Location = new System.Drawing.Point( 540, 410 );
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size( 75, 23 );
			this.cmdClose.TabIndex = 8;
			this.cmdClose.Text = "Close";
			this.cmdClose.UseVisualStyleBackColor = true;
			this.cmdClose.Click += new System.EventHandler( this.cmdClose_Click );
			// 
			// pnl
			// 
			this.pnl.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
									| System.Windows.Forms.AnchorStyles.Left )
									| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.pnl.AutoScroll = true;
			this.pnl.Controls.Add( this.picMap );
			this.pnl.Location = new System.Drawing.Point( 244, 13 );
			this.pnl.Name = "pnl";
			this.pnl.Size = new System.Drawing.Size( 371, 389 );
			this.pnl.TabIndex = 1;
			// 
			// picMap
			// 
			this.picMap.Location = new System.Drawing.Point( 0, -1 );
			this.picMap.Name = "picMap";
			this.picMap.Size = new System.Drawing.Size( 259, 210 );
			this.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMap.TabIndex = 5;
			this.picMap.TabStop = false;
			this.picMap.Paint += new System.Windows.Forms.PaintEventHandler( this.picMap_Paint );		
			this.picMap.MouseUp += new System.Windows.Forms.MouseEventHandler( this.picMap_MouseUp );
			this.picMap.MouseMove += new System.Windows.Forms.MouseEventHandler( this.picMap_MouseMove );
			// 
			// lblTrack
			// 
			this.lblTrack.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.lblTrack.AutoSize = true;
			this.lblTrack.Location = new System.Drawing.Point( 418, 410 );
			this.lblTrack.Name = "lblTrack";
			this.lblTrack.Size = new System.Drawing.Size( 22, 13 );
			this.lblTrack.TabIndex = 7;
			this.lblTrack.Text = "0,0";
			// 
			// cmdClear
			// 
			this.cmdClear.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.cmdClear.Location = new System.Drawing.Point( 94, 408 );
			this.cmdClear.Name = "cmdClear";
			this.cmdClear.Size = new System.Drawing.Size( 75, 23 );
			this.cmdClear.TabIndex = 3;
			this.cmdClear.Text = "Clear";
			this.cmdClear.UseVisualStyleBackColor = true;
			this.cmdClear.Click += new System.EventHandler( this.cmdClear_Click );
			// 
			// cmdUndo
			// 
			this.cmdUndo.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.cmdUndo.Location = new System.Drawing.Point( 175, 408 );
			this.cmdUndo.Name = "cmdUndo";
			this.cmdUndo.Size = new System.Drawing.Size( 75, 23 );
			this.cmdUndo.TabIndex = 4;
			this.cmdUndo.Text = "Undo";
			this.cmdUndo.UseVisualStyleBackColor = true;
			this.cmdUndo.Click += new System.EventHandler( this.cmdUndo_Click );
			// 
			// txtTrack
			// 
			this.txtTrack.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
									| System.Windows.Forms.AnchorStyles.Left ) ) );
			this.txtTrack.Location = new System.Drawing.Point( 13, 13 );
			this.txtTrack.Multiline = true;
			this.txtTrack.Name = "txtTrack";
			this.txtTrack.Size = new System.Drawing.Size( 225, 389 );
			this.txtTrack.TabIndex = 0;
			// 
			// cmdConfig
			// 
			this.cmdConfig.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.cmdConfig.Location = new System.Drawing.Point( 256, 408 );
			this.cmdConfig.Name = "cmdConfig";
			this.cmdConfig.Size = new System.Drawing.Size( 75, 23 );
			this.cmdConfig.TabIndex = 5;
			this.cmdConfig.Text = "Config";
			this.cmdConfig.UseVisualStyleBackColor = true;
			this.cmdConfig.Click += new System.EventHandler( this.cmdConfig_Click );
			// 
			// cmdSave
			// 
			this.cmdSave.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.cmdSave.Location = new System.Drawing.Point( 337, 408 );
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size( 75, 23 );
			this.cmdSave.TabIndex = 6;
			this.cmdSave.Text = "Save";
			this.cmdSave.UseVisualStyleBackColor = true;
			this.cmdSave.Click += new System.EventHandler( this.cmdSave_Click );
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 627, 443 );
			this.Controls.Add( this.cmdSave );
			this.Controls.Add( this.cmdConfig );
			this.Controls.Add( this.cmdUndo );
			this.Controls.Add( this.cmdClear );
			this.Controls.Add( this.lblTrack );
			this.Controls.Add( this.txtTrack );
			this.Controls.Add( this.pnl );
			this.Controls.Add( this.cmdClose );
			this.Controls.Add( this.cmdOpen );
			this.Name = "frmMain";
			this.Text = "Map point tracker";
			this.pnl.ResumeLayout( false );
			this.pnl.PerformLayout();
			( ( System.ComponentModel.ISupportInitialize ) ( this.picMap ) ).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdOpen;
		private System.Windows.Forms.Button cmdClose;
		private System.Windows.Forms.Panel pnl;
		private System.Windows.Forms.PictureBox picMap;
		private System.Windows.Forms.Label lblTrack;
		private System.Windows.Forms.Button cmdClear;
		private System.Windows.Forms.Button cmdUndo;
		private System.Windows.Forms.TextBox txtTrack;
		private System.Windows.Forms.Button cmdConfig;
		private System.Windows.Forms.Button cmdSave;
	}
}

