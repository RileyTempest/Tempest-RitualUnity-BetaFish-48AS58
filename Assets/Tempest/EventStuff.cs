using System;
using System.Collections.Generic;

namespace Tempest.Events
{
    //Event Declarations
    public delegate Delegate TestMultiEventBuss();
}

namespace Tempest.Events 
{
    [Serializable]
    public class NexusEventBuss { }

    public class ActorBuss : NexusEventBuss, IEventBuss<Type>
    /*** If you want to be an ActorBuss
     * 'connect' with the nexus, your superclass. Give a singleton instance.
     * 
     */
    {
        //Ctor
        public ActorBuss()
        {
            NexusInstance ??= this;
            BussInstance ??= this;
            PlayerBuss ??= new ActorSubBuss();
        }

        //Member Properties
        protected readonly NexusEventBuss NexusInstance;
        protected readonly ActorBuss BussInstance;
        protected readonly ActorSubBuss PlayerBuss; //YAGNI
        
        //Interface Properties
        public Type BussType => this.GetType();
        
        //Events
        public static event TestMultiEventBuss TestEvent; //TODO: clever way to populate 0 index?

        //TestMethods
        private void foobar() { }

        //Nested Class, SubBuss
        public sealed class ActorSubBuss { } //YAGNI

        
    }

    //Interfaces, Publisher classes
    public interface IEventBuss<out TBuss>
        where TBuss : Type
    {
        TBuss BussType { get; }
    }

    //Interfaces, Subscriber classes
    public interface IHasEventBuss<out TBuss>
        where TBuss : Type
    {
        //TODO: Review Only one buss field allowed...?
        TBuss BussType { get; }
    }
    
}