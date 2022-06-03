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
            turn_count++;
            CheckingForWinner();
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
            turn_count++;
            CheckingForWinner();
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
            turn_count++;
            CheckingForWinner();
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
            turn_count++;
            CheckingForWinner();
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
            turn_count++;
            CheckingForWinner();
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
            turn_count++;
            CheckingForWinner();
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
            turn_count++;
            CheckingForWinner();
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
            turn_count++;
            CheckingForWinner();
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
            turn_count++;
            CheckingForWinner();
        }
        private void CheckingForWinner()
        {
            Boolean There_is_a_winner = false;

            if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                There_is_a_winner = true;
            else if ((b4.Text == b5.Text) && (b5.Text == b6.Text) && (!b4.Enabled))
                There_is_a_winner = true;
            else if ((b7.Text == b8.Text) && (b8.Text == b9.Text) && (!b7.Enabled))
                There_is_a_winner = true;

            else if ((b1.Text == b4.Text) && (b4.Text == b7.Text) && (!b1.Enabled))
                There_is_a_winner = true;
            else if ((b2.Text == b5.Text) && (b5.Text == b8.Text) && (!b2.Enabled))
                There_is_a_winner = true;
            else if ((b3.Text == b6.Text) && (b6.Text == b9.Text) && (!b3.Enabled))
                There_is_a_winner = true;

            else if ((b1.Text == b5.Text) && (b5.Text == b9.Text) && (!b1.Enabled))
                There_is_a_winner = true;
            else if ((b3.Text == b5.Text) && (b5.Text == b7.Text) && (!b3.Enabled))
                There_is_a_winner = true;

            if (There_is_a_winner)
            {
                disableButtons();
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + "wins");

            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Its a draw");

            }
        }
        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b1 = (Button)c;
                    b1.Enabled = false;
                    Button b2 = (Button)c;
                    b2.Enabled = false;
                    Button b3 = (Button)c;
                    b3.Enabled = false;
                    Button b4 = (Button)c;
                    b4.Enabled = false;
                    Button b5 = (Button)c;
                    b5.Enabled = false;
                    Button b6 = (Button)c;
                    b6.Enabled = false;
                    Button b7 = (Button)c;
                    b7.Enabled = false;
                    Button b8 = (Button)c;
                    b8.Enabled = false;
                    Button b9 = (Button)c;
                    b9.Enabled = false;
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean There_is_a_winner = true;
            if (There_is_a_winner)
            {
                b1.Enabled = true;
                b1.Text = "";

                b2.Enabled = true;
                b2.Text = "";

                b3.Enabled = true;
                b3.Text = "";

                b4.Enabled = true;
                b4.Text = "";

                b5.Enabled = true;
                b5.Text = "";

                b6.Enabled = true;
                b6.Text = "";

                b7.Enabled = true;
                b7.Text = "";

                b8.Enabled = true;
                b8.Text = "";

                b9.Enabled = true;

            }
        }
    }
}