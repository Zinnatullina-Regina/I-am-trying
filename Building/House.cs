using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class House
    {

		private Guid guid;
		private long height;
		private long levels;
		private long countFlats;
		private long countEntrances;




		public House(long height, long levels, long countEntrances, long countFlats)
		{
			this.guid = Guid.NewGuid();
			this.levels = levels;
			this.height = height;
			this.countEntrances = countEntrances;
			this.countFlats = countFlats;
		}
		public long GetAvgFlatsOnLevel()
		{
			return GetAvgFlatsInEntarances() / levels;
		}
		public long GetAvgFlatsInEntarances()
		{
			return countFlats / countEntrances;
		}

		public long GetHeightLevel()
		{
			return height / levels;
		}
		public void GetInfo()
		{
			Console.WriteLine(string.Format("Уникальный номер дома : {0}, высота дома : {1}, количество этажей в доме : {2}, количество квартир : {3}, количество подъездов {4}", guid, height, levels, countFlats, countEntrances));
		}

		



	}
}
