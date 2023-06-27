using System.Globalization;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace Test
{
    public partial class Form1 : Form
    {
        MqttClient mqttClient;
        int count = 0;


        public Form1()
        {
            InitializeComponent();
        }

      
        private void Mqtt_data(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var msg = Encoding.UTF8.GetString(e.Message);
            Console.WriteLine(msg);
            float number = float.Parse(msg.Substring(3, msg.Length - 3), CultureInfo.InvariantCulture.NumberFormat);

            if (msg.Substring(0, 3) == "!!!")
            {
                
                Console.WriteLine(msg);
                if (number < 18.0 )
                {
                    TEMPERATURE.BackColor = Color.Aqua;
                    TEMPERATURE.ForeColor = Color.Black;

                    TEMPERATURE.Invoke((MethodInvoker)(() => TEMPERATURE.Items.Add($"Низкая температура: {number}")));
                }
                else if ((number <= 18.0) && (number >= 24.0))
                {
                    TEMPERATURE.BackColor = Color.SpringGreen;
                    TEMPERATURE.ForeColor = Color.Black;
                    TEMPERATURE.Invoke((MethodInvoker)(() => TEMPERATURE.Items.Add($"Нормальная температура: {number}")));
                }

                else if (number > 24.0)
                {
                    TEMPERATURE.BackColor = Color.Orange;
                    TEMPERATURE.ForeColor = Color.White;

                    TEMPERATURE.Invoke((MethodInvoker)(() => TEMPERATURE.Items.Add($"Высокая температура: {number}")));
                }


            }
            // Мокро\Не мокро
            else if (msg.Substring(0, 3) == "(((")
            {
                if (number != 1.0 )
                {
                    MOISTURE_DIAPER.BackColor = Color.SpringGreen;
                    MOISTURE_DIAPER.ForeColor = Color.Black;

                    MOISTURE_DIAPER.Invoke((MethodInvoker)(() => MOISTURE_DIAPER.Items.Add("Все впорядке")));
                }
                else
                {
                    MOISTURE_DIAPER.BackColor = Color.Aqua;
                    MOISTURE_DIAPER.ForeColor = Color.DarkBlue;

                    MOISTURE_DIAPER.Invoke((MethodInvoker)(() => MOISTURE_DIAPER.Items.Add("Поменяйте пеленку")));
                }

            }

            // Спит\Не спит
            else if (msg.Substring(0, 3) == "^^^")
            {

                //SLEEPING.Invoke((MethodInvoker)(() => SLEEPING.Items.Add(msg.Substring(2, msg.Length))));

                if (number < 0.4)
                {
                    count = 0;
                    SLEEPING.BackColor = Color.SpringGreen;
                    SLEEPING.ForeColor = Color.Black;

                    SLEEPING.Invoke((MethodInvoker)(() => SLEEPING.Items.Add("Ребенок спит")));
                }
                else if(number > 0.4)
                {
                    
                        SLEEPING.BackColor = Color.Orange;
                        SLEEPING.ForeColor = Color.White;

                        SLEEPING.Invoke((MethodInvoker)(() => SLEEPING.Items.Add("Ребенок проснулся")));
                        count += 1;
                }
            }
            else if (msg.Substring(0, 3) == "***")
            {
                if (number < 55)
                {
                    INDOOR_HUMIDITY.BackColor = Color.Aqua;
                    INDOOR_HUMIDITY.ForeColor = Color.Black;

                    INDOOR_HUMIDITY.Invoke((MethodInvoker)(() => INDOOR_HUMIDITY.Items.Add("Низкая влажность в помещении")));
                }
                else if (number >= 55 && number <= 60)
                {
                    INDOOR_HUMIDITY.BackColor = Color.SpringGreen;
                    INDOOR_HUMIDITY.ForeColor = Color.Black;

                    INDOOR_HUMIDITY.Invoke((MethodInvoker)(() => INDOOR_HUMIDITY.Items.Add("Влажность в норме")));
                }
                else if (number > 60)
                {
                    INDOOR_HUMIDITY.BackColor = Color.Orange;
                    INDOOR_HUMIDITY.ForeColor = Color.White;

                    INDOOR_HUMIDITY.Invoke((MethodInvoker)(() => INDOOR_HUMIDITY.Items.Add("Высокая влажность в помещении")));
                }
            }

        }


        private void MQTT_Client_Load(object sender, EventArgs e)
        {

            Task.Run(() =>
            {
                mqttClient = new MqttClient("broker.emqx.io"); // my server addres
                mqttClient.MqttMsgPublishReceived += Mqtt_data;
                mqttClient.Subscribe(new string[] { "mbed-sample" },
                new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });

                mqttClient.Connect("mbed_sample");
            });

        }
    }
}
