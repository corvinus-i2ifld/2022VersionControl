using SOAP.Entities;
using SOAP.MnbServiceReference;
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
using System.Xml;

namespace SOAP
{
   
    public partial class Form1 : Form
    {
        //string Currencies = new BindingList<RateData>
        
        public Form1()
        {
            InitializeComponent();
            Refreshdata();
            
            
        }

        public void Refreshdata()
        {
            
            GetExhangeRates();
        }

        public void GetExhangeRates()
        {
            
            //WEBSZOLGALTATAS HIVASA
            var mnbService = new MNBArfolyamServiceSoapClient();
            comboBox1.Text = "EUR";
            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = comboBox1.SelectedItem.ToString(),
                startDate = startDatePicker.Value.ToString(),
                endDate = endDatePicker.Value.ToString()
            };
            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            var Rates = new BindingList<RateData>(); 
            Rates.Clear();
            dataGridView1.DataSource = Rates;



            //XML LETREHOZASA

            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {

                var rate = new RateData();
                Rates.Add(rate);

                //datum
                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                //currency
                var childElement = (XmlElement)element.ChildNodes[0];
                rate.Currency = childElement.GetAttribute("curr");

                //value
                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;

                //CHART

                chartRateData.DataSource = Rates;

                var series = chartRateData.Series[0];
                series.ChartType = SeriesChartType.Line;
                series.XValueMember = "Date";
                series.YValueMembers = "Value";
                series.BorderWidth = 2;

                var chartArea = chartRateData.ChartAreas[0];
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisY.MajorGrid.Enabled = false;
                chartArea.AxisY.IsStartedFromZero = false;
            }

        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            Refreshdata();
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            Refreshdata();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refreshdata();
        }
    }
}
