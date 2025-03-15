namespace projeto_1bim_icg
{
    public partial class Form1 : Form
    {
        private int m_global;
        private int x1_global = 0;
        private int x2_global = 0;
        private int b_global;
        private int y1_global = 0;
        private int y2_global = 0;

        private void PintaPlano(PaintEventArgs e)
        {
            int meiox = this.Width / 2;
            int meioy = this.Height / 2;
            Color cor = new Color();
            cor = Color.FromArgb(0, 0, 0);
            Pen caneta = new Pen(cor);
            e.Graphics.DrawLine(caneta, meiox, 0, meiox, this.Height);
            e.Graphics.DrawLine(caneta, 0, meioy, this.Width, meioy);
        }

        private void pintaLinha(int x1, int x2, int y1, int y2, PaintEventArgs e)
        {
            int meiox = this.Width / 2;
            int meioy = this.Height / 2;

            Color cor = new Color();
            cor = Color.FromArgb(255, 0, 0);
            Pen caneta = new Pen(cor);

            e.Graphics.DrawLine(caneta, meiox+x1, meioy-y1, meiox+x2, meioy-y2);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            PintaPlano(e);
            pintaLinha(x1_global, x2_global, y1_global, y2_global, e);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            m_global = int.Parse(textBox1.Text);
            b_global = int.Parse(textBox2.Text);
            x1_global = int.Parse(textBox3.Text);
            x2_global = int.Parse(textBox4.Text);

            y1_global = m_global * x1_global + b_global;
            y2_global = m_global * x2_global + b_global;

            Invalidate();
        }
    }
}
