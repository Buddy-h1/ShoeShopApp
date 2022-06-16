using System;
using System.IO;

namespace ShoeShopApp
{
    static class ReportNumbersManager
    {

       static private bool CheckFile(int numberLine)
       {
            if (File.Exists("standartReportNumber.txt") == false)
            {
                string[] newLines = new string[numberLine];
                for (int i = 0; i < newLines.Length; i++)
                {
                    newLines[i] = "1";
                }
                File.WriteAllLines("standartReportNumber.txt", newLines);
                return false;
            }
            return true;
        } 
       static public int GetReportNumber(int numberLine)
        {
            if (!CheckFile(numberLine)) return 1;
            var lines = File.ReadAllLines("standartReportNumber.txt");

            if (lines.Length < numberLine)
            {
                string[] newLines = new string[numberLine];
                for (int i = 0; i < lines.Length; i++)
                {
                    newLines[i] = lines[i];
                }
                for (int i = lines.Length; i < numberLine; i++)
                {
                    newLines[i] = "1";
                }
                File.WriteAllLines("standartReportNumber.txt", newLines);
                return Int32.Parse(newLines[numberLine - 1]);
            }

            return Int32.Parse(lines[numberLine - 1]);
        }

        static public void NextReportNumber(int numberLine)
        {
            if (!CheckFile(numberLine)) NextReportNumber(numberLine);
            var lines = File.ReadAllLines("standartReportNumber.txt");

            if (lines.Length < numberLine)
            {
                string[] newLines = new string[numberLine];
                for (int i = 0; i < lines.Length; i++)
                {
                    newLines[i] = lines[i];
                }
                for (int i = lines.Length; i < numberLine; i++)
                {
                    newLines[i] = "1";
                }
                File.WriteAllLines("standartReportNumber.txt", newLines);

                newLines[numberLine - 1] = (Int32.Parse(newLines[numberLine - 1]) + 1).ToString();
                File.WriteAllLines("standartReportNumber.txt", newLines);
            }

            lines[numberLine - 1] = (Int32.Parse(lines[numberLine - 1]) + 1).ToString();
            File.WriteAllLines("standartReportNumber.txt", lines);
        }
    }
}
