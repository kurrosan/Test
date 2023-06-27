namespace Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TemperatureDataReceived = new GroupBox();
            TEMPERATURE = new ListBox();
            groupBox1 = new GroupBox();
            MOISTURE_DIAPER = new ListBox();
            groupBox2 = new GroupBox();
            INDOOR_HUMIDITY = new ListBox();
            groupBox3 = new GroupBox();
            SLEEPING = new ListBox();
            fontDialog1 = new FontDialog();
            TemperatureDataReceived.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // TemperatureDataReceived
            // 
            TemperatureDataReceived.Controls.Add(TEMPERATURE);
            TemperatureDataReceived.Location = new Point(12, 11);
            TemperatureDataReceived.Margin = new Padding(3, 2, 3, 2);
            TemperatureDataReceived.Name = "TemperatureDataReceived";
            TemperatureDataReceived.Padding = new Padding(3, 2, 3, 2);
            TemperatureDataReceived.Size = new Size(284, 305);
            TemperatureDataReceived.TabIndex = 0;
            TemperatureDataReceived.TabStop = false;
            TemperatureDataReceived.Text = "ТЕМПЕРАТУРА";
            // 
            // TEMPERATURE
            // 
            TEMPERATURE.Dock = DockStyle.Fill;
            TEMPERATURE.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TEMPERATURE.FormattingEnabled = true;
            TEMPERATURE.ItemHeight = 25;
            TEMPERATURE.Location = new Point(3, 18);
            TEMPERATURE.Margin = new Padding(3, 2, 3, 2);
            TEMPERATURE.Name = "TEMPERATURE";
            TEMPERATURE.Size = new Size(278, 285);
            TEMPERATURE.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MOISTURE_DIAPER);
            groupBox1.Location = new Point(302, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(293, 305);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ВЛАЖНОСТЬ ПЕЛЕНКИ";
            // 
            // MOISTURE_DIAPER
            // 
            MOISTURE_DIAPER.Dock = DockStyle.Fill;
            MOISTURE_DIAPER.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            MOISTURE_DIAPER.FormattingEnabled = true;
            MOISTURE_DIAPER.ItemHeight = 25;
            MOISTURE_DIAPER.Location = new Point(3, 18);
            MOISTURE_DIAPER.Margin = new Padding(3, 2, 3, 2);
            MOISTURE_DIAPER.Name = "MOISTURE_DIAPER";
            MOISTURE_DIAPER.Size = new Size(287, 285);
            MOISTURE_DIAPER.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(INDOOR_HUMIDITY);
            groupBox2.Location = new Point(601, 11);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(301, 303);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ВЛАЖНОСТЬ В ПОМЕЩЕНИИ";
            // 
            // INDOOR_HUMIDITY
            // 
            INDOOR_HUMIDITY.Dock = DockStyle.Fill;
            INDOOR_HUMIDITY.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            INDOOR_HUMIDITY.FormattingEnabled = true;
            INDOOR_HUMIDITY.ItemHeight = 25;
            INDOOR_HUMIDITY.Location = new Point(3, 18);
            INDOOR_HUMIDITY.Margin = new Padding(3, 2, 3, 2);
            INDOOR_HUMIDITY.Name = "INDOOR_HUMIDITY";
            INDOOR_HUMIDITY.Size = new Size(295, 283);
            INDOOR_HUMIDITY.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(SLEEPING);
            groupBox3.Location = new Point(908, 11);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(284, 301);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "СОН";
            // 
            // SLEEPING
            // 
            SLEEPING.Dock = DockStyle.Fill;
            SLEEPING.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SLEEPING.FormattingEnabled = true;
            SLEEPING.ItemHeight = 25;
            SLEEPING.Location = new Point(3, 18);
            SLEEPING.Margin = new Padding(3, 2, 3, 2);
            SLEEPING.Name = "SLEEPING";
            SLEEPING.Size = new Size(278, 281);
            SLEEPING.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 360);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(TemperatureDataReceived);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "MQTT Client";
            Load += MQTT_Client_Load;
            TemperatureDataReceived.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox TemperatureDataReceived;
        private ListBox TEMPERATURE;
        private GroupBox groupBox1;
        private ListBox MOISTURE_DIAPER;
        private GroupBox groupBox2;
        private ListBox INDOOR_HUMIDITY;
        private GroupBox groupBox3;
        private ListBox SLEEPING;
        private FontDialog fontDialog1;
    }
}