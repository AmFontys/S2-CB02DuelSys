using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public class TournamentDALMock : ITournamentDAL
	{
		
        public bool CreateTournament(Tournament tournament)
        {
            return true;
        }

        public bool UpdateTournament(Tournament tournament)
        {
            if (tournament.getID() == 1)
                return true;
            else return false;
        }

        public bool DeleteTournament(int id)
        {
            if (id == 5)
                return true;
            else return false;
        }

        public DataSet GetTournaments(string status)
        {
            if(status== "Avaible" || status=="On going")
            {
                DataSet data = new DataSet();
                DataTable table = new DataTable();
                DataColumn column =
                    table.Columns.Add("TournamentID", typeof(int));
                    table.Columns.Add("SportTempId", typeof(int));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Description", typeof(string));
                table.Columns.Add("Min", typeof(int));
                table.Columns.Add("Max", typeof(int));
                table.Columns.Add("Start", typeof(DateTime));
                table.Columns.Add("End", typeof(DateTime));
                table.Columns.Add("Status", typeof(string));
                table.Columns.Add("SportID", typeof(int));
                table.Columns.Add("SportName", typeof(string));
                table.Columns.Add("win", typeof(string));

                DataRow row = table.NewRow();
                row[0] = 1;
                row[2] = "tour";
                row[3] = "description";
                row[4] = 2;
                row[5] = 8;
                row[6] = DateTime.UtcNow.AddDays(10);
                row[7] = DateTime.UtcNow.AddDays(12);
                row[8] = "Avaible";
                row[9] = 2;
                row[10] = "Sport";
                row[11] = "0-2";   
                table.Rows.Add(row);
                data.Tables.Add(table);
                return data;
            }
            else return new DataSet();
        }

        public DataSet GetTournament(string name)
        {
            throw new NotImplementedException();
        }

        public DataSet GetTournament(int id)
        {
            if (id==1)
            {
                DataSet data = new DataSet();
                DataTable table = new DataTable();
                DataColumn column =
                    table.Columns.Add("TournamentID", typeof(int));
                table.Columns.Add("SportTempId", typeof(int));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Description", typeof(string));
                table.Columns.Add("Min", typeof(int));
                table.Columns.Add("Max", typeof(int));
                table.Columns.Add("Start", typeof(DateTime));
                table.Columns.Add("End", typeof(DateTime));
                table.Columns.Add("Status", typeof(string));
                table.Columns.Add("SportID", typeof(int));
                table.Columns.Add("SportName", typeof(string));
                table.Columns.Add("win", typeof(string));

                DataRow row = table.NewRow();
                row[0] = 1;
                row[2] = "tour";
                row[3] = "description";
                row[4] = 2;
                row[5] = 8;
                row[6] = DateTime.UtcNow.AddDays(10);
                row[7] = DateTime.UtcNow.AddDays(12);
                row[8] = "Avaible";
                row[9] = 2;
                row[10] = "Sport";
                row[11] = "0-2";
                table.Rows.Add(row);
                data.Tables.Add(table);
                return data;
            }
            else return new DataSet();            
        }
    }
}
