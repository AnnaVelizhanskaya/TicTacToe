using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace kursaaaaash
{
    public partial class TicTacToe : Form
    {
        string t = "";
        Random rnd = new Random();
        int[] array = new int[10];
        Button[] btn = new Button[9];

        public TicTacToe()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            if (rnd.Next(1, 10) <= 5)
            {
                t = "��������";
                label1.Text = "����� X";
            }

            else
            {
                t = "����� �";
                label1.Text = "����� �";
            }

            btn[0] = button1;
            btn[1] = button2;
            btn[2] = button3;
            btn[3] = button4;
            btn[4] = button5;
            btn[5] = button6;
            btn[6] = button7;
            btn[7] = button8;
            btn[8] = button9;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (t == "��������")
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "X";
                        label1.Text = "����� �";
                        t = "1";
                        btn[i].Enabled = false;
                        array[i] = 1;
                        break;
                    }
                }
            }

            else
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "0";
                        label1.Text = "����� X";
                        t = "��������";
                        btn[i].Enabled = false;
                        array[i] = 2;
                        break;
                    }
                }
            }

            if (array[0] == 1 && array[1] == 1 && array[2] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[2].BackColor = System.Drawing.Color.Red;



                button10.Enabled = true;
                label1.Text = "�������� ��������";

            }

            else if (array[3] == 1 && array[4] == 1 && array[5] == 1)
            {
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;



                button10.Enabled = true;
                label1.Text = "�������� ��������";

            }

            else if (array[6] == 1 && array[7] == 1 && array[8] == 1)
            {
                btn[6].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;


                button10.Enabled = true;
                label1.Text = "�������� ��������";

            }

            else if (array[0] == 1 && array[3] == 1 && array[6] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;



                button10.Enabled = true;
                label1.Text = "�������� ��������";

            }

            else if (array[1] == 1 && array[4] == 1 && array[7] == 1)
            {
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;



                button10.Enabled = true;
                label1.Text = "�������� ��������";

            }

            else if (array[2] == 1 && array[5] == 1 && array[8] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;



                button10.Enabled = true;
                label1.Text = "�������� ��������";

            }

            else if (array[0] == 1 && array[4] == 1 && array[8] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;



                button10.Enabled = true;
                label1.Text = "�������� ��������";

            }

            else if (array[2] == 1 && array[4] == 1 && array[6] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;



                button10.Enabled = true;
                label1.Text = "�������� ��������";

            }

            else if (array[0] == 2 && array[1] == 2 && array[2] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[2].BackColor = System.Drawing.Color.Red;



                button10.Enabled = true;
                label1.Text = "�������� ������";

            }

            else if (array[3] == 2 && array[4] == 2 && array[5] == 2)
            {
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;



                button10.Enabled = true;
                label1.Text = "�������� ������";

            }

            else if (array[6] == 2 && array[7] == 2 && array[8] == 2)
            {
                btn[6].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;



                button10.Enabled = true;
                label1.Text = "�������� ������";

            }

            else if (array[0] == 2 && array[3] == 2 && array[6] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;



                button10.Enabled = true;
                label1.Text = "�������� ������";

            }

            else if (array[1] == 2 && array[4] == 2 && array[7] == 2)
            {
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;


                button10.Enabled = true;
                label1.Text = "�������� ������";

            }

            else if (array[2] == 2 && array[5] == 2 && array[8] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;



                button10.Enabled = true;
                label1.Text = "�������� ������";

            }

            else if (array[0] == 2 && array[4] == 2 && array[8] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;



                button10.Enabled = true;
                label1.Text = "�������� ������";

            }

            else if (array[2] == 2 && array[4] == 2 && array[6] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;


                button10.Enabled = true;
                label1.Text = "�������� ������";

            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < btn.Length; i++)
            {
                array[i] = 0;
                btn[i].Text = " ";

                if (rnd.Next(1, 10) <= 5)
                {
                    t = "��������";
                    label1.Text = "����� X";
                }
                else
                {
                    t = "����� �";
                    label1.Text = "����� �";
                }

                btn[i].Enabled = true;
                btn[i].BackColor = System.Drawing.Color.White;
            }
        }

        public void Button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�� �������, ��� ������ �����?", Application.ProductName, MessageBoxButtons.YesNo) != DialogResult.No)
                Application.Exit();
        }

        
    }
}