using System;
using System.Collections.Generic;
using UnityEngine;

namespace Tempest
{
    public class TriLight : MonoBehaviour
    {
        //Static
        private static Dictionary<TriLightColor, Color> ColorLookup;
        
        //Properties
        [SerializeField] private TriLightColor lightColor;
        [SerializeField] private bool dirtyColorToUpdate = false;
        [SerializeField] private Material thisMaterial;
        
        //Init
        private void Init()
        {
            thisMaterial = GetComponent<Renderer>().material;
            ColorLookup = new Dictionary<TriLightColor, Color>();
            ColorLookup.Add(TriLightColor.Green, Color.green);
            ColorLookup.Add(TriLightColor.Yellow, Color.yellow);
            ColorLookup.Add(TriLightColor.None, thisMaterial.color);
            ColorLookup.Add(TriLightColor.Red, Color.red);
        }
        //Unity Functions
        private void Awake()
        {
            Init();
        }

        private void LateUpdate()
        {
            if (dirtyColorToUpdate)
            {
                Update_SetMaterialAsLightColor();
                dirtyColorToUpdate = false;
            }
        }
        
        //Interfaces
        public void ChangeTriLightColor(TriLightColor _newColor)
        {
            lightColor = _newColor;
            dirtyColorToUpdate = true;
        }
        
        //Helpers
        private void Update_SetMaterialAsLightColor()
        {
            thisMaterial.color = ColorLookup[lightColor];
        }
    }

    public enum TriLightColor
    {
        None = default,
        Green, Yellow, Red
    }
}