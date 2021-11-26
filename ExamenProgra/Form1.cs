using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ExamenProgra
{
    public partial class Form1 : Form
    {
        int contemp=25;
        int co2 = 1;
        int O2 = 1;
        Bacteria bacteria;

        public Form1()
        {
            InitializeComponent();

            panel1.AllowDrop = true;

            panel1.DragEnter += panel1_DragEnter;

            panel1.DragDrop += panel1_DragDrop;

            PicBox_Bacteria1.MouseDown += PicBox_MouseDown;
            PicBox_Bacteria2.MouseDown += PicBox_MouseDown;
            PicBox_Bacteria3.MouseDown += PicBox_MouseDown;
            
        }

        private void PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Name, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            { 
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {

            string nombre = e.Data.GetData(DataFormats.Text).ToString();
            int x = e.X;
            int y = e.Y;
            Moveee(nombre, x, y);
            //Thread myNewThread = new Thread(() => Moveee(nombre,x,y));
            //myNewThread.Start();

            //Task taskA =  Task.Run(() => Moveee(nombre,x,y));
            //taskA.Start();


            //Thread hilo = new Thread(Moveee);
            //hilo.Start(nombre);




            //if (nombre == "PicBox_Bacteria1")
            //{
            //    Console.WriteLine(e.X + " form");
            //    Console.WriteLine(e.Y + " form");
            //    int x = e.X;
            //    int y = e.Y;

            //    Bacteria bacteria = new Bacteria(nombre, "especie", x - 41/*(e.X)-20*/, /*(e.Y)-15*/y - 63, panel1);
            //    //bacteria.dibujarImagen();


            //    Thread hilo = new Thread(bacteria.Mover);
            //    hilo.Start();


            //}
            //else if (nombre == "PicBox_Bacteria2")
            //{
            //    int x = e.X;
            //    int y = e.Y;

            //    Bacteria bacteria = new Bacteria(nombre, "especie", x - 41/*(e.X)-20*/, /*(e.Y)-15*/y - 63, panel1);
            //   // bacteria.dibujarImagen();

            //}
            //else if (nombre == "PicBox_Bacteria3")
            //{
            //    Bacteria bacteria = new Bacteria(nombre, "especie", (e.X)-20, (e.Y)-15, panel1);
            //    //bacteria.dibujarImagen();
            //}
        }




        private void Moveee(string nombre, int x, int y)
        {

            //if (InvokeRequired)
            //{
                //Invoke(new MethodInvoker(delegate
                //{
                    if (nombre == "PicBox_Bacteria1")
                    {
                        Console.WriteLine(x + " form");
                        Console.WriteLine(y + " form");

                        bacteria = new Bacteria(nombre, "especie", x - 41/*(e.X)-20*/, /*(e.Y)-15*/y - 63, panel1);
                        //bacteria.dibujarImagen();


                        //Thread hilo = new Thread(bacteria.Mover);
                        //hilo.Start();


                    }
                    else if (nombre == "PicBox_Bacteria2")
                    {

                        bacteria = new Bacteria(nombre, "especie", x - 41/*(e.X)-20*/, /*(e.Y)-15*/y - 63, panel1);
                        // bacteria.dibujarImagen();

                    }
                    else if (nombre == "PicBox_Bacteria3")
                    {
                        bacteria = new Bacteria(nombre, "especie", (x) - 20, (y) - 15, panel1);
                        //bacteria.dibujarImagen();
                    }
            //}));
            //}
            //else
            //{
            //    if (nombre == "PicBox_Bacteria1")
            //    {
            //        Console.WriteLine(x + " form");
            //        Console.WriteLine(y + " form");

            //        Bacteria bacteria = new Bacteria(nombre, "especie", x - 41/*(e.X)-20*/, /*(e.Y)-15*/y - 63, panel1);
            //        bacteria.dibujarImagen();


            //        Thread hilo = new Thread(bacteria.Mover);
            //        hilo.Start();


            //    }
            //    else if (nombre == "PicBox_Bacteria2")
            //    {

            //        Bacteria bacteria = new Bacteria(nombre, "especie", x - 41/*(e.X)-20*/, /*(e.Y)-15*/y - 63, panel1);
            //        bacteria.dibujarImagen();

            //    }
            //    else if (nombre == "PicBox_Bacteria3")
            //    {
            //        Bacteria bacteria = new Bacteria(nombre, "especie", (x) - 20, (y) - 15, panel1);
            //        bacteria.dibujarImagen();
            //    }
            //}
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {

            contemp -= 1;
            lb_temp.Text = contemp.ToString();

            foreach (Control cComprobar in panel1.Controls)
            {
                if (cComprobar is PictureBox)
                {
                    if(cComprobar.Name == "Psicrofilas" && contemp >= 40)
                    {
                        panel1.Controls.Remove(cComprobar);
                    }
                    else if (cComprobar.Name == "Mesofilas" && contemp <= 9)
                    {
                        panel1.Controls.Remove(cComprobar);
                    }
                    else if (cComprobar.Name == "Termofilas" && contemp <= 20)
                    {
                        panel1.Controls.Remove(cComprobar);
                    }
                }
            }

        }

        private void btn_mas_Click(object sender, EventArgs e)
        {

            contemp += 1;
            lb_temp.Text = contemp.ToString();

            foreach (Control cComprobar in panel1.Controls)
            {
                if (cComprobar is PictureBox)
                {
                    if (cComprobar.Name == "Psicrofilas" && contemp >= 40)
                    {
                        panel1.Controls.Remove(cComprobar);
                    }
                    else if (cComprobar.Name == "Mesofilas" && contemp <= 9)
                    {
                        panel1.Controls.Remove(cComprobar);
                    }
                    else if (cComprobar.Name == "Termofilas" && contemp <= 20)
                    {
                        panel1.Controls.Remove(cComprobar);
                    }
                }
            }

        }

        private void btn_QuitarCo2_Click(object sender, EventArgs e)
        {
            co2 = 0;
            picture_Co2.Visible = false;
        }

        private void btn_AgregarCo2_Click(object sender, EventArgs e)
        {
            co2 = 1;
            picture_Co2.Visible = true;
        }

        private void btn_quitarO2_Click(object sender, EventArgs e)
        {
            O2 = 0;
            picture_O2.Visible = false;
        }

        private void btn_agregarO2_Click(object sender, EventArgs e)
        {
            O2 = 1;
            picture_O2.Visible = true;
        }
    }
}
