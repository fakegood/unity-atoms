using System;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Test`. Inherits from `AtomReference&lt;Test, TestVariable, TestConstant&gt;`.
    /// </summary>
    [Serializable]
    public sealed class TestReference : AtomReference<
        Test,
        TestVariable,
        TestConstant> { }
}
