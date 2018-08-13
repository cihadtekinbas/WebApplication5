using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Kapı
    {
        public int Id { get; set; }
        public int MahalleKodu { get; set; }
        public string Koordinatlar { get; set; }
    }
}