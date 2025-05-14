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

            if (!bits.All(c => c == '0' || c == '1'))
            {
                MessageBox.Show("Solo se permiten 0 y 1.");
                return;
            }

            pbNRZL.Paint += DrawNRZL;
            pbNRZL.Refresh();

            pbBipAMI.Paint += DrawBipAMI;
            pbBipAMI.Refresh();

            pbNRZI.Paint += DrawNRZI;
            pbNRZI.Refresh();

            pbPESUDO.Paint += DrawPESUDO;
            pbPESUDO.Refresh();

            pbManchester.Paint += DrawBipManchester;
            pbManchester.Refresh();

            pbCodigoDif.Paint += DrawCodigoDif;
            pbCodigoDif.Refresh();

        }

        private void DrawPESUDO(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // 'Lienzo' para dibujar
            Pen pen = new Pen(Color.OliveDrab, 2); // 'Lapiz' azul para la señal
            Pen gridPen = new Pen(Color.LightGray, 1); // 'Lapiz' gris para la cuadricula
            Font font = new Font("Arial", 10); // Fuente

            // Coordenadas base
            int xStart = 50; // Donde empieza el dibujo en X
            int yOneNeg = 160; // Coordenada vertical para el nivel -1
            int yZero = 120; // Coordenada vertical para el nivel 0
            int yOne = 80; // Coordenada vertical para el nivel 1
            int bitWidth = 40; // Ancho que ocupa 1 bit

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
            int currentY = bits[0] == '1' ? yOne : yZero; // Nivel inicial


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
            g.DrawLine(pen, x, currentY, x + 10, currentY);
            g.DrawLine(pen, x + 5, currentY - 5, x + 10, currentY);
            g.DrawLine(pen, x + 5, currentY + 5, x + 10, currentY);
        }

        private void DrawNRZI(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // 'Lienzo' para dibujar
            Pen pen = new Pen(Color.SandyBrown, 2); // 'Lapiz' azul para la señal
            Pen gridPen = new Pen(Color.LightGray, 1); // 'Lapiz' gris para la cuadricula
            Font font = new Font("Arial", 10); // Fuente

            // Coordenadas base
            int xStart = 50; // Donde empieza el dibujo en X
            int yZero = 120; // Coordenada vertical para el nivel 0
            int yOne = 80; // Coordenada vertical para el nivel 1
            int bitWidth = 40; // Ancho que ocupa 1 bit

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
            g.DrawLine(pen, x, currentY, x + 10, currentY);
            g.DrawLine(pen, x + 5, currentY - 5, x + 10, currentY);
            g.DrawLine(pen, x + 5, currentY + 5, x + 10, currentY);
        }

        private void DrawNRZL(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // 'Lienzo' para dibujar
            Pen pen = new Pen(Color.Tomato, 2); // 'Lapiz' azul para la señal
            Pen gridPen = new Pen(Color.LightGray, 1); // 'Lapiz' gris para la cuadricula
            Font font = new Font("Arial", 10); // Fuente

            // Coordenadas base
            int xStart = 50; // Donde empieza el dibujo en X
            int yZero = 120; // Coordenada vertical para el nivel 0
            int yOne = 80; // Coordenada vertical para el nivel 1
            int bitWidth = 40; // Ancho que ocupa 1 bit

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
            g.DrawLine(pen, x, currentY, x + 10, currentY);
            g.DrawLine(pen, x + 5, currentY - 5, x + 10, currentY);
            g.DrawLine(pen, x + 5, currentY + 5, x + 10, currentY);
        }

        private void DrawBipAMI(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // 'Lienzo' para dibujar
            Pen pen = new Pen(Color.Goldenrod, 2); // 'Lapiz' azul para la señal
            Pen gridPen = new Pen(Color.LightGray, 1); // 'Lapiz' gris para la cuadricula
            Font font = new Font("Arial", 10); // Fuente

            // Coordenadas base
            int xStart = 50; // Donde empieza el dibujo en X
            int yOneNeg = 160; // Coordenada vertical para el nivel -1
            int yZero = 120; // Coordenada vertical para el nivel 0
            int yOne = 80; // Coordenada vertical para el nivel 1
            int bitWidth = 40; // Ancho que ocupa 1 bit

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

            // Dibujar líneas horizontales (nivel 1,0,-1)
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

                if (nextY == yOne)
                {
                    if (prev1 == yOne)
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
                if (currentY == yOne || currentY == yOneNeg)
                {
                    prev1 = currentY;
                }

            }

            // Dibujar flecha final
            g.DrawLine(pen, x, currentY, x + 10, currentY);
            g.DrawLine(pen, x + 5, currentY - 5, x + 10, currentY);
            g.DrawLine(pen, x + 5, currentY + 5, x + 10, currentY);
        }

        private void DrawBipManchester(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // 'Lienzo' para dibujar
            Pen pen = new Pen(Color.LightSeaGreen, 2); // 'Lapiz' azul para la señal
            Pen gridPen = new Pen(Color.LightGray, 1); // 'Lapiz' gris para la cuadricula
            Font font = new Font("Arial", 10); // Fuente

            // Coordenadas base
            int xStart = 50; // Donde empieza el dibujo en X
            int yZero = 120; // Coordenada vertical para el nivel 0
            int yOne = 80; // Coordenada vertical para el nivel 1
            int bitWidth = 40; // Ancho que ocupa 1 bit

            // Etiquetas '0' y '1' en el eje Y
            g.DrawString("1", font, Brushes.Black, 20, yOne - 10);
            g.DrawString("0", font, Brushes.Black, 20, yZero - 10);

            // Dibujar líneas verticales de la cuadrícula (1 por cada bit)
            for (int i = 0; i <= bits.Length; i++)
            {
                int x1 = xStart + i * bitWidth;
                g.DrawLine(gridPen, x1, yOne, x1, yZero);
            }

            // Dibuja la cuadrícula horizontal (niveles 1 y 0)
            g.DrawLine(gridPen, xStart, yOne, xStart + bits.Length * bitWidth, yOne);
            g.DrawLine(gridPen, xStart, yZero, xStart + bits.Length * bitWidth, yZero);



            int x = xStart;         // Coordenada X inicial para el primer bit
            int currentY = bits[0] == '1' ? yOne : yZero; // Nivel inicial

            // Recorremos cada bit de la cadena
            for (int i = 0; i < bits.Length; i++)
            {
                char bit = bits[i]; // Leemos el bit (por ejemplo, '1' o '0')
                int midX = x + bitWidth / 2; // Punto medio del bit

                int firstY, secondY;

                // Codificación Manchester:
                // - El '1' es una transición de 0 a 1 (primero abajo, luego arriba)
                // - El '0' es una transición de 1 a 0 (primero arriba, luego abajo)
                if (bit == '1')
                {
                    firstY = yZero;    // Comienza abajo
                    secondY = yOne;    // Termina arriba
                }
                else
                {
                    firstY = yOne;     // Comienza arriba
                    secondY = yZero;   // Termina abajo
                }

                // Escribe el bit debajo de su lugar en el eje X
                g.DrawString(bit.ToString(), font, Brushes.Black, x + 15, yZero + 10);

                // Dibuja la primera mitad del bit
                if (i == 0)
                {
                    // Si es el primer bit, empieza directamente en el primer nivel
                    g.DrawLine(pen, x, firstY, midX, firstY); // Solo la línea horizontal si es el primero
                }
                else
                {
                    // Si no es el primero, dibuja una línea vertical desde el nivel anterior si cambia
                    g.DrawLine(pen, x, currentY, x, firstY);       // Línea vertical si hay cambio de nivel
                    g.DrawLine(pen, x, firstY, midX, firstY);      // Línea horizontal de la primera mitad
                }

                // Transición a mitad del bit (de 0 a 1 o de 1 a 0) // Linea vertical
                g.DrawLine(pen, midX, firstY, midX, secondY);

                // Segunda mitad del bit (horizontal final)
                g.DrawLine(pen, midX, secondY, x + bitWidth, secondY);

                // Guardamos el nivel actual para el siguiente bit
                currentY = secondY;
                x += bitWidth; // Avanzamos al siguiente bit
            }

            // Dibujamos una flecha al final indicando la dirección de la señal
            g.DrawLine(pen, x, currentY, x + 10, currentY);           // Línea recta
            g.DrawLine(pen, x + 5, currentY - 5, x + 10, currentY);   // Punta arriba
            g.DrawLine(pen, x + 5, currentY + 5, x + 10, currentY);   // Punta abajo
        }

        private void DrawCodigoDif(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // 'Lienzo' para dibujar
            Pen pen = new Pen(Color.SlateBlue, 2); // 'Lapiz' azul para la señal
            Pen gridPen = new Pen(Color.LightGray, 1); // 'Lapiz' gris para la cuadricula
            Font font = new Font("Arial", 10); // Fuente

            // Coordenadas base
            int xStart = 50; // Donde empieza el dibujo en X
            int yZero = 120; // Coordenada vertical para el nivel 0
            int yOne = 80; // Coordenada vertical para el nivel 1
            int bitWidth = 40; // Ancho que ocupa 1 bit

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



            // Inicia la posición horizontal y el nivel actual de la señal
            int x = xStart;  // La posición inicial en X
            int currentLevel = 1;  // 1 significa alto (yOne), 0 significa bajo (yZero)
            int yActual = bits[0] == '1' ? yOne : yZero; // Nivel inicial

            // Recorremos cada bit en el array 'bits'
            for (int i = 0; i < bits.Length; i++)
            {
                char bit = bits[i];  // Tomamos el bit actual
                int midX = x + bitWidth / 2;  // Calculamos la posición media del bit

                // Verificamos si hay transición al inicio del bit (solo ocurre si el bit es '0')
                bool transitionStart = bit == '0';

                if (transitionStart)
                {
                    // Si es '0', cambiamos el nivel de la señal (hay una transición)
                    currentLevel = 1 - currentLevel;
                    int yNew = (currentLevel == 1) ? yOne : yZero;
                    g.DrawLine(pen, x, yActual, x, yNew);  // Dibujamos una transición vertical
                    yActual = yNew;  // Actualizamos el nivel vertical actual
                }

                // Dibujamos la primera mitad del bit (línea horizontal)
                g.DrawLine(pen, x, yActual, midX, yActual);

                // Siempre hay transición en la mitad del bit
                currentLevel = 1 - currentLevel;  // Cambiamos el nivel de la señal
                int yNewMid = (currentLevel == 1) ? yOne : yZero;  // Establecemos el nuevo nivel en la mitad
                g.DrawLine(pen, midX, yActual, midX, yNewMid);  // Dibujamos la transición vertical en la mitad
                g.DrawLine(pen, midX, yNewMid, x + bitWidth, yNewMid);  // Dibujamos la segunda mitad del bit

                // Actualizamos la posición vertical de la señal
                yActual = yNewMid;

                // Dibujamos el valor del bit en la parte inferior
                g.DrawString(bit.ToString(), font, Brushes.Black, x + 15, yZero + 10);

                // Avanzamos la posición horizontal para el siguiente bit
                x += bitWidth;               
            }

            // Dibujamos una flecha al final indicando la dirección de la señal
            g.DrawLine(pen, x, yActual, x + 10, yActual);           // Línea recta
            g.DrawLine(pen, x + 5, yActual - 5, x + 10, yActual);   // Punta arriba
            g.DrawLine(pen, x + 5, yActual + 5, x + 10, yActual);   // Punta abajo
        }
    }
}
