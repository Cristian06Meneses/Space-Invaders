namespace Trabajodeclase2HP2
{
    public partial class Form1 : Form
    {
        bool direccion = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            int x = pic_enemigo.Location.X;
            int y = pic_enemigo.Location.Y;

            if (pic_enemigo.Location.X > 650)
            {
                direccion = false;
                y = y + 15;
                Point posicion = new Point(x, y);
                pic_enemigo.Location = posicion;
            }

            if (pic_enemigo.Location.X < 0)
            {
                direccion = true;
                y = y + 15;
                Point posicion = new Point(x, y);
                pic_enemigo.Location = posicion;
            }

            if (direccion == true)
            {
                x = x + 10;
                Point posicion = new Point(x, y);
                pic_enemigo.Location = posicion;
            }

            if (direccion == false)
            {
                x = x - 10;
                Point posicion = new Point(x, y);
                pic_enemigo.Location = posicion;
            }

            if (pic_enemigo.Location.Y >= 210 && pic_enemigo.Location.Y <= 235)
            {
                Point inicio = new Point(310, 12);
                pic_enemigo.Location = inicio;

                tmr1.Interval = tmr1.Interval - 10;
            }

            if (tmr1.Interval == 0)
            {
                tmr1.Enabled = false;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x1 = pic_amigo.Location.X;
            int y1 = pic_amigo.Location.Y;

            if (e.KeyChar == 50/*(char)Keys.Right*/ && pic_amigo.Location.X < 650)
            {
                x1 = x1 + 25;
                Point posicion = new Point(x1, y1);
                pic_amigo.Location = posicion;
            }

            if (e.KeyChar == 49/*(char)Keys.Left*/ && pic_amigo.Location.X > 0)
            {
                x1 = x1 - 25;
                Point posicion = new Point(x1, y1);
                pic_amigo.Location = posicion;
            }

            if (e.KeyChar == 46)
            {
                Point ami_posi = pic_amigo.Location;
                Point ene_posi = pic_enemigo.Location;

                Balas bala = new Balas();
                bala.disparo(ami_posi, ene_posi);


            }
        }
    }
}

//310; 227