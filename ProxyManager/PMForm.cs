using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Xml;

namespace ProxyManager
{
    public partial class PMForm : Form
    {
        #region --------- Properties and Settings ---------
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        const string ProxyEnableRegKey = "ProxyEnable";
        const string ProxyOverrideRegKey = "ProxyOverride";
        const string ProxyServerRegKey = "ProxyServer";
        static bool settingsReturn, refreshReturn;
        RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
        private Proxy _currentProxy;
        public string CurrentProxy
        {
            set
            {
                _currentProxy = new Proxy(value);
                txtProxy.Text = _currentProxy._proxy;
                txtPort.Text = _currentProxy._port;
            }
        }
        public string CurrentProxyExceptions
        {
            set
            {
                if (_currentProxy != null)
                    _currentProxy._exceptions = value;
                txtExceptions.Text = value;
            }
        }
        public bool CurrentProxyEnabled
        {
            set { btnEnableProxy.Text = value ? "DISABLE PROXY" : "ENABLE PROXY"; }
        }

        List<Proxy> ProxyList = new List<Proxy>();
        #endregion

        public PMForm()
        {
            InitializeComponent();
            try
            {
                CurrentProxy = registry.GetValue(ProxyServerRegKey) + "";
                CurrentProxyEnabled = (int.Parse(registry.GetValue(ProxyEnableRegKey) + "") == 1 ? true : false);
                CurrentProxyExceptions = registry.GetValue(ProxyOverrideRegKey) + "";

                ProxyList.Add(_currentProxy);

                LoadXML();
            }
            catch (Exception ex) { Log(ex); }
        }
        private void LoadXML()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ProxyList.xml");

                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    if (node.HasChildNodes)
                    {
                        ProxyList.Add(new Proxy()
                        {
                            _nome = node["name"].InnerText,
                            _proxy = node["address"].InnerText,
                            _port = node["port"].InnerText,
                            _exceptions = node["exceptions"].InnerText
                        });
                    }
                }

                ProxyList.ForEach(x =>
                {
                    ddlProxy.Items.Add(x._nome);
                });
                ddlProxy.SelectedIndex = 0;

                ddlProxy.Visible =
                btnSelectProxy.Visible = true;
            }
            catch (Exception) { Log(new Exception("Errore nel caricamento del file ProxyList.xml")); }
        }
        private void chkProxyEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox) != null)
                SetProxyEnabled((sender as CheckBox).Checked);
        }
        private void btnSetProxy_Click(object sender, EventArgs e)
        {
            SetProxy(_currentProxy);
        }
        private void btnSelectProxy_Click(object sender, EventArgs e)
        {
            Proxy proxy = ProxyList.Where(x => x._nome == ddlProxy.SelectedItem.ToString()).First();
            txtProxy.Text = proxy._proxy;
            txtPort.Text = proxy._port;
            txtExceptions.Text = proxy._exceptions;
        }

        #region ------------------ Utils ------------------
        private void SetProxy(Proxy proxy)
        {
            try
            {
                if (proxy == null)
                    return;
                registry.SetValue(ProxyServerRegKey, proxy.RealProxy);
                registry.SetValue(ProxyOverrideRegKey, proxy._exceptions);

                RefreshSettings();
            }
            catch (Exception ex) { Log(ex); }
        }
        private void SetProxyEnabled(bool enabled)
        {
            try
            {
                registry.SetValue(ProxyEnableRegKey, enabled ? 1 : 0);
                CurrentProxyEnabled = enabled;

                RefreshSettings();
            }
            catch (Exception ex) { Log(ex); }
        }
        private void RefreshSettings()
        {
            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to really update
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }
        private void Log(Exception ex)
        {
            string textMess = string.Empty;
            string name = string.Empty;
            try
            {
                System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace();
                System.Diagnostics.StackFrame sf = st.GetFrame(2);
                name = sf.GetMethod().Name;
            }
            catch (Exception) { name = "Method"; }
            textMess = "Exception in Method: " + name + "\r\n" + ex.ToString();
            int i = 0;
            while (i < 3)
            {
                if (ex.InnerException == null)
                    break;
                ex = ex.InnerException;
                textMess += "\r\n" + ex.ToString();
                i++;
            }
            MessageBox.Show(textMess, "ProxyManager Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
        
        private void btnEnableProxy_Click(object sender, EventArgs e)
        {
            SetProxyEnabled((sender as Button).Text == "ENABLE PROXY");
        }

        private void txtExceptions_TextChanged(object sender, EventArgs e)
        {
            CurrentProxyExceptions = txtExceptions.Text;
        }
        private void txtProxy_TextChanged(object sender, EventArgs e)
        {
            if (_currentProxy != null)
                _currentProxy._proxy = txtProxy.Text;
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            if (_currentProxy != null)
                _currentProxy._port = txtPort.Text;
        }

        protected class Proxy
        {
            public string _nome { get; set; }
            public string _proxy { get; set; }
            public string _port { get; set; }
            public string _exceptions { get; set; }
            public Proxy()
            {
                _proxy = string.Empty;
                _port = string.Empty;
            }
            public Proxy(string proxyReg)
            {
                _nome = "Initial";
                if (!string.IsNullOrEmpty(proxyReg))
                {
                    string[] proxy = proxyReg.Split(':');
                    if (proxy.Length > 0)
                        this._proxy = proxy[0];
                    if (proxy.Length > 1)
                        this._port = proxy[1];
                }
            }

            public string RealProxy
            {
                get { return _proxy + ":" + _port; }
            }
        }
    }
}
