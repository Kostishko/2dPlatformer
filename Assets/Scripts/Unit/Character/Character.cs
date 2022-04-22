using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Unit
{


    public Moving Moving = new Moving();

    public override void InitParts()
    {
        Moving.InitPart(this.gameObject);
    }
   
    
}
