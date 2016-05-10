using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQOrderEntryServiceInterface;
using System.ServiceModel;

namespace RealTimeOrderTrackingApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CallBackImplementtation callBack = new CallBackImplementtation();
            InstanceContext context = new InstanceContext(callBack);

            ChannelFactory<ISubscribeToOrderTrackingInfo> cf = new DuplexChannelFactory<ISubscribeToOrderTrackingInfo>(context,new NetTcpBinding());
            ISubscribeToOrderTrackingInfo subscriber = cf.CreateChannel(new EndpointAddress("net.tcp://localhost:9875/"));
            subscriber.Subscribe();
        }
    }
}
