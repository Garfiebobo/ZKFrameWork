// **********************************************************************
// Scripts Name:                          AchieveMentTest.cs
// 作者(Author):                           bobo
// 创建时间(CreateTime):              2022年7月10日 16:34:21
// 脚本描述(Module description):
// **********************************************************************

using System.Collections;
using System.Collections.Generic;

using UnityEngine;
namespace ZKFreamWork
{
    //成就系统
    public class AchieveMentTest : Observer
    {
        public override void OnNotify(object msg)
        {
            string _msg = msg.ToString();

            Debug.Log(_msg);
        }
    }

}