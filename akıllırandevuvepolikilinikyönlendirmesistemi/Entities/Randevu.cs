using System;
using System.Collections.Generic;
using System.Text;

namespace akıllırandevuvepolikilinikyönlendirmesistemi.Entities
{
    internal class Randevu
    {
        public int RandevuId { get; set; }
        public int HastaId { get; set; }
        public int DoktorId { get; set; }
        public DateTime TarihSaat { get; set; }
        public string Durum { get; set; }
    }
}
