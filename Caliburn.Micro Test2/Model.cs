﻿using System;
using System.Collections.Generic;

namespace Caliburn.Micro_Test2.ViewModels
{
    internal class Model
    {
        internal static List<string> GetList()
        {
            //Comment editted in Visual Studio
            var list = new List<string>();
            list.Add("Ich");
            list.Add("bin");
            list.Add("eine");
            list.Add("GitHub");
            list.Add("Liste");
            return list;
        }
    }
}
