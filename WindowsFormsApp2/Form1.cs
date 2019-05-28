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

           

            int ModelTime = 100000; //время моделирования
            int ochered = 0; //очередь

            double totalZ = 1; //всего заявок поступило

            double totalObsluzh1 = 0; //всего заявок обслужено сервером 1
            double totalObsluzh2 = 0; //всего заявок обслужено сервером 2
            double TotalLost = 0; //всего заявок потеряно

            double totalWorkTime1 = 0; //всего работал сервер 1
            double totalWorkTime2 = 0; //всего работал сервер 2
            double ProcS1 = 0; //процент загрузки сервера 1
            double ProcS2 = 0; //процент загрузки сервера 2

            //Настройки интервала заявок
            int minZ = int.Parse(MinZTextBox.Text);
            int maxZ = int.Parse(MaxZTextBox.Text);


            //Настройки интервала серверов
            int minS = int.Parse(MinSTextBox.Text);
            int maxS = int.Parse(MaxSTextBox.Text);



            int nextZ = 0;  //время прихода следующей заявки
            int nextS1 = 0; //время освобождения сервера 1
            int nextS2 = 0; //время освобождения сервера 2
            bool Ser1IsFree = true; //свободен ли сервер 1
            bool Ser2IsFree = true; //свободен ли сервер 2



            Series mySeriesOfPoint = new Series("Sinus") //точки графика
            {
                ChartType = SeriesChartType.Line,
                ChartArea = "Math functions"
            };
            
        
            nextZ = r.Next(minZ, maxZ); //время прихода первой заявки 

            for (int i = 0; i < ModelTime; i++) //движение времени
            {
                if (i == nextZ) //если пришла новая заявка
                {
                    nextZ = i + r.Next(minZ, maxZ); //время прихода следующей заявки 
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

            TotalLostTextBox.Text = "Потеряно: " + TotalLost;
            TotalZTextBox.Text = "Всего заявок: " + totalZ;
            Proc1TextBox.Text = "Загрузка сервера 1: " + ProcS1 + "%";
            Proc2TextBox.Text = "Загрузка сервера 2: " + ProcS2 + "%";
            OcheredTextBox.Text = "Очередь: " + ochered;

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
