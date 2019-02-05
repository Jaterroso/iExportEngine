﻿
namespace iTinExportEngineSamples.ExportEngineSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;

    using Properties;

    public class ExportEngineSample01
    {
        private const string EpplusHeader = " · Running Sample 1 (From Configuration File)";
        private const string FirstSampleStepText = "  - Equals to EPPlus sample 1 with an image banner with effects and custom data table location";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromConfigurationFileSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.InventoryXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configuration = new Uri(Settings.Default.ExportEngineSample01Configuration, UriKind.Relative);
            input.Export(ExportSettings.ImportFrom(configuration));
        }
    }
}
