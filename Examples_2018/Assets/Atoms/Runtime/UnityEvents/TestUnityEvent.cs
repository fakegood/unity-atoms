using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Test`. Inherits from `UnityEvent&lt;Test&gt;`.
    /// </summary>
    [Serializable]
    public sealed class TestUnityEvent : UnityEvent<Test> { }
}
