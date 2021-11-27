using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CyphersWin
{
    class Error
    {
        public enum Status
        { 
            [Description("Įveskite norimą užšifruoti tekstą")]
            NoText =-1,

            [Description("Įveskite raktą")]
            NoKey = -2,

            [Description("Per ilgas raktas (>25)")]
            LongKey = -3,

            [Description("Rakte yra pasikartojančių simbolių")]
            BadKey= -4,

            //[Description("Poslinkis turėtų būti daugiau už 0")]
            //ShiftIsZero = -3,

            [Description("Viskas gerai")]
            EverythinIsOK = 1,

        }
        public static string GetEnumDescription(Enum value)
        {
            // Get the Description attribute value for the enum value
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
       public static bool areChractersUnique(string str)
        {
            int checker = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                int val = (str[i] - 'a');

                if ((checker & (1 << val)) > 0)
                    return false;
                checker |= (1 << val);
            }
            return true;
        }
    }
}
