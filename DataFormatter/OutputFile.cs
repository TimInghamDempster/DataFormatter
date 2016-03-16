using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFormatter
{
	class OutputFile
	{
		string m_filename;
		List<InputFile> m_inputFiles;

		public OutputFile(string filename, List<InputFile> inputFiles)
		{
			m_filename = filename;
			m_inputFiles = inputFiles;

            System.IO.StreamWriter writer = new System.IO.StreamWriter(Program.folder + "/" + filename);

            WriteHeader(writer);
            WriteData(writer);

            writer.Close();
        }

        public void WriteHeader(System.IO.StreamWriter writer)
        {
            for (int colId = 0; colId < m_inputFiles[0].Columns.Count(); colId++)
            {
                writer.Write(m_inputFiles[0].Columns[colId].Name + ",");

                for (int runId = 1; runId < m_inputFiles.Count; runId++)
                {
                    writer.Write(',');
                }

                writer.Write(",,,,");
            }
            writer.Write("\n");
		}

        public void WriteData(System.IO.StreamWriter writer)
        {
            int maxRow = 0;
            for (int colId = 0; colId < m_inputFiles[0].Columns.Count(); colId++)
            {
                for (int runId = 0; runId < m_inputFiles.Count; runId++)
                {
                    maxRow = Math.Max(maxRow, m_inputFiles[runId].Columns[colId].Count);
                }
            }

            for (int rowId = 0; rowId < maxRow; rowId++)
            {
                for (int colId = 0; colId < m_inputFiles[0].Columns.Count(); colId++)
                {
                    for (int runId = 0; runId < m_inputFiles.Count; runId++)
                    {
                        DataColumn col = m_inputFiles[runId].Columns[colId];
                        if (col.Count > rowId)
                        {
                            writer.Write(col[rowId]);
                            writer.Write(',');
                        }
                        else
                        {
                            writer.Write(',');
                        }
                    }
                    writer.Write(",,,,");
                }
                writer.Write("\n");
            }
        }
	}
}
