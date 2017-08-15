using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESGIS_Paint.Class_log
{
    class Log
    {
        public static StreamWriter flux = null;

        String separator;
        String file;
        StreamReader _reader;
        StreamWriter write;

        public Log()
        {
            separator = " >>> ";
            file = @"log.txt";

            //When the file does not exists, we create it and write inside it the header
            if (!File.Exists(file))
                writeheader();
        }

        public void openFile()
        {
            //File.OpenRead(file);
            System.Diagnostics.Process.Start(file);

        }

        public void connectionAction()
        {
            String save;
            save = "Paint opened";

            writeIntoFile(save);
        }

        public void printAction(string picturePath)
        {
            String save;
            save = "Pic " + picturePath + " printed ";

            writeIntoFile(save);
        }

        /// Write into log file save action
        /// <param name="picturePath">Path of saved Picture</param>
        public void saveAction(string picturePath)
        {
            String save;
            save = "Pic " + picturePath + " saved ";

            writeIntoFile(save);
        }

        public void disconnectionAction()
        {
            String save;
            save = "Paint closed.";

            writeIntoFile(save);
            Console.WriteLine(" ");
        }

        /// <summary>
        /// Write the title of columns on the header of log file
        /// </summary>
        public void writeheader()
        {
            String header = "DATE      " + " Heure         " + "ACTION";
            String underline = "****      " + " ****         " + "******";
            try
            {
                using (write = new StreamWriter(file, true))
                {
                    write.WriteLine(underline);
                    write.WriteLine(header);
                    write.WriteLine(underline);
                }
            }
            catch (Exception e)
            {
                String error = "Impossible d'écrire dans le fichier : " + e;
                System.Windows.Forms.MessageBox.Show(error);
            }
        }

        private void writeIntoFile(String line)
        {
            DateTime nowTime = DateTime.Now;

            try
            {
                using (write = new StreamWriter(file, true))
                {
                    write.Write(nowTime.ToString() + separator);
                    write.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                String error = "Impossible d'écrire dans le fichier : " + e;
                System.Windows.Forms.MessageBox.Show(error);
            }
        }
    }
}

