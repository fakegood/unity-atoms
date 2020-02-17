#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Test`. Inherits from `AtomDrawer&lt;TestVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TestVariable))]
    public class TestVariableDrawer : VariableDrawer<TestVariable> { }
}
#endif
