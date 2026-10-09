using System;
using System.Collections.Generic;
using System.Text;

namespace akıllırandevuvepolikilinikyönlendirmesistemi.Entities
{
    internal class Doktor
    {
        public int DoktorId { get; set; }
        public int BolumId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
