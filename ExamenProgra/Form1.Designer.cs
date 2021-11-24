
namespace ExamenProgra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture_Co2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_bacteria1 = new System.Windows.Forms.Button();
            this.btn_bacteria2 = new System.Windows.Forms.Button();
            this.btn_bacteria3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_temp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mas = new System.Windows.Forms.Button();
            this.btn_menos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_CO2 = new System.Windows.Forms.Label();
            this.btn_AgregarCo2 = new System.Windows.Forms.Button();
            this.btn_QuitarCo2 = new System.Windows.Forms.Button();
            this.PicBox_Bacteria1 = new System.Windows.Forms.PictureBox();
            this.PicBox_Bacteria2 = new System.Windows.Forms.PictureBox();
            this.PicBox_Bacteria3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Co2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Bacteria1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Bacteria2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Bacteria3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picture_Co2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 768);
            this.panel1.TabIndex = 4;
            // 
            // picture_Co2
            // 
            this.picture_Co2.ErrorImage = null;
            this.picture_Co2.Image = global::ExamenProgra.Properties.Resources.C2;
            this.picture_Co2.Location = new System.Drawing.Point(928, 633);
            this.picture_Co2.Name = "picture_Co2";
            this.picture_Co2.Size = new System.Drawing.Size(126, 128);
            this.picture_Co2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Co2.TabIndex = 1;
            this.picture_Co2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ExamenProgra.Properties.Resources.bacterium1;
            this.pictureBox1.Location = new System.Drawing.Point(193, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_bacteria1
            // 
            this.btn_bacteria1.Location = new System.Drawing.Point(1091, 738);
            this.btn_bacteria1.Name = "btn_bacteria1";
            this.btn_bacteria1.Size = new System.Drawing.Size(75, 23);
            this.btn_bacteria1.TabIndex = 5;
            this.btn_bacteria1.Text = "Psicrofilas";
            this.btn_bacteria1.UseVisualStyleBackColor = true;
            // 
            // btn_bacteria2
            // 
            this.btn_bacteria2.Location = new System.Drawing.Point(1218, 738);
            this.btn_bacteria2.Name = "btn_bacteria2";
            this.btn_bacteria2.Size = new System.Drawing.Size(75, 23);
            this.btn_bacteria2.TabIndex = 6;
            this.btn_bacteria2.Text = "Mesofilas";
            this.btn_bacteria2.UseVisualStyleBackColor = true;
            // 
            // btn_bacteria3
            // 
            this.btn_bacteria3.Location = new System.Drawing.Point(1360, 738);
            this.btn_bacteria3.Name = "btn_bacteria3";
            this.btn_bacteria3.Size = new System.Drawing.Size(75, 23);
            this.btn_bacteria3.TabIndex = 7;
            this.btn_bacteria3.Text = "Termofilas";
            this.btn_bacteria3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb_temp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_mas);
            this.panel2.Controls.Add(this.btn_menos);
            this.panel2.Location = new System.Drawing.Point(1068, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 141);
            this.panel2.TabIndex = 8;
            // 
            // lb_temp
            // 
            this.lb_temp.AutoSize = true;
            this.lb_temp.Location = new System.Drawing.Point(171, 50);
            this.lb_temp.Name = "lb_temp";
            this.lb_temp.Size = new System.Drawing.Size(19, 13);
            this.lb_temp.TabIndex = 3;
            this.lb_temp.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperatura";
            // 
            // btn_mas
            // 
            this.btn_mas.Location = new System.Drawing.Point(219, 95);
            this.btn_mas.Name = "btn_mas";
            this.btn_mas.Size = new System.Drawing.Size(75, 23);
            this.btn_mas.TabIndex = 1;
            this.btn_mas.Text = "+";
            this.btn_mas.UseVisualStyleBackColor = true;
            this.btn_mas.Click += new System.EventHandler(this.btn_mas_Click);
            // 
            // btn_menos
            // 
            this.btn_menos.Location = new System.Drawing.Point(89, 95);
            this.btn_menos.Name = "btn_menos";
            this.btn_menos.Size = new System.Drawing.Size(75, 23);
            this.btn_menos.TabIndex = 0;
            this.btn_menos.Text = "-";
            this.btn_menos.UseVisualStyleBackColor = true;
            this.btn_menos.Click += new System.EventHandler(this.btn_menos_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lb_CO2);
            this.panel3.Controls.Add(this.btn_AgregarCo2);
            this.panel3.Controls.Add(this.btn_QuitarCo2);
            this.panel3.Location = new System.Drawing.Point(1069, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 141);
            this.panel3.TabIndex = 9;
            // 
            // lb_CO2
            // 
            this.lb_CO2.AutoSize = true;
            this.lb_CO2.Location = new System.Drawing.Point(162, 17);
            this.lb_CO2.Name = "lb_CO2";
            this.lb_CO2.Size = new System.Drawing.Size(28, 13);
            this.lb_CO2.TabIndex = 2;
            this.lb_CO2.Text = "CO2";
            // 
            // btn_AgregarCo2
            // 
            this.btn_AgregarCo2.Location = new System.Drawing.Point(219, 95);
            this.btn_AgregarCo2.Name = "btn_AgregarCo2";
            this.btn_AgregarCo2.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarCo2.TabIndex = 1;
            this.btn_AgregarCo2.Text = "Agregar";
            this.btn_AgregarCo2.UseVisualStyleBackColor = true;
            this.btn_AgregarCo2.Click += new System.EventHandler(this.btn_AgregarCo2_Click);
            // 
            // btn_QuitarCo2
            // 
            this.btn_QuitarCo2.Location = new System.Drawing.Point(89, 95);
            this.btn_QuitarCo2.Name = "btn_QuitarCo2";
            this.btn_QuitarCo2.Size = new System.Drawing.Size(75, 23);
            this.btn_QuitarCo2.TabIndex = 0;
            this.btn_QuitarCo2.Text = "Quitar";
            this.btn_QuitarCo2.UseVisualStyleBackColor = true;
            this.btn_QuitarCo2.Click += new System.EventHandler(this.btn_QuitarCo2_Click);
            // 
            // PicBox_Bacteria1
            // 
            this.PicBox_Bacteria1.Image = global::ExamenProgra.Properties.Resources.bacterium1;
            this.PicBox_Bacteria1.Location = new System.Drawing.Point(1068, 642);
            this.PicBox_Bacteria1.Name = "PicBox_Bacteria1";
            this.PicBox_Bacteria1.Size = new System.Drawing.Size(118, 90);
            this.PicBox_Bacteria1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_Bacteria1.TabIndex = 1;
            this.PicBox_Bacteria1.TabStop = false;
            // 
            // PicBox_Bacteria2
            // 
            this.PicBox_Bacteria2.Image = global::ExamenProgra.Properties.Resources.bacterium3;
            this.PicBox_Bacteria2.Location = new System.Drawing.Point(1202, 642);
            this.PicBox_Bacteria2.Name = "PicBox_Bacteria2";
            this.PicBox_Bacteria2.Size = new System.Drawing.Size(103, 90);
            this.PicBox_Bacteria2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_Bacteria2.TabIndex = 3;
            this.PicBox_Bacteria2.TabStop = false;
            // 
            // PicBox_Bacteria3
            // 
            this.PicBox_Bacteria3.Image = global::ExamenProgra.Properties.Resources.bacterium2;
            this.PicBox_Bacteria3.Location = new System.Drawing.Point(1342, 642);
            this.PicBox_Bacteria3.Name = "PicBox_Bacteria3";
            this.PicBox_Bacteria3.Size = new System.Drawing.Size(103, 90);
            this.PicBox_Bacteria3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_Bacteria3.TabIndex = 2;
            this.PicBox_Bacteria3.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 768);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PicBox_Bacteria1);
            this.Controls.Add(this.btn_bacteria3);
            this.Controls.Add(this.btn_bacteria2);
            this.Controls.Add(this.btn_bacteria1);
            this.Controls.Add(this.PicBox_Bacteria2);
            this.Controls.Add(this.PicBox_Bacteria3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Co2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Bacteria1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Bacteria2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Bacteria3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PicBox_Bacteria1;
        private System.Windows.Forms.PictureBox PicBox_Bacteria3;
        private System.Windows.Forms.PictureBox PicBox_Bacteria2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_bacteria1;
        private System.Windows.Forms.Button btn_bacteria2;
        private System.Windows.Forms.Button btn_bacteria3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_temp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mas;
        private System.Windows.Forms.Button btn_menos;
        private System.Windows.Forms.PictureBox picture_Co2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_CO2;
        private System.Windows.Forms.Button btn_AgregarCo2;
        private System.Windows.Forms.Button btn_QuitarCo2;
    }
}

