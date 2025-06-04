using System.ComponentModel.DataAnnotations.Schema;
using VamBlazor.Client.Application.CommonFunc;

namespace VamBlazor.Client.Application.Dtos
{
    public class AccountInfoDto
    {
        public string? Pcode { get; set; }
        public long? HesabNo { get; set; }
        public long? Moaref { get; set; }
        public string? FullName { set; get; }
        public string? CityDesc { set; get; }  
        public string? PictureAddress { get; set; }
        public string? StartDate { set; get; }  
        public long? LastMojodi { set; get; }
        public string? LastReqDate { set; get; }
        public int? LastReqNo { get; set; }
        public long LastMblgVam { set; get; }
        public long? LastRemain {  set; get; }  
        
    }
}
