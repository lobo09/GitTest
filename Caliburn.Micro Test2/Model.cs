using System;
using System.Collections.Generic;

namespace Caliburn.Micro_Test2.ViewModels
{
    internal class Model
    {
        internal static List<string> GetList()
        {
            var list = new List<string>();
            list.Add("Ich");
            list.Add("bin");
            list.Add("eine");
            list.Add("master");
            list.Add("Liste");
            return list;
        }
    }
}