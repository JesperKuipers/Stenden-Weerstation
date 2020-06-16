using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;

namespace Stenden_Weerstation
{
    public partial class MainWindow : Form
    {
        private Boolean error;
        private string plaats;
        private double temperature;
        private int humidity;
        private double windSpeed;
        private int windDegree;
        private string weatherType;
        private string city;
        private string lastUpdate;
        private string weatherIconID;
        private Timer timer;
        private int interval;

        public MainWindow()
        {
            InitializeComponent();
            error = false;
            plaats = "";
            temperature = 0;
            humidity = 0;
            windSpeed = 0;
            windDegree = 0;
            weatherType = "";
            city = "";
            lastUpdate = "";
            weatherIconID = "02d";
            interval = 0;
        }

        //Database connection
        private SqlConnection ConnectDatabase()
        {
            var selectConnection = @"Data Source = (localdb)\MSSQLLocalDB;" +
                    @"Database=StendenWeerstation;" +
                    @"Integrated Security = True;" +
                    @"Connect Timeout = 30;" +
                    @"Encrypt = False;" +
                    @"TrustServerCertificate = False;" +
                    @"ApplicationIntent = ReadWrite;" +
                    @"MultiSubnetFailover = False";

            return new SqlConnection(selectConnection);
        }

        //Notifyicon setup
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipText = "Stenden Weerstation draait op de achtergrond";
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
                ShowInTaskbar = true;
            }
        }

        //Context-menu
        private void overToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }

        private void verversenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetWheather();
            lastUpdate = DateTime.Now.ToString();
            Actueel_Update.Text = lastUpdate;
        }

        private void optiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            tabControl1.SelectedTab = tabPage3;
        }

        private void openenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        //Minimize instead of closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
            }
        }


        /// <summary>
        /// Opties tab
        /// </summary>
        //Get info from the Optie tab
        private void Opties_Plaats2_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[A-Za-z\s*]+$")).IsMatch(Opties_Plaats2.Text))
            {
                Opties_Plaats2.ForeColor = Color.Black;

            }
            else
            {
                Opties_Plaats2.ForeColor = Color.Red;
                error = true;
            }
        }

        public String GetPlaats()
        {
            return Opties_Plaats2.Text;
        }

        public int GetInterval()
        {
            return int.Parse(Opties_Interval2.Text);
        }

        public Boolean IsCelsius()
        {
            if (Celsius.Checked)
            {
                return true;
            }
            else if (Fahrenheit.Checked)
            {
                return false;
            }
            else
            {
                error = true;
                //celsius is default
                return true;
            }
        }

        //the button that runs the update for the Opties
        private void Opties_Button_Click(object sender, EventArgs e)
        {
            GetOpties();
        }

        private void GetOpties()
        {
            try
            {
                if (!error)
                {
                    Opties_Error.Text = "";

                    var connection = ConnectDatabase();

                    var deletecmd = connection.CreateCommand();
                    deletecmd.CommandText = $"delete from Opties";

                    var cmd = connection.CreateCommand();
                    cmd.CommandText = $"insert into Opties values (@param1, @param2, @param3)";
                    cmd.Parameters.AddWithValue("@param1", SqlDbType.NVarChar).Value = GetPlaats();
                    cmd.Parameters.AddWithValue("@param2", SqlDbType.Int).Value = GetInterval();
                    cmd.Parameters.AddWithValue("@param3", SqlDbType.TinyInt).Value = IsCelsius();

                    connection.Open();

                    deletecmd.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    connection.Close();

                    Opties_Succeed.Text = "Updated";

                    plaats = GetPlaats();
                    interval = GetInterval();
                }
                else
                {
                    Opties_Error.Text = "Something went wrong try again";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SetOpties()
        {
            try
            {
                bool isCelsius = true;

                var connection = ConnectDatabase();

                var cmd = connection.CreateCommand();
                cmd.CommandText = $"select * from Opties";
                connection.Open();
                var reader = cmd.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        plaats = (string)reader.GetValue(0);
                        interval = (int)reader.GetValue(1);
                        isCelsius = (bool)reader.GetValue(2);
                    }
                }
                reader.Close();
                cmd.Dispose();
                connection.Close();

                Opties_Plaats2.Text = plaats;
                Opties_Interval2.Text = interval.ToString();
                if (isCelsius)
                {
                    Celsius.Checked = true;
                    Fahrenheit.Checked = false;
                }
                else
                {
                    Celsius.Checked = false;
                    Fahrenheit.Checked = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Trend tab
        /// </summary>
        //Loads the chart without data
        public void LoadChart()
        {
            foreach (var Series in chart1.Series)
                Series.Points.Clear();

            //chart1.Series["GemTemp"].Points.AddXY(DateTime.Now, 32);
            //chart1.Series["GemTemp"].Points.AddXY(DateTime.Now, 9);

            try
            {
                var connection = ConnectDatabase();

                var cmd = connection.CreateCommand();
                cmd.CommandText = $"select * from APIdata";
                connection.Open();
                var reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        chart1.Series["GemTemp"].Points.AddXY(reader.GetValue(2), reader.GetValue(1));
                    }
                }
                reader.Close();
                cmd.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Process api responds to data
        /// </summary>
        public void SetWheather()
        {
            try
            {
                var webService = new ServiceReference1.WebService1SoapClient();
                var json = webService.WebAPIController(GetPlaats());
                ConvertWeather convertWeather = JsonConvert.DeserializeObject<ConvertWeather>(json);

                temperature = (int)convertWeather.main.temp;
                if (IsCelsius())
                    temperature = temperature - 273.15;
                else
                    temperature = (temperature - 273.15) * 1.8 + 32;

                humidity = convertWeather.main.humidity;

                windSpeed = convertWeather.wind.speed * 3.6;

                windDegree = convertWeather.wind.deg;

                weatherType = convertWeather.weather[0].main;

                weatherIconID = convertWeather.weather[0].icon;

                city = convertWeather.name;

                UpdateWeatherLabels();
                SetWheaterInDB(temperature);
                RemoveOldWheaterInDB();
                LoadChart();
            }
            catch
            {
                Console.WriteLine("Did you turn on the WebAPICOntroller?");
                Opties_Error.Text = "De plaats bestaat niet of er is geen internet";
            }
        }

        public void SetWheaterInDB(double temp)
        {

            try
            {
                var connection = ConnectDatabase();

                var cmd = connection.CreateCommand();
                cmd.CommandText = "insert into APIData (temperature, date) values (@param1, @param2)";
                cmd.Parameters.AddWithValue("@param1", SqlDbType.Float).Value = temp;
                cmd.Parameters.AddWithValue("@param2", SqlDbType.DateTime).Value = DateTime.Now;

                connection.Open();

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void RemoveOldWheaterInDB()
        {
            try
            {
                var connection = ConnectDatabase();

                var deletecmd = connection.CreateCommand();
                deletecmd.CommandText = $"delete from APIdata where date < GETDATE() - 4";

                connection.Open();

                deletecmd.ExecuteNonQuery();

                deletecmd.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateWeatherLabels()
        {
            //Update de last updated time
            lastUpdate = DateTime.Now.ToString();
            Actueel_Update.Text = lastUpdate;

            //Update the current city
            Actueel_Plaats.Text = city;

            //Update the weather type, exmpale: Cloudy
            Actueel_weer.Text = weatherType;

            //Update humidity
            Actueel_Luchtvochtigheid.Text = String.Format("Luchtvochtigheid: {0}%", humidity);

            //Update temp based on user choice of F or C
            if (IsCelsius())
            {
                var tempCString = String.Format("Temperatuur: {0}C", temperature);
                Actueel_Temperatuur.Text = tempCString;
                huidigeTemperatuurErrorToolStripMenuItem.Text = tempCString;
            }
            else
            {
                var tempFString = String.Format("Temperatuur: {0}F", temperature);
                Actueel_Temperatuur.Text = tempFString;
                huidigeTemperatuurErrorToolStripMenuItem.Text = tempFString;
            }

            //Update icon based on weather
            if (weatherIconID == "11d" || weatherIconID == "11n")
                pictureBox1.Image = Properties.Resources.thunderstorm;
            else if (weatherIconID == "09d" || weatherIconID == "09n")
                pictureBox1.Image = Properties.Resources.shower_rain;
            else if (weatherIconID == "10d")
                pictureBox1.Image = Properties.Resources.rain;
            else if (weatherIconID == "10n")
                pictureBox1.Image = Properties.Resources.rain_night;
            else if (weatherIconID == "13d" || weatherIconID == "13n")
                pictureBox1.Image = Properties.Resources.snow;
            else if (weatherIconID == "50d" || weatherIconID == "50n")
                pictureBox1.Image = Properties.Resources.mist;
            else if (weatherIconID == "01d")
                pictureBox1.Image = Properties.Resources.clear_sky;
            else if (weatherIconID == "01n")
                pictureBox1.Image = Properties.Resources.clear_sky_night;
            else if (weatherIconID == "02d")
                pictureBox1.Image = Properties.Resources.few_clouds;
            else if (weatherIconID == "02n")
                pictureBox1.Image = Properties.Resources.few_clouds_night;
            else if (weatherIconID == "03d" || weatherIconID == "03n")
                pictureBox1.Image = Properties.Resources.scattered_clouds;
            else if (weatherIconID == "04d" || weatherIconID == "04n")
                pictureBox1.Image = Properties.Resources.broken_clouds;

            //Update wind
            var windDegreeString = "";

            if (windDegree >= 23 && windDegree <= 68)
                windDegreeString = "NO";
            else if (windDegree >= 68 && windDegree <= 113)
                windDegreeString = "O";
            else if (windDegree >= 113 && windDegree <= 158)
                windDegreeString = "ZO";
            else if (windDegree >= 158 && windDegree <= 203)
                windDegreeString = "Z";
            else if (windDegree >= 203 && windDegree <= 248)
                windDegreeString = "ZW";
            else if (windDegree >= 248 && windDegree <= 293)
                windDegreeString = "W";
            else if (windDegree >= 293 && windDegree <= 338)
                windDegreeString = "NW";
            else
                windDegreeString = "N";

            var windString = String.Format("Wind: {0} met {1} km/h", windDegreeString, windSpeed);
            Actueel_Wind.Text = windString;
        }

        public void UpdateWheather()
        {
            //Create and start a timer
            timer = new Timer { Interval = interval * 1000 };
            timer.Tick += OnTick;
            timer.Start();
        }

        private void OnTick(object sender, EventArgs e)
        {
            if (timer.Enabled)
                timer.Stop();

            SetWheather();
            UpdateWheather();
        }
    }
}
