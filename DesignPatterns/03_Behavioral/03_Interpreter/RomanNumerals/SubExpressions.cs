namespace DesignPatterns._03_Behavioral._03_Interpreter.RomanNumerals
{
    public class OneExp : Expression
    {
        // One checks for I, II, III, IV, V, VI, VI, VII, VIII, IX
        public override string One()
        {
            return "I";
        }

        public override string Four()
        {
            return "IV";
        }

        public override string Five()
        {
            return "V";
        }

        public override string Nine()
        {
            return "IX";
        }

        public override int Multiplier()
        {
            return 1;
        }
    }
    
    public class TenExp : Expression
    {
        // Ten checks for X, XL, L and XC
        public override string One()
        {
            return "X";
        }

        public override string Four()
        {
            return "XL";
        }

        public override string Five()
        {
            return "L";
        }

        public override string Nine()
        {
            return "XC";
        }

        public override int Multiplier()
        {
            return 10;
        }
    }

    public class HundredExp : Expression
    {
        // Hundred checks C, CD, D or CM
        public override string One()
        {
            return "C";
        }

        public override string Four()
        {
            return "CD";
        }

        public override string Five()
        {
            return "D";
        }

        public override string Nine()
        {
            return "CM";
        }

        public override int Multiplier()
        {
            return 100;
        }
    }
    
    public class ThousandExp : Expression
    {
        // Thousand checks for the Roman Numeral M 
        public override string One()
        {
            return "M";
        }

        public override string Four()
        {
            return " ";
        }

        public override string Five()
        {
            return " ";
        }

        public override string Nine()
        {
            return " ";
        }

        public override int Multiplier()
        {
            return 1000;
        }
    }
}