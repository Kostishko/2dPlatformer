using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingState : UnitState
{

    Character character;
    public override void InitState(Unit unit)
    {
        if (unit is Character ch)
        character= ch;
        Debug.Log("init state moving character");
        
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        character.Moving.Move(animator.GetFloat("Direction"));
        
        
    }


}

