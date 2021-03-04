﻿using System;
using System.IO;
using System.Text;
using POCOGenerator;

namespace TextWriterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes = null;
            GeneratorResults results = GeneratorResults.None;
            using (MemoryStream stream = new MemoryStream())
            {
                using (TextWriter textWriter = new StreamWriter(stream))
                {
                    IGenerator generator = GeneratorFactory.GetGenerator(textWriter);
                    generator.Settings.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=AdventureWorks2014;Integrated Security=True";
                    generator.Settings.RDBMS = RDBMS.SQLServer;
                    generator.Settings.Tables.IncludeAll = true;
                    generator.Settings.POCO.CommentsWithoutNull = true;
                    generator.Settings.ClassName.IncludeSchema = true;
                    generator.Settings.ClassName.SchemaSeparator = "_";
                    generator.Settings.ClassName.IgnoreDboSchema = true;

                    results = generator.Generate();
                    PrintError(results, generator.Error);
                }

                bytes = stream.ToArray();
            }

            if (results == GeneratorResults.None)
            {
                string str = Encoding.ASCII.GetString(bytes);
                Console.WriteLine(str);
            }
        }

        private static void PrintError(GeneratorResults results, Exception Error)
        {
            bool isError = (results & GeneratorResults.Error) == GeneratorResults.Error;
            bool isWarning = (results & GeneratorResults.Warning) == GeneratorResults.Warning;

            if (isError)
                Console.WriteLine("Error Result: {0}", results);
            else if (isWarning)
                Console.WriteLine("Warning Result: {0}", results);

            if (Error != null)
            {
                Console.WriteLine("Error: {0}", Error.Message);
                Console.WriteLine("Error Stack Trace:");
                Console.WriteLine(Error.StackTrace);
            }
        }
    }
}
