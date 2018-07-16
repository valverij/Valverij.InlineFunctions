using System;
using System.Collections.Generic;
using System.Text;

namespace Valverij.InlineFunctions.Conditionals
{
    public class Case<TCase, TResult>
    {
        private TCase _caseValue;
        private Func<TResult> _resultFunction;
        private readonly SwitchContainer<TCase, TResult> _container;

        public Case(TCase caseValue, SwitchContainer<TCase, TResult> container)
        {
            _container = container;
            _caseValue = caseValue;
        }

        public Case(TCase caseValue, Func<TResult> result)
        {
            _caseValue = caseValue;
            _resultFunction = result;
        }

        public SwitchContainer<TCase, TResult> Then(TResult result) => Then(() => result);

        public SwitchContainer<TCase, TResult> Then(Func<TResult> result)
        {
            _resultFunction = result;
            return _container;
        }

        internal bool IsMatch(TCase switchValue) => object.Equals(_caseValue, switchValue);

        internal TResult Resolve() => _resultFunction();
    }
}
