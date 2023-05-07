using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajodeclase2HP2
{
    internal class Balas
    {

        public int disparo(Point posicion, Point posicion_ene)
        {
            int puntos = 0;

            PictureBox bala = new PictureBox();

            bala.Image = Properties.Resources.bala;
            bala.Size = new Size(117, 90);
            bala.Location = posicion;

            for (int i = posicion.Y; i >= 0;)
            {
                int Y = posicion.Y;
                int X = posicion.X;

                Y = Y + 10;

                Point posi = new Point(X, Y);
                bala.Location = posi;

                if (bala.Location.X == posicion_ene.X && bala.Location.Y == posicion.Y)
                {
                    puntos = puntos + 100;
                    break;
                }

                i = i - 10;
            }

            return puntos;
        }
    }
}
