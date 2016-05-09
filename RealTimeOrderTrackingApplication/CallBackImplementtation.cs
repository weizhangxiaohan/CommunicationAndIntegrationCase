using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealTimeOrderTrackingCallBackContract;
using System.Windows.Forms;

namespace RealTimeOrderTrackingApplication
{
    public class CallBackImplementtation : IOrderTracking
    {
        Dictionary<string, int> NumberOfOrderEntries;

        public CallBackImplementtation() 
        {
            NumberOfOrderEntries = new Dictionary<string, int>();
        }

        public void NewOrderForCountry(string countryID)
        {
            MessageBox.Show(countryID);
        }
    }
}
