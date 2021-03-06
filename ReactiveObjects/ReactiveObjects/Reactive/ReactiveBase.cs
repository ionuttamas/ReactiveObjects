using System;

namespace ReactiveObjects.Reactive
{
    public class ReactiveBase
    {
        internal virtual object ValueObject { get; set; }
        internal event EventHandler<object> ValueObjectChanged;

        internal void OnValueObjectChanged(object value)
        {
            ValueObjectChanged?.Invoke(this, value);
        }
    }
}