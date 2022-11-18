using System.Net;
using System.Net.NetworkInformation;

namespace NetworkHelperProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = MenuPage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sendHttpButtonPage_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = SendHttpRequesrtPage;
        }

        private void CIDRButtonPage_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = FindCIDRPage;
        }

        private void maskFounderButtonPage_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = MaskFounderPage;
        }

        private void subnetButtonPage_Click(object sender, EventArgs e)
        {
            int count = 0,dnsCount;
            tabControl.SelectedTab = NetworkInformationPage;
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();

            foreach (NetworkInterface adapter in nics)
            {
                dnsCount = 1;
                // Only display informatin for interfaces that support IPv4.
                if (adapter.Supports(NetworkInterfaceComponent.IPv4) == false)
                {
                    continue;
                }

                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                // Try to get the IPv4 interface properties.
                IPv4InterfaceProperties p = adapterProperties.GetIPv4Properties();
                if (p == null)
                {
                    networkInfo.Text = "No IPv4 information is available for this interface.";


                }
                else
                {
                    networkInfo.Text +=
                    "\r\n\r\n------ Interface Number " + count++ + " ------\r\n" +
                    "Hostname : " + properties.HostName +
                    "\r\nDomain name : " + properties.DomainName +
                    "\r\nIndex :" + p.Index +
                    "\r\nMTU :" + p.Mtu +
                    "\r\nAPIPA active :" + p.IsAutomaticPrivateAddressingActive +
                    "\r\nAPIPA enabled :" + p.IsAutomaticPrivateAddressingEnabled +
                    "\r\nForwarding enabled : " + p.IsAutomaticPrivateAddressingEnabled +
                    "\r\nUses WINS :" + p.UsesWins +
                    "\r\nInterface type :" + adapter.NetworkInterfaceType +
                    "\r\nPhysical Address :" + adapter.GetPhysicalAddress().ToString() +
                    "\r\nIs receive only :" + adapter.IsReceiveOnly +
                    "\r\nMulticast :" + adapter.SupportsMulticast + "\r\n";
                   
                    IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
                    if (dnsServers.Count > 0)
                    {
                       
                        foreach (IPAddress dns in dnsServers)
                        {
                            networkInfo.Text += dnsCount++ + ".DNS Server : " + dns.ToString() + "\r\n";
                           
                        }
                       
                    }
                }



            }
        }

        private void pingHimButtonPage_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = PingHimPage;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[]? cleanedMask = NetworkCalculation.IpToArray(IP_ToCIDR.Text);
            int cidrCount = 0;
            CIDR_result_label.Visible = true;
            if(cleanedMask != null && cleanedMask.Length == 4)
            {
                for(int i = 0; i < cleanedMask.Length; i++)
                {
                 cidrCount += NetworkCalculation.countCIDR(NetworkCalculation.toBinary(cleanedMask[i]));
                }
                
                resultCIDR.Text = cidrCount.ToString();
            }
            else
            {
                resultCIDR.Text = "Wrong mask";
            }
        }

        private void MenuPage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectedTab = MenuPage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ping p = new Ping();
            PingReply r;
            string s;
            s = AdressToPing.Text;
            if(s.Length == 0 || s == null)
            {
                PingHimResult.Text = "The adress area is empty...";
            }
            else
            {
                try
                {
                r = p.Send(s);
           
                PingHimResult.Text = "Ping to " + s.ToString() + "[" + r.Address.ToString() + "] \n" + " Successful"
                   + "Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
           
                }
                catch(Exception)
                {

                PingHimResult.Text = "Something gone wrong...";
            
                }
            
            
            }
           

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = MenuPage;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            result_label_maskFounder.Visible = true;
            if (NetworkCalculation.ParseToIpAddress(ipToFindMask.Text) != null)
            {
                resultMaskFound.Text = NetworkCalculation.ReturnSubnetmask(ipToFindMask.Text);
            }
            else
            {
                resultMaskFound.Text = "Wrong ip";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = MenuPage;
        }

        private void NetworkInformationPage_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectedTab = MenuPage;
            networkInfo.Text = "";
        }
    }
}