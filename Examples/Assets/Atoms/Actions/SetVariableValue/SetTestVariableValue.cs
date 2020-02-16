using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Test`. Inherits from `SetVariableValue&lt;Test, TestVariable, TestConstant, TestReference, TestEvent, TestTestEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Test", fileName = "SetTestVariableValue")]
    public sealed class SetTestVariableValue : SetVariableValue<
        Test,
        TestVariable,
        TestConstant,
        TestReference,
        TestEvent,
        TestTestEvent>
    { }
}
