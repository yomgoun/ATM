using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Withdrawal : MonoBehaviour
{
    // Start is called before the first frame update
    Gamemanager gamemanager;

    void Start()
    {
        gamemanager = Gamemanager.instance;
    }

    public void OnClickBack()
    {
        gamemanager.Back();
    }
}
