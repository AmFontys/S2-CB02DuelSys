using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public class ScheduleDALMock : IScheduleDAL
	{
		
        public bool StartTournament(List<string> matches,int tourId)
        {
            if (tourId == 2)
                return true;
            else return false;
        }

        public bool NextRound(List<string> matches,int tourId)
        {
            return false;
        }

        
    }
}
