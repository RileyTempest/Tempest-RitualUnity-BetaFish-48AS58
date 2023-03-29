using System;
using System.Collections;
using System.Collections.Generic;
using Tempest.Mono;
using Tempest.Events;
using Tempest.Machines;

namespace Tempest.Actors
/* ActorParts */
{
    public partial class Actor : Tempest.Object { }
    public partial class NonAgent : Actor, INoMachine<Type> { }
    public abstract partial class Agent : Actor { }
    public sealed partial class Pawn : Agent { }
}

namespace Tempest.Actors
/* SuperClass */
{
    public partial class Actor : Tempest.Object { }
    public partial class NonAgent : Actor, INoMachine<Type>
    {
        public Type NoMachine { get; }
    }
    
    
    public abstract partial class Agent : Actor, IMachine<Type>, IHasEventBuss<Type>
    {
        //Ctor
        protected Agent()
        {
            Machine = new SimpleMachine();
            //TODO: ActorBuss = _publisherInstance.BussInstance;
        }
        
        //Member Properties
        public Type MachineType => Machine.GetType();
        private readonly SimpleMachine Machine;
        
        public Type BussType => ActorBuss.GetType();
        private readonly ActorBuss ActorBuss; //TODO:
        
        //IEventBuss
        protected virtual void SubscribeToEventBuss() => throw new NotImplementedException();

        //IMachine
        public virtual void Standby(ref bool _resume) => throw new NotImplementedException();
        public virtual void Resume() => throw new NotImplementedException();
        public virtual void Reset() => throw new NotImplementedException();
    }
}

namespace Tempest.Actors
/* ConcreteClass */
{
    public sealed partial class Pawn : Agent, IMonoScene
        /****
         **** if you want to be an agent...
         * Take an event buss for subscribing
         * Give an interface for your destruction, activation, scene management
         * Give an interface for your agent-machine
         * Give an interface for your anim-machine
         */
    {
        //Ctor
        public Pawn() : base()
        {
            SubscribeToEventBuss();
        }

        //Interfaces
        void IMonoScene.MonoStuffFoobar() => throw new NotImplementedException();
        protected sealed override void SubscribeToEventBuss() => throw new NotImplementedException();

        //TestMethods
        private void foobar()
        {
            //
            new Tempest.Events.ActorBuss.ActorSubBuss();
            
            //
            Pawn myPawn = new Pawn();
            myPawn = this;
            IMonoScene myInterface = myPawn;
            myInterface.MonoStuffFoobar();
            
            //

            Action MyAction; //TODO: how to pass into State as Payload

            MyAction = () => { };
            MyAction = delegate {  };
            MyAction = MyAction;
        }

        private void MyAction()
        {
            throw new NotImplementedException();
        }
    }
}