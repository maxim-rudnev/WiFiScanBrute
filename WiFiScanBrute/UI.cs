using SimpleWifi;
using SimpleWifi.Win32;
using SimpleWifi.Win32.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiFiScanBrute
{

    /// <summary>
    /// реализовано на базе simplewifi
    /// https://www.nuget.org/packages/SimpleWifi
    /// https://github.com/DigiExam/simplewifi
    /// Алгоритмы аутентификации
    /// https://github.com/emoacht/ManagedNativeWifi/blob/master/Source/ManagedNativeWifi/AuthenticationAlgorithm.cs
    /// </summary>
    public partial class UI : Form
    {
        Wifi _wifiConnectClient = new Wifi();           // используется при подключения к сети
        WlanClient _wifiScanClient = new WlanClient();  // используется при сканировании сетей

        List<WlanAvailableNetwork> _wifiNetworks = new List<WlanAvailableNetwork>();

        public UI()
        {
            InitializeComponent();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            _ui_update_connect_state();
        }

        private void button_scan_Click(object sender, EventArgs e)
        {
            if (_wifiConnectClient.ConnectionStatus == WifiStatus.Connected)
            {
                MessageBox.Show("Сканирование доступно только при отключении от сетей WiFi");
                return;
            }

            // сканирование сети и получение списка доступных WiFi сетей
            _wifiNetworks = _wifiScanClient.Interfaces[0].GetAvailableNetworkList(0).ToList();

            // формирование модели представления списка доступных сетей
            var netListVM = _wifiNetworks.Select(x => 
                                                    new { 
                                                        SSID = _getStringForSSID(x.dot11Ssid), 
                                                        AuthAlgo = x.dot11DefaultAuthAlgorithm,
                                                        SignalQuality = x.wlanSignalQuality.ToString() + "%"
                                                    })
                                            .OrderBy(x=>x.SSID)
                                            .ToList();

            // загрузка данных модели представления в UI
            dataGridView_networks.Rows.Clear();
            netListVM.ForEach(x =>
                                {
                                    dataGridView_networks.Rows.Add(new object[] { x.SSID, x.AuthAlgo, x.SignalQuality });
                                });

            dataGridView_networks.Invalidate();
        }

        static string _getStringForSSID(Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            _wifiConnectClient.Disconnect();

            _ui_update_connect_state(false);
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            string selectedNetwork = null;
            
            // проверка, выбрана ли сеть для подключения
            if (dataGridView_networks.SelectedRows.Count > 0)
                selectedNetwork = (string)dataGridView_networks.SelectedRows[0].Cells["SSID"].Value;

            if (string.IsNullOrEmpty(selectedNetwork.Trim()))
            {
                MessageBox.Show($"Не выбрана сеть для подключения");
                return;
            }


            List<AccessPoint> aps = _wifiConnectClient.GetAccessPoints();
            AccessPoint ap = aps.Where(x => x.Name == selectedNetwork).FirstOrDefault();

            AuthRequest ar = new AuthRequest(ap);
            ar.Password = textBox_password.Text;

            bool res = ap.Connect(ar, true);

            _ui_update_connect_state(res);

            if (!res)            
            {                
                MessageBox.Show($"Подключение к сети {selectedNetwork} - не установлено!");
            }
            
        }

        

        private void _ui_update_connect_state(bool? connected = null)
        {
            if ( connected == null && _wifiScanClient.Interfaces[0].InterfaceState == WlanInterfaceState.Connected)
            {
                label_status.Text = "Status: connected to " + _getCurrentNetworkName();
            }
            else if (connected != null && connected.Value)
            {
                label_status.Text = "Status: connected to " + _getCurrentNetworkName();
            }
            else
                label_status.Text = "Status: disconnected";
        }

        private string _getCurrentNetworkName()
        {
            string res = string.Empty;

            try
            {
                res = _wifiScanClient.Interfaces[0].CurrentConnection.profileName;
            }
            catch { }

            return res;
        }
    }
}
