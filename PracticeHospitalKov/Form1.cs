using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PracticeHospitalKov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string TxtCon = "Data Source=213.155.192.79,3002;Initial Catalog=PracticHospital;Persist Security Info=True;User ID=u21volod;Password=by4v";

        public static int Key = 0;

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        double n = 1, t = 15;

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Dt = DateTime.Now;
            DateTime Fdt = DateTime.Parse(Dt.ToString("dd/MM/yyyy HH:mm:ss"));
            Fdt = Fdt.AddMinutes(LstDoctors.Count * t);

            using (SqlConnection Con = new SqlConnection(Form1.TxtCon))
            {
                string CurrentSNILS = $"152-783-614 14";
                string query = "INSERT INTO Request (TimeRequest, Region, FIO, SNILS, Doctor, State) VALUES (@Fdt, @Region, @FIO, @SNILS, @Doctor, @State)";

                using (SqlCommand Cmd = new SqlCommand(query, Con))
                {
                    Cmd.Parameters.AddWithValue("@Fdt", Fdt);
                    Cmd.Parameters.AddWithValue("@Region", "г.Новозыбков");
                    Cmd.Parameters.AddWithValue("@FIO", "Платонов Михаил Никитич");
                    Cmd.Parameters.AddWithValue("@SNILS", CurrentSNILS);
                    Cmd.Parameters.AddWithValue("@Doctor", "Врач-терапевт");
                    Cmd.Parameters.AddWithValue("@State", "Новая");

                    Con.Open();
                    Cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Запись успешно добавлена", "Свершилось!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LstDoctors.Add("+");
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            FormData Frm = new FormData();
            Frm.ShowDialog();
        }

        List<string> LstDoctors = new List<string>();

        private void BtnShowStatistic_Click(object sender, EventArgs e)
        {
            FormStatistics Frm = new FormStatistics();
            Frm.PanelStatistics.Visible = true;
            Frm.PanelFormulas.Visible = false;
            Frm.ShowDialog();
        }

        private void BtnUsedFormulas_Click(object sender, EventArgs e)
        {
            FormStatistics Frm = new FormStatistics();
            Frm.PanelStatistics.Visible = false;
            Frm.PanelFormulas.Visible = true;
            Frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath+ "\\help.chm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime Dt = DateTime.Now;
            DateTime Fdt = DateTime.Parse(Dt.ToString("yyyy-MM-dd HH:mm"));

            using (SqlConnection Con = new SqlConnection(Form1.TxtCon))
            {
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Request", Con);
                Con.Open();

                using (SqlDataReader Res = Cmd.ExecuteReader())
                {
                    while (Res.Read())
                    {
                        if (Fdt < DateTime.Parse(Res["TimeRequest"].ToString()))
                        {
                            LstDoctors.Add($"{Res["TimeRequest"]}&{Res["Doctor"]}");
                        }
                        else
                        {
                            int requestId = int.Parse(Res["IdRequest"].ToString());
                            using (SqlConnection ConTwo = new SqlConnection(Form1.TxtCon))
                            {
                                SqlCommand command = new SqlCommand($"update Request set State='Завершенная' where IdRequest = {requestId}", ConTwo);
                                ConTwo.Open();
                                command.ExecuteNonQuery();
                                ConTwo.Close();
                            }
                        }
                    }
                }
                Con.Close();
            }
        }
    }
}
