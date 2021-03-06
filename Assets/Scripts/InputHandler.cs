using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{

    public Character character;

    // should be created special class with control schem
#region Commands
private Command
doNothing,
buttonW,
buttonA,
buttonS,
buttonD,
buttonMouseLeft,
buttonMouseRight,
buttonMouseMiddle,
buttonSpace;

#endregion

    
    void Start()
    {
    GameController<InputHandler>.SetController(this);
    
    // in future: method of loading control schem
    InitCharacter(character);

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            buttonA.Execute();
        }
        if (Input.GetKey(KeyCode.D))
        {
            buttonD.Execute();
        }

        else
        {
            doNothing.Execute();
        }
    }

// bad decision, creating new commands classes every init. If it happens only on start - it's ok. But not if we can change character in game
    public void InitCharacter(Character character)
    {
        buttonA = new  MovementLeftCommand(character);
        buttonD = new MovementRightCommand(character);
        doNothing = new IdleCommand(character);
    }
}
