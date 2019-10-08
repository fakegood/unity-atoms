using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Color", fileName = "ColorVariable")]
    public sealed class ColorVariable : EquatableAtomVariable<Color, ColorEvent, ColorColorEvent> { }
}