using System.Diagnostics;

public class PrintService
{
    public void PrintPdf(string pdfFilePath)
    {
        Process.Start("AcroRd32.exe", $"/t \"{pdfFilePath}\"");
    }
}
