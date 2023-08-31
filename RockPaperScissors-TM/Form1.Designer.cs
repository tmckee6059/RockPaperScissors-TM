namespace RockPaperScissors_TM
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            playergroupBox = new GroupBox();
            paperPictureBox = new PictureBox();
            rockPictureBox = new PictureBox();
            scissorsPictureBox = new PictureBox();
            aigroupBox = new GroupBox();
            aipaperPictureBox = new PictureBox();
            airockPictureBox = new PictureBox();
            aiscissorsPictureBox = new PictureBox();
            outcomegroupBox = new GroupBox();
            drawLabel = new Label();
            loseLabel = new Label();
            winLabel = new Label();
            versusLabel = new Label();
            rematchButton = new Button();
            wintrackerLabel = new Label();
            aiwintrackerLabel = new Label();
            playergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paperPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rockPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scissorsPictureBox).BeginInit();
            aigroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)aipaperPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)airockPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aiscissorsPictureBox).BeginInit();
            outcomegroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // playergroupBox
            // 
            playergroupBox.Controls.Add(paperPictureBox);
            playergroupBox.Controls.Add(rockPictureBox);
            playergroupBox.Controls.Add(scissorsPictureBox);
            playergroupBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            playergroupBox.Location = new Point(34, 110);
            playergroupBox.Name = "playergroupBox";
            playergroupBox.Size = new Size(200, 100);
            playergroupBox.TabIndex = 0;
            playergroupBox.TabStop = false;
            playergroupBox.Text = "You";
            // 
            // paperPictureBox
            // 
            paperPictureBox.Image = (Image)resources.GetObject("paperPictureBox.Image");
            paperPictureBox.Location = new Point(71, 37);
            paperPictureBox.Name = "paperPictureBox";
            paperPictureBox.Size = new Size(45, 35);
            paperPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            paperPictureBox.TabIndex = 2;
            paperPictureBox.TabStop = false;
            paperPictureBox.Click += paperPictureBox_Click;
            // 
            // rockPictureBox
            // 
            rockPictureBox.Image = (Image)resources.GetObject("rockPictureBox.Image");
            rockPictureBox.Location = new Point(6, 39);
            rockPictureBox.Name = "rockPictureBox";
            rockPictureBox.Size = new Size(49, 33);
            rockPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            rockPictureBox.TabIndex = 1;
            rockPictureBox.TabStop = false;
            rockPictureBox.Click += rockPictureBox_Click;
            // 
            // scissorsPictureBox
            // 
            scissorsPictureBox.Image = (Image)resources.GetObject("scissorsPictureBox.Image");
            scissorsPictureBox.Location = new Point(137, 37);
            scissorsPictureBox.Name = "scissorsPictureBox";
            scissorsPictureBox.Size = new Size(36, 38);
            scissorsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            scissorsPictureBox.TabIndex = 0;
            scissorsPictureBox.TabStop = false;
            scissorsPictureBox.Click += scissorsPictureBox_Click;
            // 
            // aigroupBox
            // 
            aigroupBox.Controls.Add(aipaperPictureBox);
            aigroupBox.Controls.Add(airockPictureBox);
            aigroupBox.Controls.Add(aiscissorsPictureBox);
            aigroupBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            aigroupBox.Location = new Point(439, 110);
            aigroupBox.Name = "aigroupBox";
            aigroupBox.Size = new Size(200, 100);
            aigroupBox.TabIndex = 1;
            aigroupBox.TabStop = false;
            aigroupBox.Text = "AI";
            // 
            // aipaperPictureBox
            // 
            aipaperPictureBox.Image = (Image)resources.GetObject("aipaperPictureBox.Image");
            aipaperPictureBox.Location = new Point(82, 37);
            aipaperPictureBox.Name = "aipaperPictureBox";
            aipaperPictureBox.Size = new Size(45, 35);
            aipaperPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            aipaperPictureBox.TabIndex = 5;
            aipaperPictureBox.TabStop = false;
            // 
            // airockPictureBox
            // 
            airockPictureBox.Image = (Image)resources.GetObject("airockPictureBox.Image");
            airockPictureBox.Location = new Point(17, 39);
            airockPictureBox.Name = "airockPictureBox";
            airockPictureBox.Size = new Size(49, 33);
            airockPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            airockPictureBox.TabIndex = 4;
            airockPictureBox.TabStop = false;
            // 
            // aiscissorsPictureBox
            // 
            aiscissorsPictureBox.Image = (Image)resources.GetObject("aiscissorsPictureBox.Image");
            aiscissorsPictureBox.Location = new Point(148, 37);
            aiscissorsPictureBox.Name = "aiscissorsPictureBox";
            aiscissorsPictureBox.Size = new Size(36, 38);
            aiscissorsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            aiscissorsPictureBox.TabIndex = 3;
            aiscissorsPictureBox.TabStop = false;
            // 
            // outcomegroupBox
            // 
            outcomegroupBox.Controls.Add(drawLabel);
            outcomegroupBox.Controls.Add(loseLabel);
            outcomegroupBox.Controls.Add(winLabel);
            outcomegroupBox.Location = new Point(237, 263);
            outcomegroupBox.Name = "outcomegroupBox";
            outcomegroupBox.Size = new Size(200, 100);
            outcomegroupBox.TabIndex = 2;
            outcomegroupBox.TabStop = false;
            // 
            // drawLabel
            // 
            drawLabel.AutoSize = true;
            drawLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            drawLabel.Location = new Point(60, 32);
            drawLabel.Name = "drawLabel";
            drawLabel.Size = new Size(92, 45);
            drawLabel.TabIndex = 6;
            drawLabel.Text = "Draw";
            drawLabel.Visible = false;
            // 
            // loseLabel
            // 
            loseLabel.AutoSize = true;
            loseLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            loseLabel.Location = new Point(32, 28);
            loseLabel.Name = "loseLabel";
            loseLabel.Size = new Size(146, 45);
            loseLabel.TabIndex = 1;
            loseLabel.Text = "You Lose";
            loseLabel.Visible = false;
            loseLabel.Click += loseLabel_Click;
            // 
            // winLabel
            // 
            winLabel.AutoSize = true;
            winLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            winLabel.Location = new Point(31, 32);
            winLabel.Name = "winLabel";
            winLabel.Size = new Size(137, 45);
            winLabel.TabIndex = 0;
            winLabel.Text = "You Win";
            winLabel.Visible = false;
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            versusLabel.Location = new Point(315, 116);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(39, 30);
            versusLabel.TabIndex = 3;
            versusLabel.Text = "VS";
            // 
            // rematchButton
            // 
            rematchButton.Location = new Point(297, 178);
            rematchButton.Name = "rematchButton";
            rematchButton.Size = new Size(75, 23);
            rematchButton.TabIndex = 5;
            rematchButton.Text = "Rematch";
            rematchButton.UseVisualStyleBackColor = true;
            rematchButton.Click += rematchButton_Click;
            // 
            // wintrackerLabel
            // 
            wintrackerLabel.AutoSize = true;
            wintrackerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            wintrackerLabel.Location = new Point(106, 96);
            wintrackerLabel.Name = "wintrackerLabel";
            wintrackerLabel.Size = new Size(0, 30);
            wintrackerLabel.TabIndex = 6;
            // 
            // aiwintrackerLabel
            // 
            aiwintrackerLabel.AutoSize = true;
            aiwintrackerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            aiwintrackerLabel.Location = new Point(508, 96);
            aiwintrackerLabel.Name = "aiwintrackerLabel";
            aiwintrackerLabel.Size = new Size(0, 30);
            aiwintrackerLabel.TabIndex = 7;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(671, 478);
            Controls.Add(aiwintrackerLabel);
            Controls.Add(wintrackerLabel);
            Controls.Add(rematchButton);
            Controls.Add(versusLabel);
            Controls.Add(outcomegroupBox);
            Controls.Add(aigroupBox);
            Controls.Add(playergroupBox);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock, Paper, or Scissors?";
            playergroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)paperPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)rockPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)scissorsPictureBox).EndInit();
            aigroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)aipaperPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)airockPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)aiscissorsPictureBox).EndInit();
            outcomegroupBox.ResumeLayout(false);
            outcomegroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button rematchButton;
        private Label winLabel;
        private Label loseLabel;
        private Label drawLabel;
        private Label wintrackerLabel;
        private Label aiwintrackerLabel;
    }
}