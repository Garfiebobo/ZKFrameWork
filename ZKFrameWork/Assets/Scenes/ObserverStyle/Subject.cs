// **********************************************************************
// Scripts Name:                          Subject.cs
// 作者(Author):                           bobo
// 创建时间(CreateTime):              2022年7月10日 16:13:46
// 脚本描述(Module description):
// **********************************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ZKFreamWork
{
    public class Subject 
    {
        public List<Observer> ObserverList = new List<Observer>();
        public virtual void AddObserver(Observer ob )
        {
            ObserverList.Add(ob);
        }

        public virtual void RemoveObserver(Observer ob)
        {
            for (int i = 0; i < ObserverList.Count; i++)
            {
                if (ob.Obkey == ObserverList [i].Obkey)
                {
                    ObserverList.RemoveAt(i);
                    break;
                }
            }
        }

        public virtual void SendMsg(string _key,object msg)
        {
            for (int i = 0; i < ObserverList.Count; i++)
            {
                if (_key == ObserverList[i].Obkey)
                {
                    ObserverList[i].OnNotify(msg);
                }
            }
        }
    }
}
