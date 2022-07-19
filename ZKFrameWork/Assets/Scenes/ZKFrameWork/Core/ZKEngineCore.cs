// **********************************************************************
// Scripts Name:                          ZKEngineCore.cs
// 作者(Author):                           bobo
// 创建时间(CreateTime):              2022年7月12日 23:59:13
// 脚本描述(Module description):
// **********************************************************************

using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
namespace ZKFreamWork
{
    public static class ZKEngineCore
    {

        //管理Module 类
        private class ModuleWarpper
        {
            public int Priority { private set; get; }
            public IModule Module { private set; get; }
        }
        /// <summary>
        /// 创建游戏模块
        /// </summary>
        /// <typeparam name="T">模块类</typeparam>
        /// <param name="priority">运行时的优先级，优先级越大越早执行。如果没有设置优先级，那么会按照添加顺序执行</param>
        public static T CreateModule<T>(int priority = 0) where T : class, IModule
        {
            return CreateModule<T>(null, priority);
        }

        /// <summary>
        /// 创建游戏模块
        /// </summary>
        public static T CreateModule<T>(System.Object createParam, int priority = 0) where T : class, IModule
        {
            return null;
        }

        //删除模块
        public static void RemoveModule<T>()
        {

        }

        /// <summary>
        /// 获取游戏模块
        /// </summary>
        /// <typeparam name="T">模块类</typeparam>
        public static T GetModule<T>() where T : class, IModule
        {
            System.Type type = typeof(T);
            
            return null;
        }
    }
}