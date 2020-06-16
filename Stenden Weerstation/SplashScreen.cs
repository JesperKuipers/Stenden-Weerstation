using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stenden_Weerstation
{
    public partial class SplashScreen : Form
    {
        private readonly Timer timer;
        private MainWindow mainWindow;

        public SplashScreen()
        {
            InitializeComponent();

            //Create and start a timer
            timer = new Timer { Interval = 3000 };
            timer.Tick += OnTick;
            timer.Start();

            mainWindow = new MainWindow();
            //Load Opties from database
            mainWindow.SetOpties();
            //Load the chart without data
            mainWindow.LoadChart();
            //Load wheather the first time
            mainWindow.SetWheather();
            //Update weather
            mainWindow.UpdateWheather();
        }

        private void OnTick(object sender, EventArgs e)
        {
            if(timer.Enabled)
                timer.Stop();

            //hide splashscreen and run main window
            Hide();
            mainWindow.Show();
        }
    }
}
