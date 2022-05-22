using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelSysClassLibrary
{
    public class CompanyDAL : ICompanyDAL
    {
        public DataSet GetAllCompanys()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from `ds_company`";
            return DBExecuter.ExecuteReader(command);
        }
    }
}
