using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net.Http;
using System.Net;
using System.Threading;
using System.IO;
using Newtonsoft.Json;

namespace FlyerHub
{

    public partial class frmMain : Form
    {
        private string logPath;
        private string selectedSerialPort;
        private int httpPort;
        private bool newDataIncoming;
        private bool keepReading;



        class FlightData
        {
            public FlightData () {
                flyerData = true;
            }

            public bool flyerData;
            public int sX;      // stickX
            public int sY;      // stickY
            public int sZ;      // stickZ
            public int tt;      // throttle
            public int fL;      // flapL
            public int fR;      // flapR   
            public int sL;      // slatL
            public int sR;      // slatR
            public int sB;      // speedbrake
            public int ru;      // rudder
            public int el;      // elevator
            public bool lF;     // lightFlight
            public bool lL;     // lightLanding
            public bool lT;     // lightTaxi
            public bool rE;     // relayEngine
            public bool aSw;    // apSwitch
            public int aSp;     // apSpd
            public int aH;      // apHdg
            public int aA;      // apAlt
            public int aV;      // apVs



            public int eS;      // engineSpeed - RPM
            public float eT;    // engineTemp - degree Celsius
            public float aS;    // airspeed - knts
            public float gS;    // groundSpeed - knts
            public float vS;    // verticalSpeed -  ft/min
            public int at;      // altitude - ft
            public float hd;    // heading - deg
            public double lLo;  // locationLon
            public double lLa;  // locationLat
            public double aX;   // accX - g
            public double aY;   // accY - g
            public double aZ;   // accZ - g
            public double gX;   // gyroX - deg/s
            public double gY;   // gyroY - deg/s
            public double gZ;   // gyroZ - deg/s
            public double anX;  // angleX - deg
            public double anY;  // angleY - deg
            public double anZ;  // angleZ - deg

            public float bV;    // batteryVoltage - volt
            public float bC;    // batteryCurrent - amp

            public float aT;    // airTemp - degree Celsius
        }
        FlightData flightData;

        public frmMain()
        {
            InitializeComponent();
        }

        private void OpenPort()
        {
            serialPort.PortName = selectedSerialPort;
            serialPort.BaudRate = 115200;
            serialPort.DtrEnable = true;
            serialPort.RtsEnable = true;
            serialPort.Open();
        }

        private void GetPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports == null) return;
            foreach (string port in ports)
            {
                cmbSerialPort.Items.Add(port);
            }
            //cmbSerialPort.SelectedIndex = 0;
        }
        private void GetData()
        {
            new Thread(new ThreadStart(delegate
            {
                while (true)
                {
                    try {
                        //WriteLog("Waiting for imcoming data...");
                        string data = serialPort.ReadLine();
                        //WriteLog("Incoming serial data: " + data);
                        if (data.Substring(0, 2) == "//")
                            WriteLog(data.Substring(2, data.Length - 2));
                        else {
                            flightData = JsonConvert.DeserializeObject<FlightData>(data);
                            ShowData();
                            newDataIncoming = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteLog(ex.Message);
                    }
                }
            })).Start();
        }

        private void WriteLog(string line)
        {
            string fline = "[" + DateTime.Now + "] " + line + Environment.NewLine;
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new MethodInvoker(delegate
                {
                    txtLog.AppendText(fline);
                    txtLog.ScrollToCaret();
                }));
            }
            else
            {
                txtLog.AppendText(fline);
                txtLog.ScrollToCaret();
            }
        }

        private void ShowData()
        {
            if (txtData.InvokeRequired)
            {
                txtData.Invoke(new MethodInvoker(delegate
                {
                txtData.Text =
                    "stickX:\t\t" + flightData.sX.ToString() + Environment.NewLine +
                    "stickY:\t\t" + flightData.sY.ToString() + Environment.NewLine +
                    "stickZ:\t\t" + flightData.sZ.ToString() + Environment.NewLine +
                    "throttle:\t" + flightData.tt.ToString() + Environment.NewLine +
                    "flapL:\t\t" + flightData.fL.ToString() + Environment.NewLine +
                    "flapR:\t\t" + flightData.fR.ToString() + Environment.NewLine +
                    "slatL:\t\t" + flightData.sL.ToString() + Environment.NewLine +
                    "slatR:\t\t" + flightData.sR.ToString() + Environment.NewLine +
                    "speedbrake:\t" + flightData.sB.ToString() + Environment.NewLine +
                    "rudder:\t\t" + flightData.ru.ToString() + Environment.NewLine +
                    "elevator:\t" + flightData.el.ToString() + Environment.NewLine +
                    "lightFlight:\t" + flightData.lF.ToString() + Environment.NewLine +
                    "lightLanding:\t" + flightData.lL.ToString() + Environment.NewLine +
                    "lightTaxi:\t" + flightData.lT.ToString() + Environment.NewLine +
                    "relayEngine:\t" + flightData.rE.ToString() + Environment.NewLine +
                    "apSwitch:\t" + flightData.aSw.ToString() + Environment.NewLine +
                    "apSpd(kts):\t" + flightData.aSp.ToString() + Environment.NewLine +
                    "apHdg(deg):\t" + flightData.aH.ToString() + Environment.NewLine +
                    "apAlt(ft):\t" + flightData.aA.ToString() + Environment.NewLine +
                    "apVs(ft/min):\t" + flightData.aV.ToString() + Environment.NewLine +
                    "engSpeed(rpm):\t" + flightData.eS.ToString() + Environment.NewLine +
                    "engTemp(dC):\t" + flightData.eT.ToString() + Environment.NewLine +
                    "airspeed(kts):\t" + flightData.aS.ToString() + Environment.NewLine +
                    "gndSpd(kts):\t" + flightData.gS.ToString() + Environment.NewLine +
                    "vSped(ft/min):\t" + flightData.vS.ToString() + Environment.NewLine +
                    "altitude(ft):\t" + flightData.at.ToString() + Environment.NewLine +
                    "heading(deg):\t" + flightData.hd.ToString() + Environment.NewLine +
                    "locLon:\t\t" + flightData.lLo.ToString() + Environment.NewLine +
                    "locLat:\t\t" + flightData.lLa.ToString() + Environment.NewLine +
                    "accX(g):\t" + flightData.aX.ToString() + Environment.NewLine +
                    "accY(g):\t" + flightData.aY.ToString() + Environment.NewLine +
                    "accZ(g):\t" + flightData.aZ.ToString() + Environment.NewLine +
                    "gyroX(deg/s):\t" + flightData.gX.ToString() + Environment.NewLine +
                    "gyroY(deg/s):\t" + flightData.gY.ToString() + Environment.NewLine +
                    "gyroZ(deg/s):\t" + flightData.gZ.ToString() + Environment.NewLine +
                    "anX(deg):\t" + flightData.anX.ToString() + Environment.NewLine +
                    "anY(deg):\t" + flightData.anY.ToString() + Environment.NewLine +
                    "anZ(deg):\t" + flightData.anZ.ToString() + Environment.NewLine +
                    "batVolt(volt):\t" + flightData.bV.ToString() + Environment.NewLine +
                    "batCurr(amp):\t" + flightData.bC.ToString() + Environment.NewLine +
                    "airTemp(dC):\t" + flightData.aT.ToString() + Environment.NewLine;
                }));
            }
        }

        private void StartServer()
        {
            HttpListener httpListener = new HttpListener();

            httpListener.AuthenticationSchemes = AuthenticationSchemes.Anonymous;
            httpListener.Prefixes.Add("http://localhost:" + httpPort.ToString() + "/");
            httpListener.Start();
            new Thread(new ThreadStart(delegate
            {
                while (true)
                {
                    try {
                        HttpListenerContext httpListenerContext = httpListener.GetContext();
                        httpListenerContext.Response.StatusCode = 200;
                        while (!newDataIncoming) ;
                        newDataIncoming = false;
                        using (StreamWriter writer = new StreamWriter(httpListenerContext.Response.OutputStream))
                        {
                            writer.Write(JsonConvert.SerializeObject(flightData));
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteLog(ex.Message);
                    }
                }
            })).Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            GetPorts();
            flightData = new FlightData();
        }

        private void grpLog_Enter(object sender, EventArgs e)
        {

        }

        private void btnRefreshSerialPort_Click(object sender, EventArgs e)
        {
            GetPorts();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try {
                tab.SelectedIndex = 1;
                selectedSerialPort = cmbSerialPort.Text;
                WriteLog("Opening Serial Port " + selectedSerialPort + "...");
                OpenPort();
                WriteLog("Serial Port opened.");
                httpPort = (int)nudHttpPort.Value;
                WriteLog("Binding to Port " + httpPort.ToString() + "...");
                StartServer();
                WriteLog("Server started. ");
                GetData();
                btnStart.Enabled = false;
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message);
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
