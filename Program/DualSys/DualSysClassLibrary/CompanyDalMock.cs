using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelSysClassLibrary
{
    public class CompanyDalMock : ICompanyDAL
    {
        public DataSet GetAllCompanys()
        {
            return new DataSet();
        }
    }
}
