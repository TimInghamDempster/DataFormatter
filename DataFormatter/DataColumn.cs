using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFormatter
{
	class DataColumn
	{
		string m_columnName;
		List<float> m_data;

        public string Name { get { return m_columnName; } }
        public int Count { get { return m_data.Count; } }

        public object this[int i] { get { return m_data[i]; } }

        public DataColumn(string name)
        {
            m_columnName = name;
            m_data = new List<float>();
        }

        public void AddDatum(float datum)
        {
            m_data.Add(datum);
        }
	}
}
