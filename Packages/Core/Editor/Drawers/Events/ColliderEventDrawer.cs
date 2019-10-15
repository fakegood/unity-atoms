#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Collider`. Inherits from `AtomDrawer&lt;ColliderEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColliderEvent))]
    public class ColliderEventDrawer : AtomDrawer<ColliderEvent> { }
}
#endif
