using System.Collections.Generic;
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

        private TroikaColours PointerColour;
        
        //Events
        private ClipEvent ChangeClipPointerEvent;
        private ClipEvent RotateElementEvent;
        private ClipEvent EjectElementEvent;
        
        
        //Temp Properties
        public GameObject Stackcarousel;
        public int StackIndex = 0;
        public List<GameObject> GOorbs; 
        

        //MenuHelpers
        //[MenuItem("TempestMx/CastEvent - ChangeClipPointerEvent")]
        public void MenuHelp_RoundRobinPointer()
        {
            
            Debug.Log("Robin has been been here");
            
            //chec if last entry
            //Go to next or first
            //chnage color

            GOorbs[StackIndex].GetComponent<Renderer>().material.color = Color.grey;
            
            if (StackIndex >= (GOorbs.Count -1))
            {
                StackIndex = 0;
            }
            else StackIndex++;
            
            GOorbs[StackIndex].GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
}