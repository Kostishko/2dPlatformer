using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameController<T> 
{
    private static T controller;

    public static void SetController (T c)
    {
        controller = c;
    }

    public static T GetController()
    {
        return controller;
    }

}
