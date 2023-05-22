using Tempest.Machines.Bx;
using UnityEditor;
using UnityEngine;

delegate void ClipEvent();


namespace Tempest.Machines.Bx
{
    public class TempestClipMachine : ClipMachine
    {
        //Properties
        private LavenderStack Lavender;
        private CanaryStack Canary;
        private EmeraldStack Emerald;

        public TroikaColours PointerColour;
        
        //Events
        private ClipEvent ChangeClipPointerEvent;
        private ClipEvent RotateElementEvent;
        private ClipEvent EjectElementEvent;
        
        //MenuHelpers
        [MenuItem("TempestMx/CastEvent - ChangeClipPointerEvent")]
        public static void MenuHelp_RoundRobinPointer()
        {
            Debug.Log("Robin has been been here");
        }
    }
}