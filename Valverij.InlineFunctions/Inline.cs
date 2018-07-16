using System;
using Valverij.InlineFunctions.Conditionals;

namespace Valverij.InlineFunctions
{
    public static class Inline
    {
        public static Switch Switch => new Switch();

        public static If If(Func<bool> condition) => new If(condition);
    }
}
