using UnityEngine;

namespace Tempest.Machines.Bx
{
    public class LavenderStack : ClipStack, ILavenderStack
    {
        
        //Fields
        public TempestClipMachine ClipMachine;

        public void Eject()
        {
            throw new System.NotImplementedException();
        }

        public void Rotate()
        {
            throw new System.NotImplementedException();
        }

        public void ToggleBoo(Renderer _renderer)
        {
            //throw new System.NotImplementedException();
            _renderer.material.color = Color.magenta;
            
        }
    }
}