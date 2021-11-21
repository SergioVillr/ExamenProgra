using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ExamenProgra
{
    public class Bacteria
    {
        public string nombre;
        public string especie;
        public int x, y;
        public PictureBox bacteria;

        Panel panel;

        public Bacteria()
        {
            this.nombre = "";
            this.especie = "";
            this.x = 0;
            this.y = 0;
        }

        public Bacteria(string nombre, string especie, int x, int y, Panel panel)
        {

            this.nombre = nombre;
            this.especie = especie;
            this.x = x;
            this.y = y;

            dibujarImagen(nombre, x, y, panel);

            this.panel.Controls.Add(bacteria);
        }

        void dibujarImagen(string nombre, int x, int y, Panel panel)
        {

            if (nombre == "PicBox_Bacteria1")
            {
                Console.WriteLine(x);
                Console.WriteLine(y);

                bacteria = new PictureBox();
                bacteria.Size = new Size(82, 63);
                Image imagen = Image.FromFile("..\\..\\resource\\bacterium1.png");
                bacteria.Image= imagen;
                bacteria.SizeMode = PictureBoxSizeMode.StretchImage;
                bacteria.BackColor = Color.Transparent;
                bacteria.Location = new Point(x-bacteria.Width/2, y-bacteria.Height);
                this.panel = panel;
            }
            else if (nombre == "PicBox_Bacteria2")
            {
                bacteria = new PictureBox();
                bacteria.Size = new Size(82, 63);
                Image imagen = Image.FromFile("..\\..\\resource\\bacterium3.png");
                bacteria.Image = imagen;
                bacteria.SizeMode = PictureBoxSizeMode.StretchImage;
                bacteria.BackColor = Color.Transparent;
                bacteria.Location = new Point(x - bacteria.Width / 2, y - bacteria.Height);
                this.panel = panel;
            }
            else if (nombre == "PicBox_Bacteria3")
            {
                bacteria = new PictureBox();
                bacteria.Size = new Size(82, 63);
                Image imagen = Image.FromFile("..\\..\\resource\\bacterium2.png");
                bacteria.Image = imagen;
                bacteria.SizeMode = PictureBoxSizeMode.StretchImage;
                bacteria.BackColor = Color.Transparent;
                bacteria.Location = new Point(x - bacteria.Width / 2, y - bacteria.Height);
                this.panel = panel;
            }
        }
    }
}
