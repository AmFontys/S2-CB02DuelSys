using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary
{
	public class SportManager
	{
		private ISportDAL _dal;
		public SportManager(ISportDAL dal)
		{
			_dal = dal;
		}

		public List<Sport> GetSports()
		{
			DataSet data = _dal.GetSports();
			if(data != null) { 
				List<Sport> list = new List<Sport>();
                foreach (DataRow item in data.Tables[0].Rows)
                {
					if (item[3] != null)
						list.Add(new Sport((int)item[0], (string)item[1], (string)item[2]));//the instance of the sport class with only one win condition
					else
						list.Add(new Sport((int)item[0], (string)item[1], (string)item[2], (string)item[3], (string)item[4]));//the instance of the sport class with all three conditions
				}
				return list;

			}
			else return null;
		}
	}
}
