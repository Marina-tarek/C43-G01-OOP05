using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP05.Q3
{
    internal interface INotificationService
    {
        #region 1-we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
        public void SendNotification(string recipient,string message);

        #endregion

    }
}
