using System;
using System.Collections.Generic;

namespace Valverij.InlineFunctions.Conditionals
{
    public class SwitchContainer<TCase, TResult>
    {
        private TCase _switchValue;
        private List<Case<TCase, TResult>> _cases = new List<Case<TCase, TResult>>();

        public SwitchContainer(TCase switchValue)
        {
            if (switchValue == null)
                throw new ArgumentNullException(nameof(switchValue));

            _switchValue = switchValue;
        }

        public static implicit operator TResult(SwitchContainer<TCase, TResult> container) => container.Resolve(default(TResult));

        public Case<TCase, TResult> Case(TCase caseValue)
        {
            var newCase = new Case<TCase, TResult>(caseValue, this);
            Add(newCase);
            return newCase;
        }

        public TResult Default(TResult result) => Resolve(result);

        public void Add(Case<TCase, TResult> @case) => _cases.Add(@case);

        internal TResult Resolve(TResult defaultResult)
        {
            foreach (var @case in _cases)
                if (@case.IsMatch(_switchValue))
                    return @case.Resolve();

            return defaultResult;
        }
    }
}
