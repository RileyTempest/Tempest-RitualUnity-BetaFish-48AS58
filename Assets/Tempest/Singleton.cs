namespace Tempest
{
    public abstract class Singleton<TSingleton> : Tempest.Object
        where TSingleton : Tempest.Singleton<TSingleton>, new()
    {
        //Ctor
        public Singleton() { }

        //Member Properties
        public abstract TSingleton SingletonInstance { get; }
    }
    
    public abstract class SingletonEventBuss : Tempest.Object
    {
        //Ctor
        public SingletonEventBuss() { }

        //Member Properties
        public abstract SingletonEventBuss BussInstance { get; }
    }
}