using PPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Anketa : Form
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Egarshan\Education\4 курс\Интеллектуальные системы\Лабораторная работа №1\PPC\PPC\PCC_DB.mdf;Integrated Security=True";
        string sqlExpression;   //строка для запросов к БД
        int[] Elements_prices = { 0, 0, 0, 0 }; //цены элементов
        Configuration cnf1, cnf2, cnf3;   //экземпляры конфигурации

        public Anketa()
        {
            InitializeComponent();
            
            ToolTip TP = new ToolTip(); //формирование подсказок для параметров

            TP.SetToolTip(Is_gaming_HINT, "Если вы - любитель видеоигр, или вам необходимо работать с тяжёлым ПО\n" +
                "(монтаж видео, компьютерная графика и т.д), то обязательно отметьте данный пункт.");

            TP.SetToolTip(Is_portable_HINT, "Любите путешествовать, а не сидеть на стуле за рабочим столом? Тогда отметье данный\n " +
                "пункт и мы подберём для вас наилучший ноутбук!");

            TP.SetToolTip(Budget_HINT, "Укажите максимальную сумму(в рублях), которую вы готовы потратить на приобретение ПК.");

            TP.SetToolTip(VC_producer_HINT, "Если вы отдаёте предпочтение определенному производителю, то выберите его в списке.\n" +
                "В случае, если не найдётся подходящей видеокарты, указанного производителя, то мы подберем видеокарту другого\n" +
                "производителя, которая будет ничем не хуже.");

            TP.SetToolTip(VC_memory_HINT, "Чем больше видеопамяти имеет видеокарта, тем быстрее будет работать ваш ПК");
            
            TP.SetToolTip(Proc_producer_HINT, "Если вы отдаёте предпочтение определенному производителю, то выберите его в списке.\n" +
                "В случае, если не найдётся подходящего процессора, указанного производителя, то мы подберем процессор другого\n" +
                "производителя, который будет ничем не хуже.");

            TP.SetToolTip(SSD_HINT, "Чем больше объём твердотельного накопителя, тем больше вы сможете хранить файлов на своём ПК.");
            
            TP.SetToolTip(RAM_HINT, "Чем больше объём оперативной памяти, тем быстрее будет работать ваш ПК.");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                sqlExpression = "SELECT DISTINCT PRODUCER FROM VIDEO_CARD"; //DISTINCT - уникальные значения
                Load_DataSet(sqlExpression, VC_Producer_field, connection);

                sqlExpression = "SELECT DISTINCT VIDEO_MEMORY FROM VIDEO_CARD";
                Load_DataSet(sqlExpression, VC_Memory_field, connection, "Гб");

                sqlExpression = "SELECT DISTINCT PRODUCER FROM PROCESSOR";
                Load_DataSet(sqlExpression, Proc_Producer_field, connection);

                sqlExpression = "SELECT DISTINCT MEMORY FROM SSD";
                Load_DataSet(sqlExpression, SSD_Memory_field, connection, "Гб");

                sqlExpression = "SELECT DISTINCT MEMORY FROM RAM";
                Load_DataSet(sqlExpression, RAM_Memory_field, connection, "Гб");

                connection.Close();
            }
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            if (VC_Producer_field.SelectedItem == null || VC_Memory_field.SelectedItem == null ||
                Proc_Producer_field.SelectedItem == null || SSD_Memory_field.SelectedItem == null || RAM_Memory_field.SelectedItem == null)
                Waring_label.Visible = true;
            else
            {
                cnf1 = new Configuration();
                cnf2 = new Configuration();
                cnf3 = new Configuration();
                SetConfig();    //функция формирования конфигурации
                Result result = new Result(cnf1, cnf2, cnf3);
                result.Show();
                this.Hide();
            }
        }

        private void Load_DataSet (string SQLExpr, ComboBox CB, SqlConnection connect, string postfix = "")
        {
            SqlCommand sqlCommand = new SqlCommand(sqlExpression, connect);
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            if (sqlReader.HasRows)
            {
                if (postfix == "")
                    while (sqlReader.Read())
                        CB.Items.Add(sqlReader.GetValue(0).ToString().Trim());
                else
                    while (sqlReader.Read())
                        CB.Items.Add(sqlReader.GetValue(0).ToString().Trim() + " " + postfix);
            }

            sqlReader.Close();
        }

        private void SetConfig()
        {
            
            int Is_gaming = 0;

            if (Is_Gaming_field.Checked)
            {
                Is_gaming = 1;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                sqlExpression = "SELECT PRICE FROM VIDEO_CARD WHERE";
                if (VC_Producer_field.SelectedItem.ToString() != "Не знаю")
                    sqlExpression += " PRODUCER = '" + VC_Producer_field.SelectedItem + "' AND";
                sqlExpression += " VIDEO_MEMORY = '" + VC_Memory_field.SelectedItem.ToString().Trim(' ', 'Г', 'б') + "' AND " +
                    "IS_GAMING = '" + Is_gaming + "' ORDER BY PRICE DESC";
                Elements_prices[0] = Get_Element_MaxPrice(sqlExpression, connection);

                sqlExpression = "SELECT PRICE FROM PROCESSOR WHERE";
                if (Proc_Producer_field.SelectedItem.ToString() != "Не знаю")
                    sqlExpression += " PRODUCER = '" + Proc_Producer_field.SelectedItem + "' AND";
                sqlExpression += " IS_GAMING = '" + Is_gaming + "' ORDER BY PRICE DESC";
                Elements_prices[1] = Get_Element_MaxPrice(sqlExpression, connection);

                sqlExpression = "SELECT PRICE FROM RAM WHERE MEMORY = '" + RAM_Memory_field.SelectedItem.ToString().Trim(' ', 'Г', 'б') + "' ORDER BY PRICE DESC";
                Elements_prices[2] = Get_Element_MaxPrice(sqlExpression, connection);

                sqlExpression = "SELECT PRICE FROM SSD WHERE MEMORY = '" + SSD_Memory_field.SelectedItem.ToString().Trim(' ', 'Г', 'б') + "' ORDER BY PRICE DESC";
                Elements_prices[3] = Get_Element_MaxPrice(sqlExpression, connection);


                if (Elements_prices.Sum() > Budget_field.Value)
                {
                    sqlExpression = "SELECT PRICE FROM SSD ORDER BY PRICE DESC";
                    DropDownPrice(sqlExpression, connection, 3);

                    if (Elements_prices.Sum() > Budget_field.Value)
                    {
                        sqlExpression = "SELECT PRICE FROM RAM ORDER BY PRICE DESC";
                        DropDownPrice(sqlExpression, connection, 2);

                        if (Elements_prices.Sum() > Budget_field.Value)
                        {
                            sqlExpression = "SELECT PRICE FROM PROCESSOR ORDER BY PRICE DESC";
                            DropDownPrice(sqlExpression, connection, 1);

                            if (Elements_prices.Sum() > Budget_field.Value)
                            {
                                sqlExpression = "SELECT PRICE FROM VIDEO_CARD ORDER BY PRICE DESC";
                                DropDownPrice(sqlExpression, connection, 0);
                            }
                        }
                    }
                    CreateConfiguration(connection, cnf1);
                }
                else
                    CreateConfiguration(connection, cnf1);  //фиксирование комплектующих конфигурации
               
               if (Elements_prices.Sum() > 8600 || Elements_prices.Sum() > 8800)
               {
                    Budget_field.Value = Elements_prices.Sum();

                    if (Elements_prices.Sum() >= Budget_field.Value)
                    {
                        sqlExpression = "SELECT PRICE FROM VIDEO_CARD ORDER BY PRICE DESC";
                        DropDownPrice(sqlExpression, connection, 0);

                        if (Elements_prices.Sum() >= Budget_field.Value)
                        {
                            sqlExpression = "SELECT PRICE FROM PROCESSOR ORDER BY PRICE DESC";
                            DropDownPrice(sqlExpression, connection, 1);

                            if (Elements_prices.Sum() >= Budget_field.Value)
                            {
                                sqlExpression = "SELECT PRICE FROM RAM ORDER BY PRICE DESC";
                                DropDownPrice(sqlExpression, connection, 2);

                                if (Elements_prices.Sum() >= Budget_field.Value)
                                {
                                    sqlExpression = "SELECT PRICE FROM SSD ORDER BY PRICE DESC";
                                    DropDownPrice(sqlExpression, connection, 3);
                                }
                            }
                        }
                        CreateConfiguration(connection, cnf2);
                    }
                    else
                        CreateConfiguration(connection, cnf1);
                }

                if (Elements_prices.Sum() > 8600 || Elements_prices.Sum() > 8800)
                {
                    Budget_field.Value = Elements_prices.Sum();

                    if (Elements_prices.Sum() >= Budget_field.Value)
                    {
                        sqlExpression = "SELECT PRICE FROM PROCESSOR ORDER BY PRICE DESC";
                        DropDownPrice(sqlExpression, connection, 1);

                        if (Elements_prices.Sum() >= Budget_field.Value)
                        {
                            sqlExpression = "SELECT PRICE FROM VIDEO_CARD ORDER BY PRICE DESC";
                            DropDownPrice(sqlExpression, connection, 0);

                            if (Elements_prices.Sum() >= Budget_field.Value)
                            {
                                sqlExpression = "SELECT PRICE FROM RAM ORDER BY PRICE DESC";
                                DropDownPrice(sqlExpression, connection, 2);

                                if (Elements_prices.Sum() >= Budget_field.Value)
                                {
                                    sqlExpression = "SELECT PRICE FROM SSD ORDER BY PRICE DESC";
                                    DropDownPrice(sqlExpression, connection, 3);
                                }
                            }
                        }
                        CreateConfiguration(connection, cnf3);
                    }
                    else
                        CreateConfiguration(connection, cnf1);
                }

                connection.Close();          
            }
        }

        private int Get_Element_MaxPrice(string SQLExpr, SqlConnection connect)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlExpression, connect);
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            int price = 0;

            if (sqlReader.HasRows)
            {
                sqlReader.Read();

                price = (int)sqlReader.GetValue(0);
                sqlReader.Close();
                return price;
            }

            sqlReader.Close();
            return price;
        }

        private void DropDownPrice (string SQLExpr, SqlConnection connect, int el_index)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlExpression, connect);
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())    //пока не закончились записи (строки)
                {
                    if (Elements_prices.Sum() < Budget_field.Value) break;
                    Elements_prices[el_index] = (int)sqlReader.GetValue(0);
                }
            }

            sqlReader.Close();
        }

        private void CreateConfiguration (SqlConnection connect, Configuration cnfg)
        {
            string note_book_postfix = "";
            if (Is_Portable_field.Checked)
            {
                cnfg.type = "Ноутбук";
                note_book_postfix = "(NoteBook)";
            }
            else
                cnfg.type = "Стационарный компьютер";

            sqlExpression = "SELECT * FROM VIDEO_CARD WHERE PRICE = '" + Elements_prices[0] + "'";

            SqlCommand sqlCommand = new SqlCommand(sqlExpression, connect);
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                cnfg.VC_info = sqlReader.GetValue(2).ToString().Trim() + " " + sqlReader.GetValue(3).ToString().Trim() + " " + note_book_postfix +
                    " " + sqlReader.GetValue(4).ToString().Trim() + " Гб |" + sqlReader.GetValue(5).ToString().Trim() + " РУБ|";
            }
            sqlReader.Close();

            sqlExpression = "SELECT * FROM PROCESSOR WHERE PRICE = '" + Elements_prices[1] + "'";
            
            sqlCommand = new SqlCommand(sqlExpression, connect);
            sqlReader = sqlCommand.ExecuteReader();

            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                cnfg.Proc_info = sqlReader.GetValue(2).ToString().Trim() + " " + sqlReader.GetValue(3).ToString().Trim() + " " + note_book_postfix +
                    " |" + sqlReader.GetValue(4).ToString().Trim() + " РУБ|";
            }
            sqlReader.Close();

            sqlExpression = "SELECT * FROM RAM WHERE PRICE = '" + Elements_prices[2] + "'";

            sqlCommand = new SqlCommand(sqlExpression, connect);
            sqlReader = sqlCommand.ExecuteReader();

            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                cnfg.RAM_info = sqlReader.GetValue(1).ToString().Trim() + " " + sqlReader.GetValue(2).ToString().Trim() +
                     " Гб " + note_book_postfix + " |" + sqlReader.GetValue(3).ToString().Trim() + " РУБ|";
            }
            sqlReader.Close();

            sqlExpression = "SELECT * FROM SSD WHERE PRICE = '" + Elements_prices[3] + "'";

            sqlCommand = new SqlCommand(sqlExpression, connect);
            sqlReader = sqlCommand.ExecuteReader();

            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                cnfg.SSD_info = sqlReader.GetValue(1).ToString().Trim() + " " + sqlReader.GetValue(2).ToString().Trim() +
                    " Гб " + note_book_postfix + " |" + sqlReader.GetValue(3).ToString().Trim() + " РУБ|";
            }
            sqlReader.Close();

            cnfg.price = Elements_prices.Sum();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
