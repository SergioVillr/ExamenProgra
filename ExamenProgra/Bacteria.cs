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
        public int x, y,a;
        public PictureBox bacteria;
        public PictureBox hijo;
        System.Timers.Timer tm;

        int alpha = 0;

        Panel panel;

        public Bacteria()
        {
            this.nombre = "";
            this.especie = "";
            this.x = 0;
            this.y = 0;
            this.a = 0;
            
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
            _ = Mover();



        }
        public void hijoBacteria(int n)
        {
            //hijo = new PictureBox();
            if(n == 1)
            {
                hijo = new PictureBox();
                hijo.Name = "Psicrofilas";
                hijo.Size = new Size(41, 31);
                Image imagen = Image.FromFile("..\\..\\resource\\bacterium1.png");
                hijo.Image = imagen;
                hijo.SizeMode = PictureBoxSizeMode.StretchImage;
                if (a == 1)
                {
                    Console.WriteLine("Evalua a ");
                    hijo.Location = new Point(x + 70, y + 70);
                }
                this.panel.Controls.Add(hijo);
                _ = Moverhijo();
            }
            if (n == 2)
            {
                hijo = new PictureBox();
                hijo.Name = "Mesofilas";
                hijo.Size = new Size(41, 31);
                Image imagen = Image.FromFile("..\\..\\resource\\bacterium3.png");
                hijo.Image = imagen;
                hijo.SizeMode = PictureBoxSizeMode.StretchImage;
                if (a == 1)
                {
                    Console.WriteLine("Evalua a ");
                    hijo.Location = new Point(x + 70, y + 70);
                }
                this.panel.Controls.Add(hijo);
                _ = Moverhijo();
            }
            if (n == 3)
            {
                hijo = new PictureBox();
                hijo.Name = "Termofilas";
                hijo.Size = new Size(41, 31);
                Image imagen = Image.FromFile("..\\..\\resource\\bacterium2.png");
                hijo.Image = imagen;
                hijo.SizeMode = PictureBoxSizeMode.StretchImage;
                if (a == 1)
                {
                    Console.WriteLine("Evalua a ");
                    hijo.Location = new Point(x + 70, y + 70);
                }
                this.panel.Controls.Add(hijo);
                _ = Moverhijo();
            }

        }

        public async Task Moverhijo()
        {
            if (hijo.InvokeRequired)
            {
                hijo.Invoke(new MethodInvoker(delegate
                {

                    while (hijo.Location.Y + hijo.Width < panel.Height)
                    {
                        if (Direccion() == 1)
                        {
                            Point punt = hijo.Location;

                            int x = punt.X;
                            int y = punt.Y;

                            y += 5;

                            Point punto = new Point(x, y);
                            hijo.Location = punto;
                        }

                    }
                }));
                await Task.Delay(100);
            }
            else
            {
                Point punt = hijo.Location;
                int x = punt.X;
                int y = punt.Y;
                int sx = 41;
                int sy = 31;
                while (hijo.Location.Y + hijo.Width < panel.Height)
                {


                    if (sx < 82)
                    {
                        sx += 10;
                        sy += 10;
                    }
                    if (Direccion() > 0 && Direccion() < 250)
                    {
                        hijo.Size = new Size(sx, sy);

                        y += 10;

                        Point punto = new Point(x, y);
                        hijo.Location = punto;
                    }
                    if (Direccion() > 250 && Direccion() < 500)
                    {
                        x += 10;

                        Point punto = new Point(x, y);
                        hijo.Location = punto;
                    }
                    if (Direccion() > 500 && Direccion() < 750)
                    {
                        x -= 10;

                        Point punto = new Point(x, y);
                        hijo.Location = punto;
                    }

                    if (Direccion() > 750 && Direccion() < 1000)
                    {
                        y -= 10;

                        Point punto = new Point(x, y);
                        hijo.Location = punto;
                    }
                    await Task.Delay(100);
                }

            }
        }

        public void dibujarImagen()
        {

            if (nombre == "PicBox_Bacteria1")
            {
                //Console.WriteLine(x);
                //Console.WriteLine(y);

                //bacteria = new PictureBox();
                bacteria.Name = "Psicrofilas";
                bacteria.Size = new Size(41, 31);
                
                //bacteria.Size = new Size(41, 31);
                Image imagen = Image.FromFile("..\\..\\resource\\bacterium1.png");
                bacteria.Image= imagen;
                bacteria.SizeMode = PictureBoxSizeMode.StretchImage;
                //bacteria.BackColor = Color.Transparent;
                bacteria.Location = new Point(x,y);
                //if (a == 1)
                //{
                //    Console.WriteLine("Evalua a ");
                //    bacteria.Location = new Point(x+10, y+10);
                //}
                //this.panel.Controls.Add(bacteria);

                //tm = new System.Timers.Timer();
                //tm.Interval = 1000;
                //tm.Elapsed += new System.Timers.ElapsedEventHandler(Mover);
                //tm.Enabled = true;


            }
            else if (nombre == "PicBox_Bacteria2")
            {
                //bacteria = new PictureBox();
                bacteria.Name = "Mesofilas";
                bacteria.Size = new Size(41, 31);
                Image imagen = Image.FromFile("..\\..\\resource\\bacterium3.png");
                bacteria.Image = imagen;
                bacteria.SizeMode = PictureBoxSizeMode.StretchImage;
                bacteria.BackColor = Color.Transparent;
                bacteria.Location = new Point(x, y);

                //this.panel.Controls.Add(bacteria);
            }
            else if (nombre == "PicBox_Bacteria3")
            {
                //bacteria = new PictureBox();
                bacteria.Name = "Termofilas";
                bacteria.Size = new Size(41, 31);
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
            if (alpha < 60)
            {
                Console.WriteLine(alpha);
                Image image = bacteria.Image;
                using (Graphics g = Graphics.FromImage(image))
                {
                    Pen pen = new Pen(Color.FromArgb(alpha, 153, 180, 209), image.Width);
                    g.DrawLine(pen, -1, -1, image.Width, image.Height);
                    g.Save();
                }
                bacteria.Image = image;
                alpha++;
            }
            else
            {
                Console.WriteLine("else");
                tm.Stop();
            }
        }

        int Direccion()
        {
            Random random = new Random();

            int num = random.Next(0, 1000);

            return num;

        }


        public async Task Mover()
        {
            if (bacteria.InvokeRequired)
            {
                bacteria.Invoke(new MethodInvoker(delegate
                {
                    
                    while (bacteria.Location.Y + bacteria.Width < panel.Height)
                    {
                        //Console.WriteLine("que asco");
                        //bacteria.Location = new Point(bacteria.Location.X, bacteria.Location.Y+10);
                        //Thread.Sleep(20); // Este cambio de posición se hará 5 veces por Segundo.
                        if(Direccion()==1)
                        {

                            //Console.WriteLine("Entro al if ");
                            Point punt = bacteria.Location;

                        int x = punt.X;
                        int y = punt.Y;

                        y += 5;

                        Point punto = new Point(x, y);
                        bacteria.Location = punto;
                        //this.panel.Refresh();
                        }
                        
                        //Thread.Sleep(500);
                        
                    }
                }));
                await Task.Delay(100);
            }
            else
            {
                Point punt = bacteria.Location;
                int x = punt.X;
                int y = punt.Y;
                int sx = 41;
                int sy = 31;
                while (bacteria.Location.Y + bacteria.Width < panel.Height)
                {

                    if(sx<61)
                    {
                        Console.WriteLine("Llama a dibujar imagen ");
                        a = 1;
                        if(bacteria.Name == "Psicrofilas")
                        {
                            Console.WriteLine("Primer IF ");
                            hijoBacteria(1);
                        }
                        if (bacteria.Name == "Mesofilas")
                        {
                            hijoBacteria(2);
                        }
                        if (bacteria.Name == "Termofilas")
                        {
                            hijoBacteria(3);
                        }
                        
                    }
                    if (sx < 82)
                    {
                        sx += 10;
                        sy += 10;
                    }
                    if (Direccion() > 0 && Direccion() < 250)
                    {
                        //Console.WriteLine("El valor de Direccion es " + Direccion());
                        //Console.WriteLine("Entro al if ");
                        bacteria.Size = new Size(sx, sy);
                        //Point punt = bacteria.Location;
                        //int x = punt.X;
                        //int y = punt.Y;

                        y += 10;

                        Point punto = new Point(x, y);
                        bacteria.Location = punto;
                        //this.panel.Refresh();
                    }
                    if (Direccion() > 250 && Direccion() < 500)
                    {
                        //Console.WriteLine("El valor de Direccion es " + Direccion());
                        //Console.WriteLine("Entro al else ");
                        //Point punt = bacteria.Location;

                        //int x = punt.X;
                        //int y = punt.Y;

                        x += 10;

                        Point punto = new Point(x, y);
                        bacteria.Location = punto;
                        //this.panel.Refresh();
                    }
                    if (Direccion() > 500 && Direccion() < 750)
                    {
                        //Console.WriteLine("El valor de Direccion es " + Direccion());
                        //Console.WriteLine("Entro al else ");
                        // Point punt = bacteria.Location;

                        //int x = punt.X;
                        //int y = punt.Y;

                        x -= 10;

                        Point punto = new Point(x, y);
                        bacteria.Location = punto;
                        //this.panel.Refresh();
                    }

                    if (Direccion() > 750 && Direccion() < 1000)
                    {
                        //Console.WriteLine("El valor de Direccion es " + Direccion());
                        //Console.WriteLine("Entro al else ");
                        //Point punt = bacteria.Location;

                        //int x = punt.X;
                        //int y = punt.Y;

                        y -= 10;

                        Point punto = new Point(x, y);
                        bacteria.Location = punto;
                        //this.panel.Refresh();
                    }
                    await Task.Delay(100);
                }

            }
        }

        public void Temperaturas(Bacteria bacteria)
        {
            if(bacteria.nombre== "PicBox_Bacteria1")
            {
                bacteria.bacteria.Visible = false;
            }
            if(bacteria.nombre == "PicBox_Bacteria2")
            {
                bacteria.bacteria.Visible = false;
            }
        }

    }
}
