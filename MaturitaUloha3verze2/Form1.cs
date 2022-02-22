namespace MaturitaUloha3verze2
{
    public partial class Form1 : Form
    {
        /*
        int a1 = 0;
        int a2 = 0;
        int f1 = 0;
        int f2 = 0;
        int p1 = 0;
        int p2 = 0;
        tohle je navíc
        */

        double x;
        double y;
        int xv;
        int yv;

        int i;
        int j;
        int k;
        int l;

        int[] polex = new int[20];
        int[] poley = new int[20];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /* 
            // Create pens.
            //Pen redPen = new Pen(Color.Red, 3);
            Pen greenPen = new Pen(Color.Green, 3);

            Point[] curvePoints = new Point[20];

            for (j = 0;j< 20;j++)
            {
                xv = polex[j];
                yv = poley[j];

                curvePoints[j] = new Point (xv, yv);
            }
            
            
            // Draw lines between original points to screen.
            e.Graphics.DrawLines(redPen, curvePoints);
            

            // Draw curve to screen.
            e.Graphics.DrawCurve(greenPen, curvePoints);
            */
        }

        private void but_Click(object sender, EventArgs e)
        {
            // Create pens.
            //Pen redPen = new Pen(Color.Red, 3);
            Pen greenPen = new Pen(Color.Green, 3);

            Point[] curvePoints = new Point[20];

            int f1 = frekvence1.Value;
            int f2 = frekvence2.Value;
            int a1 = amplituda1.Value;
            int a2 = amplituda2.Value;
            int p1 = fazpos1.Value;
            int p2 = fazpos2.Value;
            panel1.Refresh();

            for (i = 0; i < 20; i++)
            {
                x = a1 * Math.Sin(f1 * (i + 1) + p1) + 150;
                y = a2 * Math.Sin(f2 * (i + 1) + p2) + 150;
                polex[i] = Convert.ToInt32(Math.Round(x));
                poley[i] = Convert.ToInt32(Math.Round(y));
            }


            for (j = 0; j < 20; j++)
            {
                xv = polex[j];
                yv = poley[j];

                curvePoints[j] = new Point(xv, yv);
            }




            panel1.Refresh();
            panel1.CreateGraphics().DrawCurve(greenPen, curvePoints);
        }

        private void controlx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f1 = frekvence1.Value;
            int f2 = frekvence2.Value;
            int a1 = amplituda1.Value;
            int a2 = amplituda2.Value;
            int p1 = fazpos1.Value;
            int p2 = fazpos2.Value;

            controlx.Clear();

            for (i = 0; i < 20; i++)
            {
                x = a1 * Math.Sin(f1 * (i + 1) + p1);
                polex[i] = Convert.ToInt32(Math.Round(x));
            }
            for (k = 0; k < 20; k++)
            {

                controlx.Text = controlx.Text + "  " + polex[k];
            }
        }

        private void controly_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int f1 = frekvence1.Value;
            int f2 = frekvence2.Value;
            int a1 = amplituda1.Value;
            int a2 = amplituda2.Value;
            int p1 = fazpos1.Value;
            int p2 = fazpos2.Value;
            
            controly.Clear();

            for (i = 0; i < 20; i++)
            {
                y = a2 * Math.Sin(f2 * (i + 1) + p2);
                poley[i] = Convert.ToInt32(Math.Round(y));
            }
            for (l = 0; l < 20; l++)
            {
                controly.Text = controly.Text + "  " + poley[l];
            }
        }

        private void frekvence1_Scroll(object sender, EventArgs e)
        {
            int a = frekvence1.Value;
            frekbox1.Text = " " + a; 
        }

        private void frekbox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frekvence2_Scroll(object sender, EventArgs e)
        {
            int b = frekvence2.Value;
            frekbox2.Text = " " + b;
        }

        private void frekbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void amplituda1_Scroll(object sender, EventArgs e)
        {
            int c = amplituda1.Value;
            ampbox1.Text = " " + c;
        }

        private void ampbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void amplituda2_Scroll(object sender, EventArgs e)
        {
            int d = amplituda2.Value;
            ampbox2.Text = " " + d;
        }

        private void ampbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fazpos1_Scroll(object sender, EventArgs e)
        {
            int f = fazpos1.Value;
            fazbox1.Text = " " + f;
        }

        private void fazbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fazpos2_Scroll(object sender, EventArgs e)
        {
            int g = fazpos2.Value;
            fazbox2.Text = " " + g;
        }

        private void fazbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vypnout_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void ukazatel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ukazatel2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ukazatel3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ukazatel4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ukazatel5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ukazatel6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
