using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InOut : MonoBehaviour
{
    Gamemanager gamemanager;

    void Start()
    {
        gamemanager = Gamemanager.instance;
    }
    public void OnClickIn()
    {
        gamemanager.SetInOut(1);
    }
    public void OnClickOut()
    {
        gamemanager.SetInOut(0);
    }
}
