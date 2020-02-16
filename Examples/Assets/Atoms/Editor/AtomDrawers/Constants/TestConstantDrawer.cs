#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Test`. Inherits from `AtomDrawer&lt;TestConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TestConstant))]
    public class TestConstantDrawer : VariableDrawer<TestConstant> { }
}
#endif
