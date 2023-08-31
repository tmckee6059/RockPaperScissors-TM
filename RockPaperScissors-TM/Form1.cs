using System.Security.Cryptography.X509Certificates;

namespace RockPaperScissors_TM
{
    public partial class GameForm : Form
    {
        int winCount = 1;
        int aiwinCount = 1;


        public GameForm()
        {
            InitializeComponent();
        }

        private void rockPictureBox_Click(object sender, EventArgs e)
        {

            string inputCPU;
            string inputPlayer = "rock";
            int randomInt;
            paperPictureBox.Visible = false;
            rockPictureBox.Visible = true;
            scissorsPictureBox.Visible = false;
            Random rnd = new Random();
            randomInt = rnd.Next(1, 4);


            switch (randomInt)
            {
                case 1:
                    inputCPU = "rock";
                    drawLabel.Visible = true;
                    winLabel.Visible = false;
                    loseLabel.Visible = false;
                    airockPictureBox.Visible = true;
                    aipaperPictureBox.Visible = false;
                    aiscissorsPictureBox.Visible = false;
                    break;
                case 2:
                    inputCPU = "paper";
                    loseLabel.Visible = true;
                    winLabel.Visible = false;
                    drawLabel.Visible = false;
                    airockPictureBox.Visible = false;
                    aipaperPictureBox.Visible = true;
                    aiscissorsPictureBox.Visible = false;
                    aiwintrackerLabel.Text = "Wins: " + aiwinCount++;

                    break;
                case 3:
                    inputCPU = "scissors";
                    winLabel.Visible = true;
                    loseLabel.Visible = false;
                    drawLabel.Visible = false;
                    airockPictureBox.Visible = false;
                    aipaperPictureBox.Visible = false;
                    aiscissorsPictureBox.Visible = true;
                    wintrackerLabel.Text = "Wins: " + winCount++;
                    break;
            }


        }

        private void paperPictureBox_Click(object sender, EventArgs e)
        {
            string inputCPU;
            string inputPlayer = "paper";
            int randomInt;
            bool playerWins;
            bool tie;
            paperPictureBox.Visible = true;
            rockPictureBox.Visible = false;
            scissorsPictureBox.Visible = false;

            Random rnd = new Random();

            randomInt = rnd.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "rock";
                    drawLabel.Visible = false;
                    winLabel.Visible = true;
                    loseLabel.Visible = false;
                    airockPictureBox.Visible = true;
                    aipaperPictureBox.Visible = false;
                    aiscissorsPictureBox.Visible = false;
                    wintrackerLabel.Text = "Wins: " + winCount++;
                    break;
                case 2:
                    inputCPU = "paper";
                    loseLabel.Visible = false;
                    winLabel.Visible = false;
                    drawLabel.Visible = true;
                    airockPictureBox.Visible = false;
                    aipaperPictureBox.Visible = true;
                    aiscissorsPictureBox.Visible = false;
                    break;
                case 3:
                    inputCPU = "scissors";
                    winLabel.Visible = false;
                    loseLabel.Visible = true;
                    drawLabel.Visible = false;
                    airockPictureBox.Visible = false;
                    aipaperPictureBox.Visible = false;
                    aiscissorsPictureBox.Visible = true;
                    aiwintrackerLabel.Text = "Wins: " + aiwinCount++;
                    break;
            }
        }

        private void scissorsPictureBox_Click(object sender, EventArgs e)
        {
            string inputCPU;
            string inputPlayer = "scissors";
            int randomInt;
            bool playerWins;
            bool tie;
            paperPictureBox.Visible = false;
            rockPictureBox.Visible = false;
            scissorsPictureBox.Visible = true;

            Random rnd = new Random();

            randomInt = rnd.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "rock";
                    drawLabel.Visible = false;
                    winLabel.Visible = false;
                    loseLabel.Visible = true;
                    airockPictureBox.Visible = true;
                    aipaperPictureBox.Visible = false;
                    aiscissorsPictureBox.Visible = false;
                    aiwintrackerLabel.Text = "Wins: " + aiwinCount++;
                    break;
                case 2:
                    inputCPU = "paper";
                    loseLabel.Visible = false;
                    winLabel.Visible = true;
                    drawLabel.Visible = false;
                    airockPictureBox.Visible = false;
                    aipaperPictureBox.Visible = true;
                    aiscissorsPictureBox.Visible = false;
                    wintrackerLabel.Text = "Wins: " + winCount++;
                    break;
                case 3:
                    inputCPU = "scissors";
                    winLabel.Visible = false;
                    loseLabel.Visible = false;
                    drawLabel.Visible = true;
                    airockPictureBox.Visible = false;
                    aipaperPictureBox.Visible = false;
                    aiscissorsPictureBox.Visible = true;
                    break;
            }
        }

        private void rematchButton_Click(object sender, EventArgs e)
        {
            paperPictureBox.Visible = true;
            rockPictureBox.Visible = true;
            scissorsPictureBox.Visible = true;
            aipaperPictureBox.Visible = true;
            airockPictureBox.Visible = true;
            aiscissorsPictureBox.Visible = true;
            drawLabel.Visible = false;
            winLabel.Visible = false;
            loseLabel.Visible = false;
        }

        private void UpdateWinLabel()
        {
            wintrackerLabel.Text = "Wins: " + winCount.ToString();
        }

        public void HandleWin()
        {
            if (winLabel.Visible)
            {
                winCount++;
                UpdateWinLabel();
            }
        }

        private void loseLabel_Click(object sender, EventArgs e)
        {

        }
    }
}