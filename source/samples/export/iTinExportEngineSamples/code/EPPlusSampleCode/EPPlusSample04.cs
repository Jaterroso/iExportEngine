﻿
namespace iTinExportEngineSamples.EPPlusSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class EPPlusSample04
    {
        private const string EpplusHeader = " · Running sample 4 (From Configuration File)";
        private const string FirstSampleStepText   = "  - Use Charts With More Than One Chart Type And Secondary Axis";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.StockProducts, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.Sample04Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
