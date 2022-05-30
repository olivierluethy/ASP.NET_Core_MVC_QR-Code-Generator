using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_QR_Code_Generator.Models
{
    public class QRCodeModel
    {
        [Display(Name = "Enter QRCode Text")]
        public string QRCodeText { get; set; }
    }
}
