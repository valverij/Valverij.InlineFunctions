using System;
using System.Collections.Generic;
using System.Text;

namespace Valverij.InlineFunctions.Conditionals
{
    public class Switch
    {
        public SwitchSetup<T> On<T>(T obj) => new SwitchSetup<T>(obj);
    }
}
