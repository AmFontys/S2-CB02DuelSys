using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public class MatchDALMock : IMatchDAL
	{
		
        public bool CreateMatch(int tournamentId, int playerId1, int playerId2)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMatch(int tournamentId,int player,int player2, int score1, int score2)
        {
            if (tournamentId == 1)
            {
                if(player == 1 & player2==3)
                    return true;
            }
            return false;
        }

        public DataSet GetMatches(int tournamentId)
        {
            DataSet set = new DataSet();
            DataTable table = new DataTable();
            DataColumn column =
                 table.Columns.Add("tournamentId", typeof(Int32));
            table.Columns.Add("PlayerId", typeof(Int32));
            table.Columns.Add("PlayerId2", typeof(Int32));
            table.Columns.Add("score", typeof(Int32));
            table.Columns.Add("score2", typeof(Int32));

            table.Columns.Add("Player", typeof(Int32));
            table.Columns.Add("PlayerFName", typeof(string));
            table.Columns.Add("PlayerLName", typeof(string));
            table.Columns.Add("PlayerEmail", typeof(string));
            table.Columns.Add("PlayerTeam", typeof(string));

            table.Columns.Add("Player2", typeof(Int32));
            table.Columns.Add("Player2FName", typeof(string));
            table.Columns.Add("Player2LName", typeof(string));
            table.Columns.Add("Player2Email", typeof(string));
            table.Columns.Add("Player2Team", typeof(string));
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            row[0] = 1;
            row[1] = 10;
            row[2] = 20;
            row[3] = 0;
            row[4] = 0;
            row[5] = 10;
            row[6] = "Bern";
            row[7] = "Shovel";
            row[8] = "bern@gmail.com";
            row[9] = "BernTheBest";
            row[10] = 20;
            row[11] = "Emily";
            row[12] = "Pirt";
            row[13] = "pirt@doc.gov";
            row[14] = "goverment";

            set.Tables.Add(table);

            return set;
        }
    }
}
