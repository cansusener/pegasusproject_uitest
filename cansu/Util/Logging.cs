﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using log4net.Repository;

namespace BDD.Util
{
    public static class Logging
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void Logger()
        {
            try
            {

                ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetEntryAssembly());

                var fileInfo = new FileInfo(AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin")) + @"log4net.config");
                Console.WriteLine("Dosya path'i: " + fileInfo.DirectoryName);

                log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
                Console.WriteLine("Yükleme işlemi tamamlandı...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata mevcut");
                throw ex;
            }
        }
    }
}
