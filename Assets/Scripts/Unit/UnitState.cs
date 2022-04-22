using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitState :StateMachineBehaviour
{
    
    public abstract void InitState(Unit unit);

}
