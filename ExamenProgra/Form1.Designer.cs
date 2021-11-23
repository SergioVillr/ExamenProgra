
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
            this.components = new System.ComponentModel.Container();
            this.PicBox_Bacteria2 = new System.Windows.Forms.PictureBox();
            this.PicBox_Bacteria3 = new System.Windows.Forms.PictureBox();
            this.PicBox_Bacteria1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_bacteria1 = new System.Windows.Forms.Button();
            this.btn_bacteria2 = new System.Windows.Forms.Button();
            this.btn_bacteria3 = new System.Windows.Forms.Button();
            this.move_bacteria1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Bacteria2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Bacteria3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Bacteria1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 768);
            this.panel1.TabIndex = 4;
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
            // move_bacteria1
            // 
            this.move_bacteria1.Enabled = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PicBox_Bacteria1);
            this.Controls.Add(this.btn_bacteria3);
            this.Controls.Add(this.btn_bacteria2);
            this.Controls.Add(this.btn_bacteria1);
            this.Controls.Add(this.PicBox_Bacteria2);
            this.Controls.Add(this.PicBox_Bacteria3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Bacteria2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Bacteria3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Bacteria1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Timer move_bacteria1;
    }
}

