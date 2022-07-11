using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCon : MonoBehaviour
{
    //ÊäÈë¿ØÖÆÆ÷
    public InputHandle inputHandle;
    MonsterA monsterA;

    MoveLeftCommand leftCommand;
    MoveRightCommand rightCommand;
    // Start is called before the first frame update
    void Start()
    {
        monsterA = this.transform.GetComponent<MonsterA>();
        monsterA. m_InputHandle = new InputHandle(monsterA);
        inputHandle = monsterA.m_InputHandle;

        leftCommand = new MoveLeftCommand();
        rightCommand = new MoveRightCommand();
    }

    // Update is called once per frame
    void Update()
    {
        BlindKey();
    }

    public void BlindKey()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            inputHandle.Excute(leftCommand);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            inputHandle.Excute(rightCommand);
        }
    }
}
