using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {


//Muestra el cuadro de diálogo Abrir archivo. Si el usuario hace clic en Aceptar, carga la imagen que eligió el usuario.

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
                 
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Borrar imagen
            pictureBox1.Image = null;

        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Muestra el cuadro de diálogo de color. Si el usuario hace clic en Aceptar, cambie el
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Cierra el formulario
            this.Close();
        }

            private void Stretch_CheckedChanged(object sender, EventArgs e)
        {
            // Si el usuario selecciona la casilla de verificación
            // Estirar, cambie la propiedad SizeMode del PictureBox a "Estirar".
            // Si el usuario borra la casilla de verificación, cámbiela a "Normal".
            if (Stretch.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

        }


    }
}
