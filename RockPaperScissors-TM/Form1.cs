namespace RockPaperScissors_TM
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void rockPictureBox_Click(object sender, EventArgs e)
        {
            string inputCPU;
            string inputPlayer = "rock";
            int randomInt;

            Random rnd = new Random();

            randomInt = rnd.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "rock";
                    drawLabel.Visible = true;
                    winLabel.Visible = false;
                    loseLabel.Visible = false;
                    break;
                case 2:
                    inputCPU = "paper";
                    loseLabel.Visible = true;
                    winLabel.Visible = false;
                    drawLabel.Visible = false;
                    break;
                case 3:
                    inputCPU = "scissors";
                    winLabel.Visible = true;
                    loseLabel.Visible = false;
                    drawLabel.Visible = false;
                    break;
            }


        }

        private void paperPictureBox_Click(object sender, EventArgs e)
        {
            string inputCPU;
            string inputPlayer = "paper";
            int randomInt;

            Random rnd = new Random();

            randomInt = rnd.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "rock";
                    drawLabel.Visible = false;
                    winLabel.Visible = true;
                    loseLabel.Visible = false;
                    break;
                case 2:
                    inputCPU = "paper";
                    loseLabel.Visible = false;
                    winLabel.Visible = false;
                    drawLabel.Visible = true;
                    break;
                case 3:
                    inputCPU = "scissors";
                    winLabel.Visible = false;
                    loseLabel.Visible = true;
                    drawLabel.Visible = false;
                    break;
            }
        }

        private void scissorsPictureBox_Click(object sender, EventArgs e)
        {
            string inputCPU;
            string inputPlayer = "scissors";
            int randomInt;

            Random rnd = new Random();

            randomInt = rnd.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "rock";
                    drawLabel.Visible = false;
                    winLabel.Visible = false;
                    loseLabel.Visible = true;
                    break;
                case 2:
                    inputCPU = "paper";
                    loseLabel.Visible = false;
                    winLabel.Visible = true;
                    drawLabel.Visible = false;
                    break;
                case 3:
                    inputCPU = "scissors";
                    winLabel.Visible = false;
                    loseLabel.Visible = false;
                    drawLabel.Visible = true;
                    break;
            }
        }
    }
}