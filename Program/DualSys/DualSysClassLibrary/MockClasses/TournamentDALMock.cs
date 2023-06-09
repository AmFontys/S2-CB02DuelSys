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

        public bool UpdateTournament(int id, string status)
        {
            if (id == 1)
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
            if(status== "Available" || status=="On going")
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
                table.Columns.Add("win2", typeof(string));
                table.Columns.Add("win3", typeof(string));

                DataRow row = table.NewRow();
                row[0] = 1;
                row[2] = "tour";
                row[3] = "description";
                row[4] = 2;
                row[5] = 8;
                row[6] = DateTime.UtcNow.AddDays(10);
                row[7] = DateTime.UtcNow.AddDays(12);
                row[8] = "Available";
                row[9] = 2;
                row[10] = "Sport";
                row[11] = "0-2";   
                row[12] = "0-2";   
                row[13] = "20";   
                table.Rows.Add(row);
                data.Tables.Add(table);
                return data;
            }
            else if (status == "Finsished")
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
                table.Columns.Add("win2", typeof(string));
                table.Columns.Add("win3", typeof(string));

                DataRow row = table.NewRow();
                row[0] = 1;
                row[2] = "tour";
                row[3] = "description";
                row[4] = 2;
                row[5] = 8;
                row[6] = DateTime.UtcNow.AddDays(10);
                row[7] = DateTime.UtcNow.AddDays(12);
                row[8] = "Available";
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
                table.Columns.Add("win2", typeof(string));
                table.Columns.Add("win3", typeof(string));

                DataRow row = table.NewRow();
                row[0] = 1;
                row[2] = "tour";
                row[3] = "description";
                row[4] = 2;
                row[5] = 8;
                row[6] = DateTime.UtcNow.AddDays(10);
                row[7] = DateTime.UtcNow.AddDays(12);
                row[8] = "Available";
                row[9] = 2;
                row[10] = "Sport";
                row[11] = "0-2";
                row[12] = "0-2";
                row[13] = "2";
                table.Rows.Add(row);
                data.Tables.Add(table);
                return data;
            }
            else if (id==2)
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
                table.Columns.Add("win2", typeof(string));
                table.Columns.Add("win3", typeof(string));

                DataRow row = table.NewRow();
                row[0] = 1;
                row[2] = "tour";
                row[3] = "description";
                row[4] = 2;
                row[5] = 8;
                row[6] = DateTime.UtcNow.AddDays(10);
                row[7] = DateTime.UtcNow.AddDays(12);
                row[8] = "Available";
                row[9] = 2;
                row[10] = "Sport";
                row[11] = "0-2";
                table.Rows.Add(row);
                data.Tables.Add(table);
                return data;
            }
            else return new DataSet();            
        }

        public DataSet GetSignUps(int tourId)
        {
            DataSet set = new DataSet();
            if (tourId == 1)
            {
                DataTable table = new DataTable();
                DataColumn column =
                    table.Columns.Add("PlayerID", typeof(int));
                for (int i = 1; i < 10; i++)
                {
                    DataRow row = table.NewRow();
                    row[0] = i;
                    table.Rows.Add(row);
                }
                set.Tables.Add(table);

            }
            return set;
        }
    }
}
