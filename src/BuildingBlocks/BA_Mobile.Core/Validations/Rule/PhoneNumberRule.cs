﻿using BA_Mobile.Utilities;
using BA_Mobile.Utilities.Constant;

namespace BA_Mobile.Core
{
    public class PhoneNumberRule<T> : IValidationRule<T>
    {
        public string ValidationMessage
        {
            get; set;
        }

        public string CountryCode { get; set; }

        public bool Check(T value)
        {
            try
            {
                if (value == null)
                {
                    return false;
                }
                var str = value as string;
                if (!string.IsNullOrEmpty(CountryCode))
                {
                    if (CountryCodeConstant.VietNam.Equals(CountryCode))
                    {
                        if (!str.StartsWith("0"))
                        {
                            str = string.Format("0{0}", str);
                        }
                        var newPhone = string.Empty;
                        return StringHelper.ValidPhoneNumer(str, "10-09,086,088,089,020,032,033,034,035,036,037,038,039,070,079,077,076,078,083,084,085,081,082,056,058,059", out newPhone);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public class PhoneNumberDoubleRule<T> : IValidationRule<T>
    {
        public string ValidationMessage
        {
            get; set;
        }

        public string PhoneStr { get; set; }

        public bool Check(T value)
        {
            try
            {
                if (value == null)
                {
                    return false;
                }
                var str = value as string;
                if (!string.IsNullOrEmpty(PhoneStr))
                {
                    int count = 0;
                    int i = 0;
                    while ((i = PhoneStr.IndexOf(str, i)) != -1)
                    {
                        i += str.Length;
                        count++;
                    }
                    if (count >= 2)
                        return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}