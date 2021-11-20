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
            panel2.AllowDrop = true;
            pictureBox2.AllowDrop = true;

           
            panel2.DragEnter += panel_DragEnter;
            pictureBox2.DragEnter += panel_DragEnter;

            pictureBox2.DragDrop += panel_DragDrop;
            panel2.DragDrop += panel_DragDrop;
            

            PicBox_Bacteria1.MouseDown += button1_MouseDown;
        }

        private void PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            //PicBox_Bacteria1.DoDragDrop(PicBox_Bacteria1.Image, DragDropEffects.Copy);
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string nombre = e.Data.GetData(DataFormats.Text).ToString();

            if (nombre == "PicBox_Bacteria1")
            {
                Bacteria bacteria = new Bacteria(nombre, "especie", e.X, e.Y, panel1);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            y = y + 5;

            Point punto = new Point(x, y);
            pictureBox1.Location = punto;*/
        }

        private void Mover ()
        {

        }

        void button1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
            panel2.Show();
        }

        void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        void panel_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = sender as PictureBox; // will give you null if it can't be cast to PictureBox
            if (pb != null)
            {
                pb.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            }
        }
    }
}
