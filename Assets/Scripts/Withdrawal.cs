using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Withdrawal : MonoBehaviour
{
    // Start is called before the first frame update
    Gamemanager gamemanager;
    public TMP_InputField textm_;

    void Start()
    {
        gamemanager = Gamemanager.instance;
    }

    public void OnClickBack()
    {
        gamemanager.Back();
    }

    public void OnClickWithdrawal(int num)
    {
        gamemanager.SetWithdrawal(num);
    }

    public void OnClickInputText()
    {
        int num = int.Parse(textm_.text);
        gamemanager.SetWithdrawal(num);
    }
}
