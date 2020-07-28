using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using ManageProjectStudent_Interface;
using System.Runtime.CompilerServices;

namespace ManageProjectStudent_ViewModel
{
    public class GarenaViewModel
    {
        #region Method
        public static bool _checkCharacterNumber(char _C)
        {
            if (_C >= '0' && _C <= '9' && ((Keys)_C != Keys.Back) && ((Keys)_C != Keys.Enter))
            {
                return false;
            }
            return true;
        }
        public static bool _checkCharacterChar(char _C)
        {
            if((_C < '0' || _C > '9') && ((Keys)_C != Keys.Back) && ((Keys)_C != Keys.Enter))
            {
                return false;
            }
            return true;
        }
        public static bool checkEmail(string _STR_Email)
        {
            return (_STR_Email.IndexOf("@gmail.com") >= 0);
        }
        public static bool checkIDCard(string _STR_IDCard)
        {
            if ((_STR_IDCard.Length >= 8) || (_STR_IDCard.Length <= 11))
                return false;
            return true;
        }
        public static bool checkPhoneNumber(string _STR_PhoneNumber)
        {
            if ((_STR_PhoneNumber.Length < 10) || (_STR_PhoneNumber.Length > 10))
                return false;
            return true;
        }
        //seperate number
        public static int _seperateNumber(string _str)
        {
            string _strNumber = string.Empty;
            int _in = _str.Count();
            for(int i= 0; i< _in; i++)
            {
                if(_str[i]>='0' && _str[i]<='9')
                {
                    _strNumber += _str[i];
                }    
            }
            return Convert.ToInt32(_strNumber);
        }
        //seperate word
        public static string _seperateWord(string _str)
        {
            string _strWord = string.Empty;
            int _in = _str.Count();
            for(int i=0; i<_in; i++)
            {
                if((_str[i]>='A' && _str[i]<='Z') || (_str[i] >= 'a' && _str[i] <= 'z'))
                {
                    _strWord += _str[i];
                }    
            }
            return _strWord;
        }
        //max number
        public static int _findMax( int[] _arr)
        {
            int _in =_arr.Count();
            int _iMax =_arr[0];
            for (int i = 0; i < _in; i++)
            {
                if (_arr[i] > _iMax)
                {
                    _iMax = _arr[i];
                }
            }
            return _iMax;
        }
        //Increase the code by 1
        public static string returnMaxCode(List<string> _lst_String)
        {
            if (_lst_String.Count > 0)
            {
                string _STR_MaxCode = _seperateWord(_lst_String[0]);
                // Step 1: Separate numbers and put them into lists.
                int _in = _lst_String.Count;

                List<int> _lst_Number = new List<int>();

                for (int i = 0; i < _in; ++i)
                {
                    _lst_Number.Add(_seperateNumber(_lst_String[i]));
                }

                // Step 2 : Find max.
                int _iMax = _findMax(_lst_Number.ToArray());

                // Step 3 : Increase the variable found to 1.
                _iMax++;

                // Step 4 :Combine letters and numbers into a string .
                _STR_MaxCode += _iMax.ToString();

                return _STR_MaxCode;
            }
            return "1";
        }
        public static bool _bCheckLoginStudent =false;
        public static bool _bCheckLoginLecturer =false;
    }
    #endregion
}

