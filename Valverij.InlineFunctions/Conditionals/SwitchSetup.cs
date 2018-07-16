using System;
using System.Collections.Generic;
using System.Text;

namespace Valverij.InlineFunctions.Conditionals
{
    public class SwitchSetup<TCase>
    {
        private readonly TCase _switchValue;

        public SwitchSetup(TCase switchValue) => _switchValue = switchValue;

        public SwitchContainer<TCase, TResult> Returns<TResult>() => new SwitchContainer<TCase, TResult>(_switchValue);
    }
}
