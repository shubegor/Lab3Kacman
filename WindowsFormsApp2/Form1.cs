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


            Random r = new Random(0);
           

            int ModelTime = 100000;
            int ochered = 0;

            double totalZ = 1;

            double totalObsluzh1 = 0;
            double totalObsluzh2 = 0;
            double TotalLost = 0;

            double totalWorkTime1 = 0;
            double totalWorkTime2 = 0;
            double ProcS1 = 0;
            double ProcS2 = 0;

            //Настройки интервала заявок
            int minZ = 5;
            int maxZ = 7;

            //Настройки интервала серверов
            int minS = 5;
            int maxS = 7;



            int nextZ = 0;
            int nextS1 = 0;
            int nextS2 = 0;
            bool Ser1IsFree = true;
            bool Ser2IsFree = true;



            Series mySeriesOfPoint = new Series("Sinus")
            {
                ChartType = SeriesChartType.Line,
                ChartArea = "Math functions"
            };




            List<int> och = new List<int>();
        
            nextZ = r.Next(minZ, maxZ);

            for (int i = 0; i < ModelTime; i++)
            {
                if (i == nextZ) //новая заявка
                {
                    nextZ = i + r.Next(minZ, maxZ);
                    totalZ++;
                    ochered++;
                }


                if (!Ser1IsFree) totalWorkTime1++;
                if (!Ser2IsFree) totalWorkTime2++;


                if (nextS1 == i) //свобода серверу 1
                {
                    totalObsluzh1++;
                    Ser1IsFree = true;
                }

                if (nextS2 == i) //свобода серверу 2
                {
                    totalObsluzh2++;
                    Ser2IsFree = true;
                }


                
                if (ochered > 0) //если есть очередь
                {

                    
                    if (Ser1IsFree) //включаем свободный сервер 1
                    {
                        nextS1 = i + r.Next(minS, maxS);
                        Ser1IsFree = false;
                        ochered--;
                    }
                    else
                    {
                        if (Ser2IsFree) //включаем свободный сервер 2
                        {
                            nextS2 = i + r.Next(minS, maxS);
                            Ser2IsFree = false;
                            ochered--;
                        }
                    }

                }
                
                mySeriesOfPoint.Points.AddXY(i, ochered);
               
            }

            //Добавляем созданный набор точек в Chart
            if (myChart.Series.Count() > 0) myChart.Series.RemoveAt(0);
            myChart.Series.Add(mySeriesOfPoint);


            ProcS1 = totalWorkTime1 / ModelTime * 100;
            ProcS2 = totalWorkTime2 / ModelTime * 100;
            TotalLost = totalZ - totalObsluzh1 - totalObsluzh2 - ochered;
        }

        
    }
}
