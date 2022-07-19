using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ZKFreamWork
{
    public interface IManager
    {
        void OnCreate();

        void OnUpdate();

        void OnDestory();

        void OnGUI();
    }
}

