using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Business
{
    public class RegistrationModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }
}
