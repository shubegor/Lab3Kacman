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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myChart = new Chart
            {
                //кладем его на форму и растягиваем на все окно.
                Parent = this,
                Dock = DockStyle.Fill
            };
            myChart.ChartAreas.Add(new ChartArea("Math functions"));

        }
        Chart myChart; 
        private void button1_Click(object sender, EventArgs e)
        {
            
           
            Random r = new Random();

            int ModelTime = 1000;
            int ochered = 0;

            int min = 5;
            int max = 7;
            int nextZ = 0;
            int nextS = 0;
            bool SerIsFree = true;




            Series mySeriesOfPoint = new Series("Sinus")
            {
                ChartType = SeriesChartType.Line,
                ChartArea = "Math functions"
            };




            List<int> och = new List<int>();
        
            nextZ = r.Next(min, max);

            for (int i = 0; i < ModelTime; i++)
            {
                if (i == nextZ) //новая заявка
                {
                    nextZ = i + r.Next(min, max);
                    ochered++;
                }
                if (nextS == i)
                {
                    SerIsFree = true;
                }
                if (ochered > 0) //если есть очередь
                {
                    if (SerIsFree) //включаем свободный сервер
                    {
                        nextS = i + r.Next(min, max);
                        SerIsFree = false;
                        ochered--;
                    }

                }
                
                mySeriesOfPoint.Points.AddXY(i, ochered);
               
            }

            //Добавляем созданный набор точек в Chart
            if (myChart.Series.Count() > 0) myChart.Series.RemoveAt(0);
            myChart.Series.Add(mySeriesOfPoint);
            
        }
    }
}
