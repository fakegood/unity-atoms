using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `Test`. Inherits from `AtomListener&lt;Test, TestAction, TestEvent, TestUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Test Listener")]
    public sealed class TestListener : AtomListener<
        Test,
        TestAction,
        TestEvent,
        TestUnityEvent>
    { }
}
