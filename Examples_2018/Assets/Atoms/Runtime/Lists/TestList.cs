using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// List of type `Test`. Inherits from `AtomList&lt;Test, TestEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Test", fileName = "TestList")]
    public sealed class TestList : AtomList<Test, TestEvent> { }
}
