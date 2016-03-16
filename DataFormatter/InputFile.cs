using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFormatter
{
	class InputFile
	{
		string m_filename;
		List<DataColumn> m_columns;
        List<DataColumn> m_activeColumns;

        public List<DataColumn> Columns { get { return m_columns; } }

		public InputFile(string filename)
		{
			m_filename = filename;

            m_columns = new List<DataColumn>();
            m_activeColumns = new List<DataColumn>();

			ReadFile();
		}


		void ReadFile()
		{
			System.IO.StreamReader reader = new System.IO.StreamReader(Program.folder + "/" + m_filename);

            while (!reader.EndOfStream)
            {
                List<string> row = reader.ReadLine().Split(',').ToList();
                row.RemoveAll((s) => s =="");

                if (row.Count > 0)
                {
                    float temp;
                    bool isNum = float.TryParse(row[0], out temp);

                    if (isNum)
                    {
                        DoDataLine(row);
                    }
                    else
                    {
                        DoColumnLine(row);
                    }
                }
            }
		}

        void DoDataLine(List<string> row)
        {
            if (row.Count() != m_activeColumns.Count)
            {
                throw new Exception("Data file in invalid format");
            }
            else
            {
                for (int i = 0; i < row.Count(); i++)
                {
                    float datum;
                    bool success = float.TryParse(row[i], out datum);

                    if (!success)
                    {
                        throw new Exception("Non-number in data row");
                    }

                    m_activeColumns[i].AddDatum(datum);
                }
            }
        }

        void DoColumnLine(List<string> row)
        {
            m_activeColumns.Clear();

            foreach (string colName in row)
            {
                bool found = false;

                foreach (DataColumn col in m_columns)
                {
                    if (col.Name == colName)
                    {
                        found = true;
                        m_activeColumns.Add(col);
                        break;
                    }
                }

                if (!found)
                {
                    DataColumn col = new DataColumn(colName);
                    m_columns.Add(col);
                    m_activeColumns.Add(col);
                }
            }
        }
	}
}
