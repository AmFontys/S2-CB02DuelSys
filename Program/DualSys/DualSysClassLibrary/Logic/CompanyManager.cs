using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelSysClassLibrary
{
    public class CompanyManager
    {
        private static ICompanyDAL _dal;
        public CompanyManager(ICompanyDAL dal)
        {
            _dal = dal;
        }

        public List<company> GetCompanys()
        {
            DataSet data = _dal.GetAllCompanys();
            List<company> companyies = new List<company>();
            if (data.Tables.Count > 0)//This checks if data is not empty
            {
                //gets all the info from a single row from the variable data
                //then it makes an instance of the company class and adds it to the list
                //The manner where the info is read in is id, name and then location
                foreach (DataRow d in data.Tables[0].Rows)
                {
                    companyies.Add(new company(Convert.ToInt32(d[0]), Convert.ToString(d[1]), Convert.ToString(d[2])));
                }
            }
            return companyies;
        }
    }
}
