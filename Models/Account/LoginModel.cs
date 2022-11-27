using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExerciseCode.Models.Account
{
    public class LoginModel
    {
    }

    public class LoginProcessParamModel
    {
        public string _loginId   { get; set; }
        public string _password  { get; set; }
        public byte   _loginType { get; set; }
    }

}