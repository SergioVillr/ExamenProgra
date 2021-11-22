using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Timers;



namespace ExamenProgra
{
    public class Bacteria
    {
        public string nombre;
        public string especie;
        public int x, y;
        public PictureBox bacteria;
        System.Timers.Timer tm;

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
            this.panel = panel;
            this.x = x;
            this.y = y;
            this.bacteria= new PictureBox();


            dibujarImagen();
            
            this.panel.Controls.Add(bacteria);
            Mover();



        }

        public void dibujarImagen()
        {

            if (nombre == "PicBox_Bacteria1")
            {
                Console.WriteLine(x);
                Console.WriteLine(y);

                //bacteria = new PictureBox();
                bacteria.Size = new Size(82, 63);
                Image imagen = Image.FromFile("..\\..\\resource\\bacterium1.png");
                bacteria.Image= imagen;
                bacteria.SizeMode = PictureBoxSizeMode.StretchImage;
                //bacteria.BackColor = Color.Transparent;
                bacteria.Location = new Point(x,y);
                this.panel.Controls.Add(bacteria);

                //tm = new System.Timers.Timer();
                //tm.Interval = 1000;
                //tm.Elapsed += new System.Timers.ElapsedEventHandler(Mover);
                //tm.Enabled = true;


            }
            else if (nombre == "PicBox_Bacteria2")
            {
                bacteria = new PictureBox();
                bacteria.Size = new Size(82, 63);
                Image imagen = Image.FromFile("..\\..\\resource\\bacterium3.png");
                bacteria.Image = imagen;
                bacteria.SizeMode = PictureBoxSizeMode.StretchImage;
                bacteria.BackColor = Color.Transparent;
                bacteria.Location = new Point(x, y);
                //this.panel.Controls.Add(bacteria);
            }
            else if (nombre == "PicBox_Bacteria3")
            {
                bacteria = new PictureBox();
                bacteria.Size = new Size(82, 63);
                Image imagen = Image.FromFile("..\\..\\resource\\bacterium2.png");
                bacteria.Image = imagen;
                bacteria.SizeMode = PictureBoxSizeMode.StretchImage;
                bacteria.BackColor = Color.Transparent;
                bacteria.Location = new Point(x, y);
                //this.panel.Controls.Add(bacteria);
            }
        }

        void Timer_tick(object sender, EventArgs e)
        {
            bacteria.Location = new Point(bacteria.Location.X, bacteria.Location.Y + 10);
        }

        public void Mover()
        {
            if (bacteria.InvokeRequired)
            {
                bacteria.Invoke(new MethodInvoker(delegate
                {
                    while (bacteria.Location.Y + bacteria.Height < panel.Height)
                    {
                        //Console.WriteLine("que asco");
                        //bacteria.Location = new Point(bacteria.Location.X, bacteria.Location.Y+10);
                        //Thread.Sleep(20); // Este cambio de posición se hará 5 veces por Segundo.

                        Point punt = bacteria.Location;

                        int x = punt.X;
                        int y = punt.Y;

                        y += 5;

                        Point punto = new Point(x, y);
                        bacteria.Location = punto;
                        this.panel.Refresh();
                        Thread.Sleep(500);
                    }
                }));
            }
            else
            {
                while (bacteria.Location.Y + bacteria.Height < panel.Height)
                {

                    //bacteria.Location = new Point(bacteria.Location.X, bacteria.Location.Y + 10);
                    //Thread.Sleep(200); // Este cambio de posición se hará 5 veces por Segundo.

                    Point punt = bacteria.Location;

                    int x = punt.X;
                    int y = punt.Y;

                    y += 5;

                    Point punto = new Point(x, y);
                    bacteria.Location = punto;
                }
            } 
        }
    }
}
