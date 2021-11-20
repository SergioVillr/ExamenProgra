using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenProgra
{
    class Bacteria
    {
        private string nombre;
        private string especie;
        private int x, y;
        private PictureBox bacteria;

        Panel panel;


        public Bacteria(string nombre, string especie, int x, int y, Panel panel)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.x = x;
            this.y = y;

            bacteria = new PictureBox();
            this.panel = panel;

            this.panel.Controls.Add(bacteria);
        }

    }
}
