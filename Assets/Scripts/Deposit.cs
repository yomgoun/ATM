using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Deposit : MonoBehaviour
{

    Gamemanager gamemanager;
    public TMP_InputField tMP_;

    void Start()
    {
        gamemanager = Gamemanager.instance;
    }

    public void OnClickBack()
    {
        gamemanager.Back();
    }

    public void OnClickDeposit(int num)
    {
        gamemanager.SetDeposit(num);
    }

    public void OnClickInputText()
    {
        int num = int.Parse(tMP_.text);
        gamemanager.SetDeposit(num);
    }
}
