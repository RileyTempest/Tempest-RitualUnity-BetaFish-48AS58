using System;
using System.Collections;
using System.Collections.Generic;

namespace Tempest.Machines
/* Machine Parts */
{
    public partial class AgentMachine { }
    public partial class AnimMachine { } //Separate Mech for Animations
    public partial class PushdownAutomata : AgentMachine { }
    public partial class SimpleMachine : AgentMachine { }
}

namespace Tempest.Machines
/* State Parts */
{
    public interface IState<out TKey, out TState>
        where TKey : Enum
        where TState : class
    
    {
        /* Placeholder interface - YAGNI ?? */
        Type GetKeyType { get; }
        Type GetStateType { get; }
    }

    public abstract class State<TKey> : IState<TKey, State<TKey>>
        where TKey : Enum
    {
        public abstract Type GetKeyType { get; }
        public abstract Type GetStateType { get; }
    }

    public class AgentState : State<StateKeyTest>
    {
        public override Type GetKeyType => typeof(StateKeyTest);
        public override Type GetStateType => typeof(AgentState);
    }
    
    //TODO: Review: How to pass a type to parent via ctor? 
    
    
    //
    
    //What is a state? A container for control flow. 
    //Implementing class couples the state interface (delegate)
    //with concrete methods 

    public class StateTest : StateFlow<StatePayloadTest>
    {
        public override void Enter(StatePayloadTest _payload)
        {
            throw new NotImplementedException();
        }

        public override void SetHandler_Enter()
        {
            throw new NotImplementedException();
        }

        public override void Update(StatePayloadTest _payload)
        {
            throw new NotImplementedException();
        }

        public override void Exit(StatePayloadTest _payload)
        {
            throw new NotImplementedException();
        }

        public override void ClearStateHandlers()
        {
            throw new NotImplementedException();
        }
    }
    public abstract class StateFlow<TPayload> : IStateFlow<TPayload>
        where TPayload : IStatePayloadSuper
    {
        public abstract void Enter(TPayload _payload);
        public abstract void SetHandler_Enter();
        public abstract void Update(TPayload _payload);
        public abstract void Exit(TPayload _payload);
        public abstract void ClearStateHandlers();
    }

    public interface IStateFlow<TPayload> : IStateEnter<TPayload>, 
        IStateUpdate<TPayload>, IStateExit<TPayload>
        where TPayload : IStatePayloadSuper
    {
        void ClearStateHandlers();
    }

    //Needs StatePayload struct
    public interface IStateEnter<TPayload>
        where TPayload : IStatePayloadSuper
    {
        //TODO: needs return value?
        void Enter(TPayload _payload);
        void SetHandler_Enter(); //TODO: paint into corner...grrrr

        //Action EnterAction { get; set; }
    }

    public interface IStateUpdate<TPayload>
        where TPayload : IStatePayloadSuper
    {
        void Update(TPayload _payload);
    }

    public interface IStateExit<TPayload>
        where TPayload : IStatePayloadSuper
    {
        void Exit(TPayload _payload);
    }
    
}

namespace Tempest.Machines
/* Enumerations */
{
    public enum StateKeyTest : ushort
    {
        Init00 = default,
        Test01 = 1,
        Test02 = 2
    }
}

namespace Tempest.Machines
/* Structs */
{
    //TODO: stack
    //TODO: state lookup

    public class MechStack<TStateKey> : Stack<TStateKey>
        where TStateKey : Enum
    {
        
    }

    public class StateLookup<TStateKey, TState> : Dictionary<TStateKey, TState>
        where TStateKey : Enum
        where TState : class, IState<TStateKey, TState>
    {
        
    }
    
    //Payloads
    public interface IStatePayloadSuper { } //bleh. Dont wanna use classes but need a super class for generic constraint
    public struct StatePayloadTest : IStatePayloadSuper { }
}

namespace Tempest.Machines
/* Test Insight */
{
    public sealed class TestClass
    {
        private void FoobarTestMethod()
        {
            MechStack<StateKeyTest> TestStack = new MechStack<StateKeyTest>();
            TestStack.Peek();
            TestStack.Push(StateKeyTest.Test01);
            TestStack.Pop();
            TestStack.Clear();
            int myint = TestStack.Count;
            
            
        }
    }
}

namespace Tempest.Machines
/* Implementing */
{
    public interface IMachine<out TMachine> 
        where TMachine : Type
    {
        TMachine MachineType { get; }
        void Standby(ref bool _resume);
        void Resume();
        void Reset();
    }

    public interface IAnimMech<out TAnimMech>
        where TAnimMech : Type
    {
        TAnimMech AnimMechType { get; }
        void Standby(ref bool _resume);
        void Idle();
        void Resume();
        void Reset();
    }
    
    //Decorations, ExplicitExceptions
    public interface INoMachine<out TNone>
    {
        Type NoMachine { get; }
    }
}
