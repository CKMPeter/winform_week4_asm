using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormWeek4
{
    class Functions
    {
        public static bool CheckFormatEmail(string email)
        {
            for (int i = email.Length-1; i >=0; i--)
            {
                if (email[i] == '.')
                    for (int j = i - 1; j > 0; j--)
                        if (email[j] == '@')
                            return true;
            }
            return false;
        }
        public static bool CheckAge (DateTime dateTime) 
        {
            int Now = DateTime.Now.Year;
            if(Now - dateTime.Year >=17)
                return true;
            return false;
        }
        public static bool CheckGender (string gender) 
        {
            if (gender.ToLower() == "female") return true;
            return false;
        }
        public static int GetGender (bool gender)
        {
            if (gender == true) return 1;
            return 0;
        }
    }
}
