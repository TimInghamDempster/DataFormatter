using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFormatter
{
	class Program
	{
		public static string folder;

		static void Main(string[] args)
		{
			if(args.Count() != 1)
			{
				return;
			}

			folder = args[0];

			List<OutputFile> outputFiles = new List<OutputFile>();

			outputFiles.Add(new OutputFile("FormattedCC20hrAF001.csv", new List<InputFile>()
												 { new InputFile("20hrCC_001af_run1.csv"),
                                                     new InputFile("20hrCC_001af_run2.csv"),
                                                     new InputFile("20hrCC_001af_run3.csv"),
                                                     new InputFile("20hrCC_001af_run4.csv"),
                                                     new InputFile("20hrCC_001af_run5.csv"),
                                                     new InputFile("20hrCC_001af_run6.csv"),
                                                     new InputFile("20hrCC_001af_run7.csv"),
                                                     new InputFile("20hrCC_001af_run8.csv"),
                                                     new InputFile("20hrCC_001af_run9.csv"),
													 new InputFile("20hrCC_001af_run10.csv") }));

			outputFiles.Add(new OutputFile("FormattedCC25hrAF001.csv", new List<InputFile>()
												 { new InputFile("25hrCC_001af_run1.csv"),
													new InputFile("25hrCC_001af_run2.csv"),
													new InputFile("25hrCC_001af_run3.csv"),
													new InputFile("25hrCC_001af_run4.csv"),
													new InputFile("25hrCC_001af_run5.csv"),
													new InputFile("25hrCC_001af_run6.csv"),
													new InputFile("25hrCC_001af_run7.csv"),
													new InputFile("25hrCC_001af_run8.csv"),
													new InputFile("25hrCC_001af_run9.csv"),
													new InputFile("25hrCC_001af_run10.csv") }));

			outputFiles.Add(new OutputFile("FormattedCC30hrAF001.csv", new List<InputFile>()
												 { new InputFile("30hrCC_001af_run1.csv"),
													new InputFile("30hrCC_001af_run2.csv"),
													new InputFile("30hrCC_001af_run3.csv"),
													new InputFile("30hrCC_001af_run4.csv"),
													new InputFile("30hrCC_001af_run5.csv"),
													new InputFile("30hrCC_001af_run6.csv"),
													new InputFile("30hrCC_001af_run7.csv"),
													new InputFile("30hrCC_001af_run8.csv"),
													new InputFile("30hrCC_001af_run9.csv"),
													new InputFile("30hrCC_001af_run10.csv") }));

			outputFiles.Add(new OutputFile("FormattedCC35hrAF001.csv", new List<InputFile>()
												 { new InputFile("35hrCC_001af_run1.csv"),
													new InputFile("35hrCC_001af_run2.csv"),
													new InputFile("35hrCC_001af_run3.csv"),
													new InputFile("35hrCC_001af_run4.csv"),
													new InputFile("35hrCC_001af_run5.csv"),
													new InputFile("35hrCC_001af_run6.csv"),
													new InputFile("35hrCC_001af_run7.csv"),
													new InputFile("35hrCC_001af_run8.csv"),
													new InputFile("35hrCC_001af_run9.csv"),
													new InputFile("35hrCC_001af_run10.csv") }));

			outputFiles.Add(new OutputFile("FormattedCC40hrAF001.csv", new List<InputFile>()
												 { new InputFile("40hrCC_001af_run1.csv"),
													new InputFile("40hrCC_001af_run2.csv"),
													new InputFile("40hrCC_001af_run3.csv"),
													new InputFile("40hrCC_001af_run4.csv"),
													new InputFile("40hrCC_001af_run5.csv"),
													new InputFile("40hrCC_001af_run6.csv"),
													new InputFile("40hrCC_001af_run7.csv"),
													new InputFile("40hrCC_001af_run8.csv"),
													new InputFile("40hrCC_001af_run9.csv"),
													new InputFile("40hrCC_001af_run10.csv") }));

			outputFiles.Add(new OutputFile("FormattedCC30hrAF01.csv", new List<InputFile>()
												 { new InputFile("30hrCC_01af_run1.csv"),
													new InputFile("30hrCC_01af_run2.csv"),
													new InputFile("30hrCC_01af_run3.csv"),
													new InputFile("30hrCC_01af_run4.csv"),
													new InputFile("30hrCC_01af_run5.csv"),
													new InputFile("30hrCC_01af_run6.csv"),
													new InputFile("30hrCC_01af_run7.csv"),
													new InputFile("30hrCC_01af_run8.csv"),
													new InputFile("30hrCC_01af_run9.csv"),
													new InputFile("30hrCC_01af_run10.csv") }));

			outputFiles.Add(new OutputFile("FormattedCC30hrAF0001.csv", new List<InputFile>()
												 { new InputFile("30hrCC_0001af_run1.csv"),
													new InputFile("30hrCC_0001af_run2.csv"),
													new InputFile("30hrCC_0001af_run3.csv"),
													new InputFile("30hrCC_0001af_run4.csv"),
													new InputFile("30hrCC_0001af_run5.csv"),
													new InputFile("30hrCC_0001af_run6.csv"),
													new InputFile("30hrCC_0001af_run7.csv"),
													new InputFile("30hrCC_0001af_run8.csv"),
													new InputFile("30hrCC_0001af_run9.csv"),
													new InputFile("30hrCC_0001af_run10.csv") }));
		}
	}
}
