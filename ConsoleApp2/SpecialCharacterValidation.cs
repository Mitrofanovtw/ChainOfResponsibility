using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SpecialCharacterValidation : Validator
    {
        public override bool Validate (string data)
        {
            if (!data.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
            {
                Console.WriteLine("Ошибка: Данные должны содержать хотя бы один специальный символ (например, !@#$%^&*()).");
                return false;
            }
            return NextValidator?.Validate(data) ?? true;
        }
    }
}
