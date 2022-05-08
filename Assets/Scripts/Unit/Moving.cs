using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : Part
{

    public float movementSpeed;
    private Rigidbody2D rb;
    public override void InitPart(GameObject gameObject)
    {
        parent = gameObject;
        parent.TryGetComponent<Rigidbody2D>(out rb);


    }

    public void Move (float dir)
{
    parent.transform.position +=  parent.transform.right*dir* 5*Time.deltaTime;
}



}
