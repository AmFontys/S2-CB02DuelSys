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
            foreach(DataRow d in data.Tables[0].Rows)
            {
                companyies.Add(new company(Convert.ToInt32( d[0]),Convert.ToString( d[1]), Convert.ToString(d[2])));
            }
            return companyies;
        }
    }
}
