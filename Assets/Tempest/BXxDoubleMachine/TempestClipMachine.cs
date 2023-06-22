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
        private LavenderStack LavenderStack;
        private CanaryStack CanaryStack;
        private EmeraldStack EmeraldStack;

        public GameObject LavenderGO;
        public GameObject CanaryGO;
        public GameObject EmeraldGO;

        private KeyValuePair<ClipStack, GameObject> LavenderPair;
        private KeyValuePair<ClipStack, GameObject> CanaryPair;
        private KeyValuePair<ClipStack, GameObject> EmeraldPair;
        
        //Events
        private ClipEvent ChangeClipPointerEvent;
        private ClipEvent RotateElementEvent;
        private ClipEvent EjectElementEvent;
        
        
        //Temp Properties
        public GameObject Stackcarousel;
        public int StackIndex = 0;

        //temp_Properties
        public Dictionary<TroikaColours, KeyValuePair<ClipStack, GameObject>> TroikaLookup;

        //MenuHelpers
        //[MenuItem("TempestMx/CastEvent - ChangeClipPointerEvent")]
        public void MenuHelp_RoundRobinPointer(int _pointerColor)
        {
            LavenderPair = new KeyValuePair<ClipStack, GameObject>(LavenderStack, LavenderGO);
            CanaryPair = new KeyValuePair<ClipStack, GameObject>(CanaryStack, CanaryGO);
            EmeraldPair = new KeyValuePair<ClipStack, GameObject>(EmeraldStack, EmeraldGO);
            
            TroikaLookup = new Dictionary<TroikaColours, KeyValuePair<ClipStack, GameObject>>()
            {
                { TroikaColours.Lavender, LavenderPair },
                { TroikaColours.Canary, CanaryPair },
                { TroikaColours.Emerald, EmeraldPair }
            };

            if (_pointerColor == ((int)TroikaColours.Lavender))
            {
                ILavenderStack Lavender = (LavenderStack)TroikaLookup[(TroikaColours) _pointerColor].Key;
                GameObject LavGo = TroikaLookup[(TroikaColours) _pointerColor].Value;
                Lavender.ToggleBoo(LavGo.GetComponent<Renderer>());
            }


            
            
            Debug.Log("Robin has been round here");
            
            //

            /*GOorbs[StackIndex].GetComponent<Renderer>().material.color = Color.grey;
            
            if (StackIndex >= (GOorbs.Count -1))
            {
                StackIndex = 0;
            }
            else StackIndex++;
            
            GOorbs[StackIndex].GetComponent<Renderer>().material.color = Color.magenta;*/
        }
    }
}