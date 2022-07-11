using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandle
{
    private UnitCon m_unitCon;
    public InputHandle (UnitCon unitCon)
    {
        m_unitCon = unitCon;
    }

    public virtual void Excute(Command InPutcommand)
    {
        InPutcommand.Execute(m_unitCon);
    }
}
