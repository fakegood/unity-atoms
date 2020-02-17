#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Test`. Inherits from `AtomEventEditor&lt;Test, TestEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(TestEvent))]
    public sealed class TestEventEditor : AtomEventEditor<Test, TestEvent>
    {
        protected override VisualElement GetRaiseValueInput()
        {
            var input = new Toggle() { label = "Raise value", name = "Raise value", viewDataKey = "Raise value" };
            input.RegisterCallback<ChangeEvent<Test>>((evt) => { _raiseValue = evt.newValue; });
            return input;
        }
    }
}
#endif
