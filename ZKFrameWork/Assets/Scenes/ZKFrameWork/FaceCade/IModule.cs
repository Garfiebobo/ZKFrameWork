using System;
namespace ZKFreamWork
{
    public interface IModule  
    {
        void OnCreate();

        void OnUpdate();

        void OnGUI();
    }
}

