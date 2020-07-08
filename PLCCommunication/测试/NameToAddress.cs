using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLCCommunication
{
  public static class NameToAddress
    {
        public static Dictionary<string,string> AddrToName = new Dictionary<string,string>();

        public static void AddAddress(String str, String value)
        {
            if (!AddrToName.ContainsKey(str))
            {
                AddrToName.Add(str, value);
            }
            else
            {
                AddrToName[str] = value;
            }

        }

        public static String AddressDictRead(String mkey)
        {
            if (AddrToName.ContainsKey(mkey))
            {
                return AddrToName[mkey];
            }
            return null;
        }

        public static List<string> GetAddressKeys()
        {
            List<string> Keys = new List<string>();
            if (AddrToName.Count != 0)
            {
                foreach (string key in AddrToName.Keys)
                {
                    Keys.Add(key);
                }
                return Keys;
            }
            return null;

        }
                  
    }
}
