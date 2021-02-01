using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3_Encaps_Inherit_Polymorph
{
    abstract class UseError
    {
        public abstract string UEMessage();


    }

    class NumericInputError : UseError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired a error ";
        }
    }

    class TextInputError : UseError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numericonly field. This fired a error";
        }
    }
}
