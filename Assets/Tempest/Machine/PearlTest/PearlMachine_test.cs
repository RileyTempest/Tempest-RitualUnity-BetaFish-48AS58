namespace Tempest.Machines
{
    /* Pearl Machine and State */
    public partial class AgentMachine { }
    public partial class SimpleMachine : AgentMachine { }
    public class PearlMachine : SimpleMachine
    {
        
    }
    
    //...
    
    public abstract class AgentStates { }
    public class PearlStates : AgentStates
    {
        
    }
}

namespace Tempest.Machines
{
    /* TODO: Review: Pearl Interfaces/Injections/Hooks */

    public interface PearlStateHooks
    {
        //TODO: something something what should the states expect from the class?
        //Use interface type to ease method/action hooks for state entry/update/exit
    }
}