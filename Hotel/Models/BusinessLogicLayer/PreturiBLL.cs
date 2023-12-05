using Multi_Login.Models.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Login.Models.BusinessLogicLayer
{
    public class PreturiBLL
    {
        public ObservableCollection<Preturi> Preturi { get; set; }
        //public string ErrorMessage { get; set; }

        PreturiDAL preturiDAL = new PreturiDAL();

        public PreturiBLL()
        {
            Preturi = preturiDAL.GetAllPreturi();
        }

        public ObservableCollection<Preturi> GetAllPreturi()
        {
            return preturiDAL.GetAllPreturi();
        }
    }
}
