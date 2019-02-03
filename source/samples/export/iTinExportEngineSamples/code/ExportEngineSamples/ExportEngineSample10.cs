﻿
namespace iTinExportEngineSamples.ExportEngineSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class ExportEngineSample10
    {
        private const string EpplusHeader = " · Running Sample 10 (From Configuration File)";
        private const string FirstSampleStepText = "  - How to use binded functions";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.InvoiceXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.ExportEngineSample10Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
