using System;
using System.Collections.Generic;
using System.Text;

namespace Valverij.InlineFunctions.Conditionals
{
    public class If
    {
        private readonly Func<bool> _condition;

        public If(Func<bool> condition)
        {
            _condition = condition;
        }

        public void Then(Action action)
        {
            if (_condition())
                action();
        }
    }
}
