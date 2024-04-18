using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PracticeHospitalKov
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        double Intensivnost, VerOtkaz, IntensivnostObsluz,IntensivnostPotoka, SrednTimeOzid, SrednZayavok, Count=0;

        private void BtnAddRow_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            string filePath = (Application.StartupPath + "\\Statistic.xlsx");

            FileInfo file = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                worksheet.Cells[1, 1].Value = "Описание показателей";
                worksheet.Cells[1, 2].Value = "Производственные данные";
                worksheet.Cells[2, 1].Value = "Пропускная способность:";
                worksheet.Cells[2, 2].Value = "20 чел/ч";
                worksheet.Cells[3, 1].Value = "Время обслуживания:";
                worksheet.Cells[3, 2].Value = "3 мин";
                worksheet.Cells[4, 1].Value = "Среднее число заявок в системе:";
                worksheet.Cells[4, 2].Value = LblNahodVSisteme.Text;
                worksheet.Cells[5, 1].Value = "Интенсивность потока:";
                worksheet.Cells[5, 2].Value = LblIntensivnost.Text;
                worksheet.Cells[6, 1].Value = "Интенсивность обслуживания:";
                worksheet.Cells[6, 2].Value = LblIntensObluz.Text;
                worksheet.Cells[7, 1].Value = "Среднее кол-во заявок в очереди:";
                worksheet.Cells[7, 2].Value = LblSrednDlinaOcheredi.Text;
                worksheet.Cells[8, 1].Value = "Среднее время нахождения в системе:";
                worksheet.Cells[8, 2].Value = LblSrednNahodVSist.Text;
                worksheet.Cells[9, 1].Value = "Данные актуальны на:";
                worksheet.Cells[9, 2].Value = DateTime.Now;
                worksheet.Cells[10, 1].Value = "Внимание!";
                if (IntensivnostPotoka >= 1)
                {
                    worksheet.Cells[10, 2].Value = "На текущий час врач перегружен";
                    worksheet.Cells[11, 2].Value = "Примите меры!";
                }
                else worksheet.Cells[10, 2].Value = "Все процессы работают нормально";



                // Центировать текст
                ExcelRange columnRange = worksheet.Cells[1, 1, worksheet.Dimension.Rows, 1];
                for (int i = 2; i <= columnRange.Rows; i++)
                    worksheet.Cells[i, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                ExcelRange tableRange = worksheet.Cells[1, 1, columnRange.Rows - 1, 2];

                // Установка стиля границ для таблицы
                tableRange.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                tableRange.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                tableRange.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                tableRange.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

                // Пример установки цвета границ
                tableRange.Style.Border.Top.Color.SetColor(Color.Black);
                tableRange.Style.Border.Left.Color.SetColor(Color.Black);
                tableRange.Style.Border.Right.Color.SetColor(Color.Black);
                tableRange.Style.Border.Bottom.Color.SetColor(Color.Black);


                worksheet.Column(1).AutoFit();
                worksheet.Column(2).AutoFit();

                package.Save();

                Process.Start(Application.StartupPath + "\\Statistic.xlsx");
            }
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label8, "λ - интенсивность входящего потока заявок\r\nμ - интенсивность обслуживания заявок\r\nρ - приведенная интенсивность потока\r\nLs - среднее число находящихся в системе заявок\r\nLq - среднее число заявок в очереди (средняя длина очереди)\r\nWs - среднее время пребывания заявки в системе\r\nWq - средняя продолжительность пребывания клиента (заявки) в очереди");
        }

        List<int> LstOldRows = new List<int>();

        int n = 1, t = 3;
        private void FormStatistics_Load(object sender, EventArgs e)
        {
            DateTime Dt = DateTime.Now;
            string Fdt = Dt.ToString("yyyy/MM/dd HH");

            SqlConnection Con = new SqlConnection(Form1.TxtCon);
            SqlCommand Cmd = new SqlCommand("select * from Request", Con);
            Con.Open();
            SqlDataReader Res = Cmd.ExecuteReader();
            while (Res.Read())
            {
                // Просчет интенсивности заявок за прошедший час и приведение их к формуле
                string DtFromBase = DateTime.Parse(Res["TimeRequest"].ToString()).ToString("yyyy/MM/dd HH");
                if (Fdt.Split(' ')[0] == DtFromBase.Split(' ')[0] && int.Parse(Fdt.Split(' ')[1]) == int.Parse(DtFromBase.Split(' ')[1]))
                    LstOldRows.Add(1);
            }
            Con.Close();

            SqlCommand Cmd1 = new SqlCommand("select * from Request where State='Новая'", Con);
            Con.Open();
            SqlDataReader Res1 = Cmd1.ExecuteReader();
            while (Res1.Read())
                Count++;
            Con.Close();

            // Для тестирование измени LstOldRows.Count на 20 и загрузи данные в Excel
            Intensivnost = Count;
            LblIntensivnost.Text = Intensivnost.ToString() + " чел/ч";

            // Забыл код для обработанных заявок

            IntensivnostObsluz = 60.0 / t;
            double IntensivnostObsluz2 = 1.0 / t;
            if(IntensivnostObsluz2.ToString().Length>5)
            LblIntensObluz.Text = IntensivnostObsluz2.ToString().Substring(0,5) + " чел/м";
            else LblIntensObluz.Text = IntensivnostObsluz2.ToString() + " чел/м";

            IntensivnostPotoka = Intensivnost / IntensivnostObsluz;

            // То же самое, что и коэфициент загрузки, если он >1, тогда система перегружена
            double SrednNahodVSisteme = IntensivnostPotoka / (1 - IntensivnostPotoka);
            if(SrednNahodVSisteme.ToString().Length>5)
                LblNahodVSisteme.Text = SrednNahodVSisteme.ToString().Substring(0,5);
            else
            LblNahodVSisteme.Text=SrednNahodVSisteme.ToString();

            // Вероятность того, что система пуста
            double P0 = 1 - Intensivnost / IntensivnostObsluz;

            // Среднее время пребывания заявки в системе
            double Ws = (SrednNahodVSisteme / Intensivnost)*60;
            if(Ws.ToString().Length>5)
                LblSrednNahodVSist.Text = Ws.ToString().Substring(0,5) + " мин";
            else
            LblSrednNahodVSist.Text = Ws.ToString()+" мин";

            double SrednDlinaOcheredi = SrednNahodVSisteme - Intensivnost / IntensivnostObsluz;
            if (SrednDlinaOcheredi.ToString().Length > 5)
                LblSrednDlinaOcheredi.Text = SrednDlinaOcheredi.ToString().Substring(0, 5);
            else LblSrednDlinaOcheredi.Text = SrednDlinaOcheredi.ToString();


            // Установка типа диаграммы
            Chart.Series.Add("Series1");
            Chart.Series["Series1"].ChartType = SeriesChartType.Pie;

            // Установка заголовка
            Chart.Titles.Add("Загруженность врача на текущий час");
            Title title = Chart.Titles[0]; // Заголовок

            // Шрифт для заголовка
            title.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            title.ForeColor= Color.SeaGreen;

            // Добавление данных в диаграмму
            int totalValue = 60; // Общее значение для полной окружности
            double pointsValue = Intensivnost * 3.0; // Значение для серии данных
            Chart.Series["Series1"].Points.Add(pointsValue);
            Chart.Series["Series1"].Points.Add(totalValue - pointsValue); // Добавляем оставшуюся часть для полной окружности
        }
    }
}
