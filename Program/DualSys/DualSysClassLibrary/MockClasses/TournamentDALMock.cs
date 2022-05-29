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
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "INSERT INTO `ds_tournament`" +
                "(`sportID`, `tournamentName`, `tournamentDescription`, `minPlayer`," +
                " `maxPlayer`, `startDate`, `endDate`, `status`)" +
                " VALUES (@sportId,@name,@descr,@min,@max,@start,@end,@status) ";
            command.Parameters.AddWithValue("@sportId",tournament.getSport().getID());
            command.Parameters.AddWithValue("@name",tournament.getTournamentName());
            command.Parameters.AddWithValue("@descr",tournament.getTournamentDescription());
            command.Parameters.AddWithValue("@min",tournament.getMinPlayers());
            command.Parameters.AddWithValue("@max",tournament.getMaxPlayers());
            command.Parameters.AddWithValue("@start",tournament.getStartDate());
            command.Parameters.AddWithValue("@end",tournament.getEndDate());
            command.Parameters.AddWithValue("@status", "Avaible");

            return true;
        }

        public bool UpdateTournament(Tournament tournament)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "UPDATE `ds_tournament` SET" +
                "`tournamentName`=@name, `tournamentDescription`=@descr, `minPlayer`=@min," +
                " `maxPlayer`=@max, `startDate`=@start, `endDate`=@end, `status`=@status " +
                "where tournamentID=@tourId";
            command.Parameters.AddWithValue("@tourId", tournament.getID());
            command.Parameters.AddWithValue("@name", tournament.getTournamentName());
            command.Parameters.AddWithValue("@descr", tournament.getTournamentDescription());
            command.Parameters.AddWithValue("@min", tournament.getMinPlayers());
            command.Parameters.AddWithValue("@max", tournament.getMaxPlayers());
            command.Parameters.AddWithValue("@start", tournament.getStartDate());
            command.Parameters.AddWithValue("@end", tournament.getEndDate());
            command.Parameters.AddWithValue("@status", tournament.getStatus());

            return true;
        }

        public bool DeleteTournament(int id)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE FROM `ds_tournament` where tournamentId=@id;" +
                "DELETE FROM ds_match where tournamentId=@id;" +
                "DELETE FROM ds_signup where tournamentId=@id;";
            command.Parameters.AddWithValue("@id", id);
            return true;
        }

        public DataSet GetTournaments(string status)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select t.*,s.* from ds_tournament as t LEFT JOIN ds_sport as s ON t.sportID=s.sportID  where t.status=@status";
            command.Parameters.AddWithValue("@status", status);
            
            return new DataSet();
        }

        public DataSet GetTournament(string name)
        {
            throw new NotImplementedException();
        }

        public DataSet GetTournament(int id)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select t.*,s.* from ds_tournament as t LEFT JOIN ds_sport as s ON t.sportID=s.sportID  where t.tournamentID=@id";
            command.Parameters.AddWithValue("@id", id);
            return new DataSet();
        }
    }
}
