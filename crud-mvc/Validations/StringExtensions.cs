using System.Text.RegularExpressions;

namespace crud_mvc.Validations
{
    public static class StringExtensions
    {
        public static bool IsValidCPF(this string CPF)
        {

            var patternCpf = "[0-9]{3}\\.?[0-9]{3}\\.?[0-9]{3}\\-?[0-9]{2}";

            return Regex.Match(CPF,patternCpf).Success;    
        }
        public static bool IsValidRG(this string RG) 
        {
            var patternRg = "[0-9]{2}\\.?[0-9]{3}\\.?[0-9]{3}\\-?[0-9]{2}";

            return Regex.Match(RG,patternRg).Success;
        }
        public static bool IsValidCEP(this string CEP) 
        {
            var patternCep = "[0-9]{5}\\-?[0-9]{2}";
            return Regex.Match(CEP, patternCep).Success;
            
        }
       
    }
}