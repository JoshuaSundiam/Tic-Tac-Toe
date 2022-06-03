namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        public Form1()
        {

            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            if (turn)
                b1.Text = "X";
            else
                b1.Text = "O";
            turn = !turn;
            b1.Enabled = false;

        }

        private void b2_Click(object sender, EventArgs e)
        {
            Button b2 = (Button)sender;
            if (turn)
                b2.Text = "X";
            else
                b2.Text = "O";
            turn = !turn;
            b2.Enabled = false;

        }

        private void b3_Click(object sender, EventArgs e)
        {
            Button b3 = (Button)sender;
            if (turn)
                b3.Text = "X";
            else
                b3.Text = "O";
            turn = !turn;
            b3.Enabled = false;

        }

        private void b4_Click(object sender, EventArgs e)
        {
            Button b4 = (Button)sender;
            if (turn)
                b4.Text = "X";
            else
                b4.Text = "O";
            turn = !turn;
            b4.Enabled = false;

        }

        private void b5_Click(object sender, EventArgs e)
        {
            Button b5 = (Button)sender;
            if (turn)
                b5.Text = "X";
            else
                b5.Text = "O";
            turn = !turn;
            b5.Enabled = false;

        }

        private void b6_Click(object sender, EventArgs e)
        {
            Button b6 = (Button)sender;
            if (turn)
                b6.Text = "X";
            else
                b6.Text = "O";
            turn = !turn;
            b6.Enabled = false;

        }

        private void b7_Click(object sender, EventArgs e)
        {
            Button b7 = (Button)sender;
            if (turn)
                b7.Text = "X";
            else
                b7.Text = "O";
            turn = !turn;
            b7.Enabled = false;

        }

        private void b8_Click(object sender, EventArgs e)
        {
            Button b8 = (Button)sender;
            if (turn)
                b8.Text = "X";
            else
                b8.Text = "O";
            turn = !turn;
            b8.Enabled = false;

        }

        private void b9_Click(object sender, EventArgs e)
        {
            Button b9 = (Button)sender;
            if (turn)
                b9.Text = "X";
            else
                b9.Text = "O";
            turn = !turn;
            b9.Enabled = false;

        }
    }
}