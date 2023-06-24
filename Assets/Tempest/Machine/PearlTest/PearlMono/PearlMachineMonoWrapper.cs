using Tempest.Machine.MachineSO;
using UnityEngine;

namespace Tempest.Machine
{
    public class PearlMachineMonoWrapper : MonoBehaviour
    {
        //Composite SO AgentMachine
        //SerializedObject - Preconfigured AgentMachine w/SO States
        
        //AgentMachine, States, Actions
        //Where do actions reside? How to couple actions with states?
        //Can interfaces be coupled to states automagically?
        
        //

        [SerializeField] private PearlMachineSO PearlMachineConfig;
    }
}