using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event x 2 of type `Test`. Inherits from `UnityEvent&lt;Test, Test&gt;`.
    /// </summary>
    [Serializable]
    public sealed class TestTestUnityEvent : UnityEvent<Test, Test> { }
}
