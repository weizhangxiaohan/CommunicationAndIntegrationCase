using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace HQLocalizationService
{
    [ServiceContract]
    public interface ITranslateProductDescriptions
    {
        [OperationContract]
        [WebGet(UriTemplate = @"/{languageCode}/{productID}")]
        string GetProductDescription(string productID,string languageCode);
    }
}
