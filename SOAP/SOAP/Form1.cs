﻿using SOAP.Entities;
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

namespace SOAP
{
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            GetExhangeRates();
            
        }

        private void GetExhangeRates()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            { 
                currencyNames="EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };
            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            var Rates = new BindingList<RateData>();
            dataGridView1.DataSource = Rates;

        }
    }
}
