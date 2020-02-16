using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Test`. Inherits from `AtomVariable&lt;Test, TestEvent, TestTestEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Test", fileName = "TestVariable")]
    public sealed class TestVariable : AtomVariable<Test, TestEvent, TestTestEvent>
    {
        protected override bool AreEqual(Test first, Test second)
        {
            throw new NotImplementedException();
        }
    }
}
