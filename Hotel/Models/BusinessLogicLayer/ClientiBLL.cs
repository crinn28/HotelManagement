using Multi_Login.Models.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Login.Models.BusinessLogicLayer
{
    public class ClientiBLL
    {
        public ObservableCollection<Clienti> Clienti { get; set; }
        //public string ErrorMessage { get; set; }

        ClientiDAL clientiDAL = new ClientiDAL();

        public ClientiBLL()
        {
            Clienti = clientiDAL.GetAllClienti();
        }

        public ObservableCollection<Clienti> GetAllClienti()
        {
            return clientiDAL.GetAllClienti();
        }
    }
}
