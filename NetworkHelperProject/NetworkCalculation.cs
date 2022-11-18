using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetworkHelperProject
{
    internal class NetworkCalculation
    {
        public static string toBinary(int dec)
        {

            return Convert.ToString(dec, 2);
        }
        public static int toDecimal(string bin)
        {
           return Convert.ToInt32(bin, 2);
        }
        public static int countCIDR(string binValue)
        {
            int count=0;
            for(int i = 0; i < binValue.Length; i++)
            {
                if(binValue[i] == '1')
                {
                    count++;   
                }
            }
            return count;
        }
        public static int[]? IpToArray(string ip)
        {
            bool isValid = (ip.Replace(".","")).All(char.IsDigit) && ip.Length > 0;
            return isValid ? Array.ConvertAll(ip.Split('.'), int.Parse) : null;
        }
        public static IPAddress? ParseToIpAddress(string ipAddress)
        {
            IPAddress? address = null;
            try
            {
               address = IPAddress.Parse(ipAddress);
            }catch (Exception){}
            return address;
        }
        static public string ReturnSubnetmask(String ipaddress)
     {
        uint firstOctet = ReturnFirtsOctet(ipaddress);
        if (firstOctet >= 0 && firstOctet <= 127)
            return "255.0.0.0";
        else if (firstOctet >= 128 && firstOctet <= 191)
            return "255.255.0.0";
        else if (firstOctet >= 192 && firstOctet <= 223)
            return "255.255.255.0";
        else return "0.0.0.0";
     }
   
     static public uint ReturnFirtsOctet(string ipAddress)
     {
         System.Net.IPAddress iPAddress = System.Net.IPAddress.Parse(ipAddress);
         byte[] byteIP = iPAddress.GetAddressBytes();
         uint ipInUint = (uint)byteIP[0];     
         return ipInUint;
     }
    }
}
