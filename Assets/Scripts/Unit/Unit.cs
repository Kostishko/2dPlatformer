using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public List<Part> unitParts;
    public Animator animator;
    private Rigidbody2D rb;
    private List<UnitState> unitStates;
    private UnitState currentState;
    public void Start()
    {
        TryGetComponent<Animator>(out animator);
        TryGetComponent<Rigidbody2D>(out rb);
        
        foreach (UnitState item in animator.GetBehaviours<UnitState>())
        {
        //unitStates.Add(item);
        item.InitState(this);
        }       

    }



}
