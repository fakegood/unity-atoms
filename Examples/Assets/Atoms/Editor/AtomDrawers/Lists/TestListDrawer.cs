#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// List property drawer of type `Test`. Inherits from `AtomDrawer&lt;TestList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TestList))]
    public class TestListDrawer : AtomDrawer<TestList> { }
}
#endif
