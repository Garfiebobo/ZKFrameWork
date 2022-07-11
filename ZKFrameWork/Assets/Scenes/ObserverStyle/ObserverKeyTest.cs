// **********************************************************************
// Scripts Name:                          ObserverKeyTest.cs
// 作者(Author):                           bobo
// 创建时间(CreateTime):              2022年7月10日 17:12:44
// 脚本描述(Module description):
// **********************************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZKFreamWork
{
    public class ObserverKeyTest : MonoBehaviour
    {

        Subject _subJect = new Subject();
        AchieveMentTest mentTest;
        // Start is called before the first frame update
        void Start()
        {
            mentTest = this.GetComponent<AchieveMentTest>();

            _subJect.AddObserver(mentTest);
        }

        // Update is called once per frame
        void Update()
        {
            ObserVerKey();
        }

        public void ObserVerKey()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                _subJect.SendMsg("AchiveMent", "gg");
            }
        }
    }
}