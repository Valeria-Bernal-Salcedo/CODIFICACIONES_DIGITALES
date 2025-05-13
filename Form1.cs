using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PRACTICA_CODIFICACIONES_DIGITALES
{
    public partial class Form1 : Form
    {
        string bits;

        public Form1()
        {
            InitializeComponent();

        }

        private void GRAFICAR_Click(object sender, EventArgs e)
        {
            bits = signal.Text;

            if(!bits.All(c => c == '0' || c == '1')){
                MessageBox.Show("Solo se permiten 0 y 1.");
                return;
            }

            pbNRZL.Paint += DrawNRZL;
            pbNRZL.Refresh();

            pbBipAMI.Paint += DrawBipAMI;
            pbBipAMI.Refresh();

            pbNRZI.Paint += DrawNRZI;
            pbNRZI .Refresh();

            pbPESUDO.Paint += DrawPESUDO;
            pbPESUDO.Refresh();

        }

        private void DrawPESUDO(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // 'Lienzo' para dibujar
            Pen pen = new Pen(Color.Blue, 2); // 'Lapiz' azul para la señal
            Pen gridPen = new Pen(Color.LightGray, 1); // 'Lapiz' gris para la cuadricula
            Font font = new Font("Arial", 10); // Fuente

            // Coordenadas base
            int xStart = 50; // Donde empieza el dibujo en X
            int yOneNeg = 250; // Coordenada vertical para el nivel -1
            int yZero = 150; // Coordenada vertical para el nivel 0
            int yOne = 50; // Coordenada vertical para el nivel 1
            int bitWidth = 50; // Ancho que ocupa 1 bit

            // Etiquetas '0' y '1' y '-1' en el eje Y
            g.DrawString("1", font, Brushes.Black, 20, yOne - 10);
            g.DrawString("0", font, Brushes.Black, 20, yZero - 10);
            g.DrawString("-1", font, Brushes.Black, 20, yOneNeg - 10);

            // Dibujar líneas verticales de la cuadrícula (1 por cada bit)
            for (int i = 0; i <= bits.Length; i++)
            {
                int x1 = xStart + i * bitWidth;
                g.DrawLine(gridPen, x1, yOne, x1, yOneNeg);
            }

            // Dibujar líneas horizontales (nivel 1 y 0)
            g.DrawLine(gridPen, xStart, yOne, xStart + bits.Length * bitWidth, yOne);
            g.DrawLine(gridPen, xStart, yZero, xStart + bits.Length * bitWidth, yZero);
            g.DrawLine(gridPen, xStart, yOneNeg, xStart + bits.Length * bitWidth, yOneNeg);

            // Dibujar los bits
            bool previo = false;
            int x = xStart;
            int currentY = yZero;


            for (int i = 0; i < bits.Length; i++)
            {
                int nextY;

                if (bits[i] == '0')
                {
                    // Alternar entre +1 y -1
                    nextY = previo ? yOneNeg : yOne;
                    previo = !previo;
                }
                else
                {
                    // '1' se representa con nivel 0
                    nextY = yZero;
                }

                // Dibujar bit debajo
                g.DrawString(bits[i].ToString(), font, Brushes.Black, x + 15, yOneNeg + 10);

                // Dibujar línea vertical si hay cambio
                if (i > 0 && nextY != currentY)
                {
                    g.DrawLine(pen, x, currentY, x, nextY);
                }

                // Línea horizontal del bit
                g.DrawLine(pen, x, nextY, x + bitWidth, nextY);

                // Avanzar
                x += bitWidth;
                currentY = nextY;

            }

            // Dibujar flecha final
            g.DrawLine(Pens.Blue, x, currentY, x + 10, currentY);
            g.DrawLine(Pens.Blue, x + 5, currentY - 5, x + 10, currentY);
            g.DrawLine(Pens.Blue, x + 5, currentY + 5, x + 10, currentY);
        }

        private void DrawNRZI(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // 'Lienzo' para dibujar
            Pen pen = new Pen(Color.Blue, 2); // 'Lapiz' azul para la señal
            Pen gridPen = new Pen(Color.LightGray, 1); // 'Lapiz' gris para la cuadricula
            Font font = new Font("Arial", 10); // Fuente

            // Coordenadas base
            int xStart = 50; // Donde empieza el dibujo en X
            int yZero = 150; // Coordenada vertical para el nivel 0
            int yOne = 50; // Coordenada vertical para el nivel 1
            int bitWidth = 50; // Ancho que ocupa 1 bit

            // Etiquetas '0' y '1' en el eje Y
            g.DrawString("1", font, Brushes.Black, 20, yOne - 10);
            g.DrawString("0", font, Brushes.Black, 20, yZero - 10);

            // Dibujar líneas verticales de la cuadrícula (1 por cada bit)
            for (int i = 0; i <= bits.Length; i++)
            {
                int x1 = xStart + i * bitWidth;
                g.DrawLine(gridPen, x1, yOne, x1, yZero);
            }

            // Dibujar líneas horizontales (nivel 1 y 0)
            g.DrawLine(gridPen, xStart, yOne, xStart + bits.Length * bitWidth, yOne);
            g.DrawLine(gridPen, xStart, yZero, xStart + bits.Length * bitWidth, yZero);

            // Dibujar los bits
            int currentY = yZero; // Nivel inicial
            int x = xStart;

            for (int i = 0; i < bits.Length; i++)
            {
                char bit = bits[i];

                // Dibujar bit encima
                g.DrawString(bits[i].ToString(), font, Brushes.Black, x + 15, yZero + 10);

                // Si hay cambio de nivel, dibujar línea vertical
                if (bit == '1')
                {
                    int newY = currentY == yZero ? yOne : yZero;
                    g.DrawLine(pen, x, currentY, x, newY);
                    currentY = newY;
                }

                // Dibujar línea horizontal para el bit
                g.DrawLine(pen, x, currentY, x + bitWidth, currentY);
                x += bitWidth;

            }

            // Dibujar flecha final
            g.DrawLine(Pens.Blue, x, currentY, x + 10, currentY);
            g.DrawLine(Pens.Blue, x + 5, currentY - 5, x + 10, currentY);
            g.DrawLine(Pens.Blue, x + 5, currentY + 5, x + 10, currentY);
        }

        private void DrawNRZL(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // 'Lienzo' para dibujar
            Pen pen = new Pen(Color.Blue, 2); // 'Lapiz' azul para la señal
            Pen gridPen = new Pen(Color.LightGray, 1); // 'Lapiz' gris para la cuadricula
            Font font = new Font("Arial", 10); // Fuente

            // Coordenadas base
            int xStart = 50; // Donde empieza el dibujo en X
            int yZero = 150; // Coordenada vertical para el nivel 0
            int yOne = 50; // Coordenada vertical para el nivel 1
            int bitWidth = 50; // Ancho que ocupa 1 bit

            // Etiquetas '0' y '1' en el eje Y
            g.DrawString("1", font, Brushes.Black, 20, yOne - 10);
            g.DrawString("0", font, Brushes.Black, 20, yZero - 10);

            // Dibujar líneas verticales de la cuadrícula (1 por cada bit)
            for (int i = 0; i <= bits.Length; i++)
            {
                int x1 = xStart + i * bitWidth;
                g.DrawLine(gridPen, x1, yOne, x1, yZero);
            }

            // Dibujar líneas horizontales (nivel 1 y 0)
            g.DrawLine(gridPen, xStart, yOne, xStart + bits.Length * bitWidth, yOne);
            g.DrawLine(gridPen, xStart, yZero, xStart + bits.Length * bitWidth, yZero);

            // Dibujar los bits
            int currentY = bits[0] == '1' ? yOne : yZero; // Nivel inicial
            int x = xStart;

            for (int i = 0; i < bits.Length; i++)
            {
                int nextY = bits[i] == '1' ? yOne : yZero;

                // Dibujar bit encima
                g.DrawString(bits[i].ToString(), font, Brushes.Black, x + 15, yZero + 10);

                // Si hay cambio de nivel, dibujar línea vertical
                if (i > 0 && nextY != currentY)
                {
                    g.DrawLine(pen, x, currentY, x, nextY);
                }

                // Dibujar línea horizontal para el bit
                g.DrawLine(pen, x, nextY, x + bitWidth, nextY);
                x += bitWidth;
                currentY = nextY;
            }

            // Dibujar flecha final
            g.DrawLine(Pens.Blue, x, currentY, x + 10, currentY);
            g.DrawLine(Pens.Blue, x + 5, currentY - 5, x + 10, currentY);
            g.DrawLine(Pens.Blue, x + 5, currentY + 5, x + 10, currentY);
        }

        private void DrawBipAMI(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // 'Lienzo' para dibujar
            Pen pen = new Pen(Color.Blue, 2); // 'Lapiz' azul para la señal
            Pen gridPen = new Pen(Color.LightGray, 1); // 'Lapiz' gris para la cuadricula
            Font font = new Font("Arial", 10); // Fuente

            // Coordenadas base
            int xStart = 50; // Donde empieza el dibujo en X
            int yOneNeg = 250; // Coordenada vertical para el nivel -1
            int yZero = 150; // Coordenada vertical para el nivel 0
            int yOne = 50; // Coordenada vertical para el nivel 1
            int bitWidth = 50; // Ancho que ocupa 1 bit

            // Etiquetas '0' y '1' y '-1' en el eje Y
            g.DrawString("1", font, Brushes.Black, 20, yOne - 10);
            g.DrawString("0", font, Brushes.Black, 20, yZero - 10);
            g.DrawString("-1", font, Brushes.Black, 20, yOneNeg - 10);

            // Dibujar líneas verticales de la cuadrícula (1 por cada bit)
            for (int i = 0; i <= bits.Length; i++)
            {
                int x1 = xStart + i * bitWidth;
                g.DrawLine(gridPen, x1, yOne, x1, yOneNeg);
            }

            // Dibujar líneas horizontales (nivel 1 y 0)
            g.DrawLine(gridPen, xStart, yOne, xStart + bits.Length * bitWidth, yOne);
            g.DrawLine(gridPen, xStart, yZero, xStart + bits.Length * bitWidth, yZero);
            g.DrawLine(gridPen, xStart, yOneNeg, xStart + bits.Length * bitWidth, yOneNeg);

            // Dibujar los bits
            int currentY = bits[0] == '1' ? yOne : yZero; // Nivel inicial
            int x = xStart;  
            int prev1 = yOneNeg;
            for (int i = 0; i < bits.Length; i++)
            {
                int nextY = bits[i] == '1' ? yOne : yZero;

                if(nextY == yOne)
                {
                    if(prev1 == yOne)
                    {
                        nextY = yOneNeg;
                    }
                }
                // Dibujar bit encima
                g.DrawString(bits[i].ToString(), font, Brushes.Black, x + 15, yOneNeg + 10);

                // Si hay cambio de nivel, dibujar línea vertical
                if (i > 0 && nextY != currentY)
                {
                    g.DrawLine(pen, x, currentY, x, nextY);
                }

                // Dibujar línea horizontal para el bit
                g.DrawLine(pen, x, nextY, x + bitWidth, nextY);
                x += bitWidth;
                currentY = nextY;
                if(currentY == yOne || currentY==yOneNeg)
                {
                    prev1 = currentY;
                }
                
            }

            // Dibujar flecha final
            g.DrawLine(Pens.Blue, x, currentY, x + 10, currentY);
            g.DrawLine(Pens.Blue, x + 5, currentY - 5, x + 10, currentY);
            g.DrawLine(Pens.Blue, x + 5, currentY + 5, x + 10, currentY);
        }
    }
}
