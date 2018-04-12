using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Signpoint.Classes
{
    public class ImageHelper
    {
        public static string ImagePath(string Path)
        {
            return "~/Content/" + Path;
        }
    }
}