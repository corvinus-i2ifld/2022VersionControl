using Factory.Abstractions;
using Factory.Entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class Form1 : Form
    {

        private List<Toy> _toys = new List<Toy>();
        private IToyFactory _faktory;

        private Toy _nextToy;
        public IToyFactory Faktory
        {
            get { return _faktory; }
            set { _faktory = value;
                DisplayNext();
            }
        }

        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = Faktory.CreateNew();
            _nextToy.Top = lblNext.Top + lblNext.Height + 25;
            _nextToy.Left = lblNext.Left;
            Controls.Add(_nextToy);
        }

        public Form1()
        {
            InitializeComponent();
            Faktory = new CarFactory();
        }
        private void createTimer_Tick(object sender, EventArgs e)
        {
            
        }

        

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var ball in _toys)
            {
                ball.MoveToy();
                if (ball.Left > maxPosition)
                    maxPosition = ball.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestToy = _toys[0];
                mainPanel.Controls.Remove(oldestToy);
                _toys.Remove(oldestToy);
            }

        }

        private void createTimer_Tick_1(object sender, EventArgs e)
        {
            var toy = Faktory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Faktory = new CarFactory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Faktory = new BallFactory();
        }
    }
}
