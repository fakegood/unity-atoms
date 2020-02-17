using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Test`. Inherits from `AtomEvent&lt;Test&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Test", fileName = "TestEvent")]
    public sealed class TestEvent : AtomEvent<Test> { }
}
