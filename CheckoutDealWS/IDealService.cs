using CheckoutDealDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CheckoutDealWS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDealService" in both code and config file together.
    [ServiceContract]
    public interface IDealService
    {
        [OperationContract]
        List<User> GetUsers();
        
        [OperationContract]
        User GetUser(int userid);

        
    }
}
