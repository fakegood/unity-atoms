#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Test`. Inherits from `AtomDrawer&lt;TestEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TestEvent))]
    public class TestEventDrawer : AtomDrawer<TestEvent> { }
}
#endif
