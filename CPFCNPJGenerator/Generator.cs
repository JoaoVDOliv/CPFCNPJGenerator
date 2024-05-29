using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPFCNPJGenerator
{
    public class Generator
    {
        bool docType {  get; set; }

        Random random;

        public Generator (bool _docType)
        {
            this.docType = _docType;
            
            random = new Random ();
        }

        public string process()
        {
            string ret = null;
                
            if (this.docType)
            {
                return this.generateCPF();
            }

            return ret;
        }

        protected string generateCPF()
        {
            string cpf = "";
            
            for (int i = 1; i <= 11; i++)
            {
                cpf = cpf + random.Next(10).ToString();                
            }

            return cpf;
        }
    }
}
