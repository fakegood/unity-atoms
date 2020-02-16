using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 of type `Test`. Inherits from `AtomEvent&lt;Test, Test&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Test x 2", fileName = "TestTestEvent")]
    public sealed class TestTestEvent : AtomEvent<Test, Test> { }
}
