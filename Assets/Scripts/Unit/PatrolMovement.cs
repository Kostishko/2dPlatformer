using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolMovement : Part
{


    public override void InitPart(GameObject gameObject)
    {
     this.parent = gameObject;    
    }

    public void Move()
    {
        if (GetPartActive())
        {

        }

    }

    private void Patrol (List<Vector2> way)
    {
        

    }

}