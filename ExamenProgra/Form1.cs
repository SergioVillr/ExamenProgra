using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenProgra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panel1.AllowDrop = true;

            panel1.DragEnter += panel1_DragEnter;

            panel1.DragDrop += panel1_DragDrop;

            PicBox_Bacteria1.MouseDown += PicBox_MouseDown;
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

            if (nombre == "PicBox_Bacteria1")
            {
                int x = 0;
                int y = 0;

                x = e.X;
                y = e.Y;

                Bacteria bacteria = new Bacteria(nombre, "especie", x - 41/*(e.X)-20*/, /*(e.Y)-15*/y - 63, panel1);
                bacteria.dibujarImagen();
                Console.WriteLine(e.X);
                Console.WriteLine(e.Y);
            }
            else if (nombre == "PicBox_Bacteria2")
            {
                Bacteria bacteria = new Bacteria(nombre, "especie", (e.X)-20, (e.Y)-15, panel1);
                bacteria.dibujarImagen();
            }
            else if (nombre == "PicBox_Bacteria3")
            {
                Bacteria bacteria = new Bacteria(nombre, "especie", (e.X)-20, (e.Y)-15, panel1);
                bacteria.dibujarImagen();
            }
        }

        private void move_bacteria1_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            y = y + 5;

            Point punto = new Point(x, y);
            pictureBox1.Location = punto;
        }
    }
}
