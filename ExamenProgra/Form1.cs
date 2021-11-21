﻿using System;
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
                Bacteria bacteria = new Bacteria(nombre, "especie", (e.X)-10, (e.Y)-10, panel1);
                Console.WriteLine(e.X);
                Console.WriteLine(e.Y);
            }
            else if (nombre == "PicBox_Bacteria2")
            {
                Bacteria bacteria = new Bacteria(nombre, "especie", (e.X)-10, (e.Y)-10, panel1);
            }
            else if (nombre == "PicBox_Bacteria3")
            {
                Bacteria bacteria = new Bacteria(nombre, "especie", (e.X)-10, (e.Y)-10, panel1);
            }
        }
    }
}
