using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `Test`. Inherits from `AtomListener&lt;Test, Test, TestTestAction, TestTestEvent, TestTestUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Test x 2 Listener")]
    public sealed class TestTestListener : AtomListener<
        Test,
        Test,
        TestTestAction,
        TestTestEvent,
        TestTestUnityEvent>
    { }
}
