namespace RockPaperScissors_TM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playergroupBox = new System.Windows.Forms.GroupBox();
            this.paperPictureBox = new System.Windows.Forms.PictureBox();
            this.rockPictureBox = new System.Windows.Forms.PictureBox();
            this.scissorsPictureBox = new System.Windows.Forms.PictureBox();
            this.aigroupBox = new System.Windows.Forms.GroupBox();
            this.aipaperPictureBox = new System.Windows.Forms.PictureBox();
            this.airockPictureBox = new System.Windows.Forms.PictureBox();
            this.aiscissorsPictureBox = new System.Windows.Forms.PictureBox();
            this.outcomegroupBox = new System.Windows.Forms.GroupBox();
            this.versusLabel = new System.Windows.Forms.Label();
            this.shootButton = new System.Windows.Forms.Button();
            this.rematchButton = new System.Windows.Forms.Button();
            this.playergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPictureBox)).BeginInit();
            this.aigroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aipaperPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiscissorsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playergroupBox
            // 
            this.playergroupBox.Controls.Add(this.paperPictureBox);
            this.playergroupBox.Controls.Add(this.rockPictureBox);
            this.playergroupBox.Controls.Add(this.scissorsPictureBox);
            this.playergroupBox.Location = new System.Drawing.Point(206, 104);
            this.playergroupBox.Name = "playergroupBox";
            this.playergroupBox.Size = new System.Drawing.Size(200, 100);
            this.playergroupBox.TabIndex = 0;
            this.playergroupBox.TabStop = false;
            this.playergroupBox.Text = "You";
            // 
            // paperPictureBox
            // 
            this.paperPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("paperPictureBox.Image")));
            this.paperPictureBox.Location = new System.Drawing.Point(71, 37);
            this.paperPictureBox.Name = "paperPictureBox";
            this.paperPictureBox.Size = new System.Drawing.Size(45, 35);
            this.paperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paperPictureBox.TabIndex = 2;
            this.paperPictureBox.TabStop = false;
            // 
            // rockPictureBox
            // 
            this.rockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rockPictureBox.Image")));
            this.rockPictureBox.Location = new System.Drawing.Point(6, 39);
            this.rockPictureBox.Name = "rockPictureBox";
            this.rockPictureBox.Size = new System.Drawing.Size(49, 33);
            this.rockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rockPictureBox.TabIndex = 1;
            this.rockPictureBox.TabStop = false;
            // 
            // scissorsPictureBox
            // 
            this.scissorsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("scissorsPictureBox.Image")));
            this.scissorsPictureBox.Location = new System.Drawing.Point(137, 37);
            this.scissorsPictureBox.Name = "scissorsPictureBox";
            this.scissorsPictureBox.Size = new System.Drawing.Size(36, 38);
            this.scissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scissorsPictureBox.TabIndex = 0;
            this.scissorsPictureBox.TabStop = false;
            // 
            // aigroupBox
            // 
            this.aigroupBox.Controls.Add(this.aipaperPictureBox);
            this.aigroupBox.Controls.Add(this.airockPictureBox);
            this.aigroupBox.Controls.Add(this.aiscissorsPictureBox);
            this.aigroupBox.Location = new System.Drawing.Point(611, 104);
            this.aigroupBox.Name = "aigroupBox";
            this.aigroupBox.Size = new System.Drawing.Size(200, 100);
            this.aigroupBox.TabIndex = 1;
            this.aigroupBox.TabStop = false;
            this.aigroupBox.Text = "Computer";
            // 
            // aipaperPictureBox
            // 
            this.aipaperPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("aipaperPictureBox.Image")));
            this.aipaperPictureBox.Location = new System.Drawing.Point(82, 37);
            this.aipaperPictureBox.Name = "aipaperPictureBox";
            this.aipaperPictureBox.Size = new System.Drawing.Size(45, 35);
            this.aipaperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aipaperPictureBox.TabIndex = 5;
            this.aipaperPictureBox.TabStop = false;
            // 
            // airockPictureBox
            // 
            this.airockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("airockPictureBox.Image")));
            this.airockPictureBox.Location = new System.Drawing.Point(17, 39);
            this.airockPictureBox.Name = "airockPictureBox";
            this.airockPictureBox.Size = new System.Drawing.Size(49, 33);
            this.airockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.airockPictureBox.TabIndex = 4;
            this.airockPictureBox.TabStop = false;
            // 
            // aiscissorsPictureBox
            // 
            this.aiscissorsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("aiscissorsPictureBox.Image")));
            this.aiscissorsPictureBox.Location = new System.Drawing.Point(148, 37);
            this.aiscissorsPictureBox.Name = "aiscissorsPictureBox";
            this.aiscissorsPictureBox.Size = new System.Drawing.Size(36, 38);
            this.aiscissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aiscissorsPictureBox.TabIndex = 3;
            this.aiscissorsPictureBox.TabStop = false;
            // 
            // outcomegroupBox
            // 
            this.outcomegroupBox.Location = new System.Drawing.Point(409, 257);
            this.outcomegroupBox.Name = "outcomegroupBox";
            this.outcomegroupBox.Size = new System.Drawing.Size(200, 100);
            this.outcomegroupBox.TabIndex = 2;
            this.outcomegroupBox.TabStop = false;
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versusLabel.Location = new System.Drawing.Point(487, 110);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(39, 30);
            this.versusLabel.TabIndex = 3;
            this.versusLabel.Text = "VS";
            // 
            // shootButton
            // 
            this.shootButton.Location = new System.Drawing.Point(469, 143);
            this.shootButton.Name = "shootButton";
            this.shootButton.Size = new System.Drawing.Size(75, 23);
            this.shootButton.TabIndex = 4;
            this.shootButton.Text = "Shoot";
            this.shootButton.UseVisualStyleBackColor = true;
            // 
            // rematchButton
            // 
            this.rematchButton.Location = new System.Drawing.Point(469, 172);
            this.rematchButton.Name = "rematchButton";
            this.rematchButton.Size = new System.Drawing.Size(75, 23);
            this.rematchButton.TabIndex = 5;
            this.rematchButton.Text = "Rematch";
            this.rematchButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 478);
            this.Controls.Add(this.rematchButton);
            this.Controls.Add(this.shootButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.outcomegroupBox);
            this.Controls.Add(this.aigroupBox);
            this.Controls.Add(this.playergroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.playergroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPictureBox)).EndInit();
            this.aigroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aipaperPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiscissorsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox playergroupBox;
        private PictureBox paperPictureBox;
        private PictureBox rockPictureBox;
        private PictureBox scissorsPictureBox;
        private GroupBox aigroupBox;
        private PictureBox aipaperPictureBox;
        private PictureBox airockPictureBox;
        private PictureBox aiscissorsPictureBox;
        private GroupBox outcomegroupBox;
        private Label versusLabel;
        private Button shootButton;
        private Button rematchButton;
    }
}