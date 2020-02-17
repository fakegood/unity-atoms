#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event x 2 property drawer of type `Test`. Inherits from `AtomDrawer&lt;TestTestEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TestTestEvent))]
    public class TestTestEventDrawer : AtomDrawer<TestTestEvent> { }
}
#endif
