namespace VamBlazor.Client.Domain.Entities
{
    public class vwPersonAllTransactions
    {

        public string Pcode { set; get; }
        public string Date { set; get; } = "";
        public long Vam { get; set; }
        public long GstPaid { get; set; }
        public long Pasandaz { get; set; }
        public long Karmozd { get; set; }
        public string FullName { get; set; }
        public int ReqNo { get; set; }
        public long HesabNo { get; set; }
        public string Sharh { get; set; }
        public long ColVamGst { get; set; }
        public long ColPasandaz { get; set; }

    }
}
