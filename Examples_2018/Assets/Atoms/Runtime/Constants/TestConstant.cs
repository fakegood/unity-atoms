using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Constant of type `Test`. Inherits from `AtomBaseVariable&lt;Test&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Test", fileName = "TestConstant")]
    public sealed class TestConstant : AtomBaseVariable<Test> { }
}
