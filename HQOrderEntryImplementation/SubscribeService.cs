using HQOrderEntryServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using RealTimeOrderTrackingCallBackContract;

namespace HQOrderEntryImplementation
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class SubscribeService : ISubscribeToOrderTrackingInfo
    {
        List<IOrderTracking> callBacks;

        public SubscribeService() 
        {
            callBacks = new List<IOrderTracking>();
        }

        public void Subscribe()
        {
            Console.WriteLine("**SomeOne Subscribe");
            callBacks.Add(OperationContext.Current.GetCallbackChannel<IOrderTracking>());
        }

        public void UnSubscribe()
        {
            Console.WriteLine("**SomeOne UnSubscribe");
            callBacks.Remove(OperationContext.Current.GetCallbackChannel<IOrderTracking>());
        }

        public void PulishOrderEntrySignal(string countryID) 
        {
            foreach (var item in callBacks)
            {
                item.NewOrderForCountry(countryID);
            }
        }
    }
}
