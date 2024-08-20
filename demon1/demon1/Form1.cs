namespace demon1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int o = 0, x = 0;
        Random random = new Random();
        bool gameflag;
        private void Form1_Load(object sender, EventArgs e)
        {
            gameflag = true;
            timer1.Interval = 300;
            timer1.Start();

            progressBar1.Value = 100;
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(!gameflag) return;



            char keyChar = (char)e.KeyCode;

            if (listBox1.Items.Contains(keyChar))
            {
                o += 1;
                listBox1.Items.Remove(keyChar);

            }
            
            else
                x += 1;
            
            textBox1.Text = "";
            correct.Text = ("맞은개수 : " + o);
            wrong.Text = ("틀린개수 : " + x);
            double percentage = (double) o/(o + x) * 100;

            progressBar1.Value = (int)Math.Truncate(percentage);
            if (o >= 30)
            {
                if (!gameflag) return;
                timer1.Stop();
                Formwin frm = new Formwin();
                frm.ShowDialog();
            }
            else if (x >= 30)
            {


                if (!gameflag) return;
                timer1.Stop();
                Formloss frm = new Formloss();
                frm.ShowDialog();
                gameflag = false;
            }
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            char alphabet = (char)(random.Next(26) + 65);

            listBox1.Items.Add(alphabet);
        }
    }
}
