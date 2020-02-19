using System;

namespace Business
{
    public class Seguro
    {
        public string seguradora { get; set; }
        public DateTime vigencia { get; set; }
        public string cobertura { get; set; }
        

        public override string ToString()
        {
            return "dd-MM-yyyy";
        }

        
    }

    

}
