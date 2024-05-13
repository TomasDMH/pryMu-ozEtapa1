using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Net;

namespace pryMuñozEtapa1
{
    public partial class Dibujo : Form
    {
        public Dibujo()
        {
            InitializeComponent();
        }

        private List<Point> trazo = new List<Point>();
        private bool isDrawing = false;
        private void pctFirma_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Bitmap bmp = new Bitmap(pctFirma.Width, pctFirma.Height))
                {
                    pctFirma.DrawToBitmap(bmp, new Rectangle(0, 0, pctFirma.Width, pctFirma.Height));
                    bmp.Save("C:\\Users\\Usuario\\source\\repos\\pryMuñozEtapa1\\pryMuñozEtapa1\\bin\\Debug\\FIRMAS\\Firma.jpg");
                    MessageBox.Show("Firma guardada");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Dibujo_Load(object sender, EventArgs e)
        {

        }

        private void pctFirma_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Black, 2);

            if (trazo.Count > 1)
            {
                g.DrawLines(pen, trazo.ToArray());
            }
        }

        private void pctFirma_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pctFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDrawing)
    {
                trazo.Add(e.Location);
                pctFirma.Invalidate();
            }
        }

        private void pctFirma_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void pctFirma_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            trazo.Clear();
            trazo.Add(e.Location);
        }
    }
}
