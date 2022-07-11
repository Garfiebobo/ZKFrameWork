// **********************************************************************
// Scripts Name:                            Observer.cs
// 作者(Author):                              bobo
// 创建时间(CreateTime):              2022年7月10日 15:23:03
// 脚本描述(Module description):
// **********************************************************************

using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
namespace ZKFreamWork
{
    //观察者
    public class Observer :MonoBehaviour
    {
        public  string Obkey = "";
        public virtual void OnNotify(object msg) { }
    }
}