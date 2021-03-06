﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

namespace api.Resources.Functions
{
    public class Functions
    {
        public class Decode
        {
            /// <summary>
            /// Decode base64 to string
            /// </summary>
            /// <param name="b64"></param>
            /// <returns>string</returns>
            public static string Base64toString(string b64)
            {
                return System.Text.Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        b64
                    ));
            }
        }

        public class Encode
        {
            /// <summary>
            /// Encode string to base64
            /// </summary>
            /// <param name="b64"></param>
            /// <returns>string</returns>
            public static string StringToBase64(string b64)
            {
                return Convert.ToBase64String(
                    Encoding.ASCII.GetBytes(b64)
                    );
            }
        }

        public class PropertyCheck
        {
            public static bool IsAnyNullOrEmpty(object myObject)
            {
                foreach (PropertyInfo pi in myObject.GetType().GetProperties())
                {
                    if (pi.PropertyType == typeof(string))
                    {
                        string value = (string)pi.GetValue(myObject);
                        if (string.IsNullOrEmpty(value))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }
        
        
    }
}