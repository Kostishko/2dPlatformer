using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IdleCommand : Command
{
    private Character character;
    public IdleCommand(Character ch)
    {
        character=ch;
    }
    public override void Execute()
    {
        character.animator.SetTrigger("Idle");
          character.animator.SetFloat("Direction", 0) ;
        
    }
}


public class MovementRightCommand : Command
    {
        private Character character;
        public MovementRightCommand(Character ch)
        {
            character = ch;
        }
        public override void Execute()
        {
            character.animator.SetTrigger("Moving");
            character.animator.SetFloat("Direction", 1) ;
        }
    }

        public class MovementLeftCommand : Command
    {
        private Character character;
        public MovementLeftCommand(Character ch)
        {
            character = ch;
        }
        public override void Execute()
        {
            character.animator.SetTrigger("Moving");
            character.animator.SetFloat("Direction", -1) ;
        }
    }

