using System;
using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bits
{
    public partial class Main : Form
    {
        private Series datos=new Series();
        private string cadenaBits;
        private char[] bits;
        public Main()
        {
            InitializeComponent();
            datos.ChartType = SeriesChartType.StepLine;
        }

        private void LB_Opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadenaBits = TB_Bits.Text;
            bits = new Char[cadenaBits.Length];
            bits = cadenaBits.ToCharArray();
            datos.Points.Clear();
            switch (LB_Opciones.SelectedIndex)
            {
                case 0:
                    nzrl();
                    break;
                case 1:
                    nrzi();
                    break;
                case 2:
                    bAmi();
                    break;
                case 3:
                    pseudo();
                    break;
                case 4:
                    manchester();
                    break;
                case 5:
                    diferencial();
                    break;
                case 6:
                    bzs();
                    break;
                case 7:
                    hdb();
                    break;
            }
            CH_Grafico.Series.Add("Bits");
            CH_Grafico.Series[0].BorderWidth=3;
            CH_Grafico.Series[0]=datos;
            CH_Grafico.Series[0].XValueType = ChartValueType.Double;
            CH_Grafico.Series[0].XValueMember = "puntos";
            CH_Grafico.ChartAreas[0].AxisX.TextOrientation = TextOrientation.Rotated90;
        }

        private void hdb()
        {
            throw new NotImplementedException();
        }

        private void bzs()
        {
            throw new NotImplementedException();
        }

        private void diferencial()
        {//siempre mitad del inter 0=Trans inicio del inter- 1 no trans al inicio 
            
            int aux = 1;
            int aux2 = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '0')
                {
                    if (aux == 0)
                    {
                        aux = 1;
                        datos.Points.AddXY(i, aux);

                    }
                    else
                    {
                        aux = 0;
                        datos.Points.AddXY(i, aux);
                    }
                    if (aux2 == 0)
                        aux2 = 1;
                    else
                        aux2 = 0;
                }
                else
                {
                    if (aux2 == 0)
                        aux2 = 1;
                    else
                        aux2 = 0;
                }

                datos.Points.AddXY(i + 0.5, aux2);
            }

            

        }

        private void manchester()
        {//Medio intervalo 0 trancision alto bajo- 1 bajo alto 
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '0')
                {
                    datos.Points.AddXY(i, 1);
                    datos.Points.AddXY(i + 0.5, 0);
                }
                else
                {
                    datos.Points.AddXY(i, 0);
                    datos.Points.AddXY(i + 0.5, 1);
                }
            }
            
        }

        private void pseudo()
        {//alcontrario bipolar 
            int aux = -1;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] != '1')
                {
                    aux *= -1;
                    datos.Points.AddXY(i, aux);
                }
                else
                    datos.Points.AddXY(i, 0);
            }
                
        }

        private void bAmi()
        {//0 no señal- 1 Nivel + ó - alternante
            int aux=-1;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i]!='0'){
                    aux *= -1;
                    datos.Points.AddXY(i, aux);
                }
                else
                    datos.Points.AddXY(i, 0);
            }           
        }

        private void nrzi()
        {//0 no trancisión inicio de intervalo- 1 Transicion principio de intervalo
            int aux = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '1')
                {
                    if (aux == 0)
                        aux = 1;
                    else
                        aux = 0;
                }
                datos.Points.AddXY(i, aux);
            }
        }

        private void nzrl()
        {//0 Nivel alto 1 Nivel Bajo
            for(int i=0; i<bits.Length; i++){
                if (bits[i] == '0')
                {
                    datos.Points.AddXY(i, 1);
                }
                else
                {
                    datos.Points.AddXY(i, 0);
                }
            }
        }
    }
}
