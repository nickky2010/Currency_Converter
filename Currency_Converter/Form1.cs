using Currency_Converter.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        BindingSource source = new BindingSource();
        List<Rate> listCurrencies = new List<Rate>();
        Rate byn = new Rate { Date = DateTime.Now.Date, Cur_Abbreviation = "BYN", Cur_Scale = 1, Cur_Name = "Белорусский рубль", Cur_OfficialRate = 1, FrequencyOfChanges = "Отсутствует" };
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
            dataGridView1.DataSource = source;
            SetFieldsDisable();
        }
        private void SetFieldsDisable()
        {
            comboBoxFromExchange.Enabled = false;
            comboBoxToExchange.Enabled = false;
            textBoxSumExchange.Enabled = false;
            buttonConvert.Enabled = false;
            textBoxSumExchange.Text = "";
            textBoxConvertedSum.Text = "";
            listCurrencies.Clear();
            comboBoxFromExchange.DataSource = null;
            comboBoxToExchange.DataSource = null;
        }
        private void GetCurrenciesNBRB(string date, int periodicity)
        {
            string url = "http://www.nbrb.by/API/ExRates/Rates?onDate=" + date + "&Periodicity=" + periodicity;
            string period = "";
            if (periodicity == 1)
                period = "Ежемесячно";
            else if (periodicity == 0)
                period = "Ежедневно";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string result = sr.ReadLine();
                string[] currencies = result.Split('{', '}');
                foreach (var c in currencies)
                {
                    string[] fieldsCur = c.Split(',');
                    if (fieldsCur.Length > 4)
                    {
                        string[] tmpDate = fieldsCur[1].Split('"', '"');
                        string[] tmpAbbreviation = fieldsCur[2].Split('"', '"');
                        string[] tmpScale = fieldsCur[3].Split('"', '"');
                        string[] tmpName = fieldsCur[4].Split('"', '"');
                        string[] tmpRate = fieldsCur[5].Split('"', '"', ':');
                        DateTime dateCur = Convert.ToDateTime(tmpDate[3]);
                        string abbreviation = tmpAbbreviation[3];
                        int scale = Convert.ToInt32(tmpScale[2].Trim(':'));
                        string name = tmpName[3];
                        double officialRate = Convert.ToDouble(tmpRate[3].Replace('.', ','));
                        Rate rate = new Rate
                        {
                            Date = dateCur,
                            Cur_Abbreviation = abbreviation,
                            Cur_Scale = scale,
                            Cur_OfficialRate = officialRate,
                            Cur_Name = name,
                            FrequencyOfChanges = period
                        };
                        listCurrencies.Add(rate);
                    }
                }
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGetCurrencies_Click(object sender, EventArgs e)
        {
            SetFieldsDisable();
            string date = dateTimePicker1.Value.Year.ToString() + "-" +
                dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString();
            if (radioButtonDaily.Checked || radioButtonAll.Checked)
                GetCurrenciesNBRB(date, 0);
            if (radioButtonMonthly.Checked || radioButtonAll.Checked)
                GetCurrenciesNBRB(date, 1);
            listCurrencies.Add(byn);
            source.DataSource = listCurrencies.OrderBy(r=>r.Cur_Name);
            comboBoxFromExchange.DataSource = listCurrencies.OrderBy(r => r.Cur_Name).Select(n => n.Cur_Name).ToList();
            comboBoxFromExchange.Enabled = true;
            SetSettingsGridColumns();
        }

        private void SetSettingsGridColumns()
        {
            dataGridView1.Columns[0].Width = 85;
            dataGridView1.Columns[0].HeaderText = "Дата";
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[1].HeaderText = "Код";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].HeaderText = "Количество";
            dataGridView1.Columns[3].Width = 300;
            dataGridView1.Columns[3].HeaderText = "Наименование валюты";
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[4].HeaderText = "Курс";
            dataGridView1.Columns[5].Width = 120;
            dataGridView1.Columns[5].HeaderText = "Периодичность";
        }

        private void comboBoxFromExchange_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxToExchange.Enabled = true;
            comboBoxToExchange.DataSource = listCurrencies.OrderBy(r => r.Cur_Name).Select(n => n.Cur_Name).Where(a => a != comboBoxFromExchange.SelectedItem.ToString()).ToList();
        }

        private void comboBoxToExchange_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBoxSumExchange.Enabled = true;
            buttonConvert.Enabled = true;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            decimal exchangeSum;
            string abbreviation;
            if (decimal.TryParse(textBoxSumExchange.Text, out exchangeSum))
                textBoxConvertedSum.Text = GetConvertedValue(exchangeSum, out abbreviation).ToString("f2") + " " + abbreviation;
            else
                MessageBox.Show("Значение поля \"сумма для обмена\" не является корректным. Для конвертации валют введите корректные данные!");
        }
        private decimal GetConvertedValue(decimal exchangeSum, out string abbreviation)
        {
            decimal resultConvert = 0;
            Rate fromRate = listCurrencies.Find(r => r.Cur_Name == comboBoxFromExchange.SelectedItem.ToString());
            Rate toRate = listCurrencies.Find(r => r.Cur_Name == comboBoxToExchange.SelectedItem.ToString());
            abbreviation = toRate.Cur_Abbreviation;
            if (fromRate.Cur_Name == byn.Cur_Name)
                resultConvert = (exchangeSum / (decimal)toRate.Cur_OfficialRate) * toRate.Cur_Scale;
            else if (toRate.Cur_Name == byn.Cur_Name)
                resultConvert = (exchangeSum * (decimal)fromRate.Cur_OfficialRate) / fromRate.Cur_Scale;
            else
            {
                decimal tmpByn = (exchangeSum * (decimal)fromRate.Cur_OfficialRate) / fromRate.Cur_Scale;
                resultConvert = (tmpByn / (decimal)toRate.Cur_OfficialRate) * toRate.Cur_Scale;
            }
            return resultConvert;
        }
    }
}
