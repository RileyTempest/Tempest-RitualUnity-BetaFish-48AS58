using System.Collections.Generic;
using UnityEngine;



/******Tempest - faceless to hunt exotic mxchines
 *
 * What sub type can the exotic stack collect?
 * They must be mutable.
 * Scale: what command style interface would be best when mutating the stack entry
 *
 * How are we mutating the stack/object?
 * Perhaps the stack itself should simply have an interface to cast events
 * ignore the contents of the entry all together
 *
 * TODO: 001: Abstract/super class for stack instances.
 * what to call 'exotic stacks' ? 
 * ClipStacks
 * Decorate ClipStacks with EventInterfaces
 * IClipEvents
 * blahblah : IClipEvents
 * ClipStacks --> ClipMachine
 * Concrete Classes: LavenderStack --> ClipStack
 * Concrete Classes: CanarieStack ---> ClipStack
 * Concrete Classes: EmeraldStack --> ClipStack
 * TempestClipMachine
 *
 * Tabula Rasa
 *
 *
 * events: change ClipPointer, mutateElement_ejectPop, mutateElement_rotate
 * 
 ********/


namespace Tempest.Machines.Bx
{
    public class ClipMachine : MonoBehaviour
    {

    }

    public class ClipStack : ClipMachine
    {
        
    }
}

namespace Tempest.Machines.Bx
{
    //Enum
    public enum TroikaColours
    {
        Lavender = 0,
        Canary = 1,
        Emerald = 2
    }
    
    //Interfaces
    public interface IClipMachine
    {
        void ClipPointerCommand(TroikaColours _pointTo);
    }
    public interface IJukeActions
    {
        void Eject(); //Set element into 'tray', removing/splicing stack element
        void Rotate(); //Exchange element with 'tray'
    }
    public interface ILavenderStack : IJukeActions
    {
        void ToggleBoo(Renderer _renderer);
    }
    public interface ICanaryStack : IJukeActions
    {
        void ToggleHoo();
    }
    public interface IEmeraldStack : IJukeActions
    {
        void ToggleFoo();
    }
    

}