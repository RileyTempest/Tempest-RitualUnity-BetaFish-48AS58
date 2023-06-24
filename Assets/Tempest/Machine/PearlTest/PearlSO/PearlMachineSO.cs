using Tempest.Machines;
using UnityEngine;

namespace Tempest.Machine.MachineSO
{
    [CreateAssetMenu(fileName = "PearlMachineConfig", menuName = "Tempest/Pearl/PearlMachineSO", order = 0)]
    public class PearlMachineSO : ScriptableObject
    {
        [SerializeField] private SimpleMachine machine; 
        [SerializeField] private ScriptableObject states; 
        
        //TODO: configuration methods
    }
}