using System;
using System.Collections.Generic;
using System.Text;

namespace Valverij.InlineFunctions.Conditionals
{
    public class CaseResult<T>
    {
        public CaseResult(T result) => Result = result;

        public T Result { get; }
    }
}
