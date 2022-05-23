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
            DataSet set = new DataSet();
            DataTable table = new DataTable();
            DataColumn column =
                 table.Columns.Add("CompanyID", typeof(Int32));
            table.Columns.Add("CompanyName", typeof(string));
            table.Columns.Add("CompanyLocation", typeof(string));
            DataRow row = table.NewRow();
            row[0] = 1;
            row[1] = "company";
            row[2] = "loc";

            table.Rows.Add(row);

            set.Tables.Add(table);

            return set;
        }
    }
}
