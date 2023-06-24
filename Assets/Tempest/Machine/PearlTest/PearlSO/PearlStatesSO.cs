using UnityEngine;

namespace Tempest.Machines
{
    [CreateAssetMenu(fileName = "PearlStatesConfig", menuName = "Tempest/Pearl/PearlStatesSO", order = 0)]
    public class PearlStatesSO : ScriptableObject
    {
        [SerializeField] private PearlStates PearlStates;
        [SerializeField] private PearlStateHooks PearlHooks;
    }
}