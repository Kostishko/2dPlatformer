using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Part 
{
    
public GameObject parent;
public bool isActive;

public virtual void InitPart(GameObject gameObject)
{
    parent = gameObject;
}

public virtual bool GetPartActive()
{
return isActive;
}

public virtual void SetPartActive(bool active)
{
isActive = active;
}



}
