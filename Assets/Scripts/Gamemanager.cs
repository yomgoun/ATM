using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public Deposit deposit;
    public InOut inOut;
    public Withdrawal withdrawal;
    public Nomoney nomoney;
    public int cash;
    public int balance;
    public TextMeshProUGUI cashtext;
    public TextMeshProUGUI balancetext;

    public static Gamemanager instance;

    private void Awake()
    {
        instance = this;
        UpdateUI();
    }

    public void SetInOut(int type)
    {
        inOut.gameObject.SetActive(false);

        if ( type == 0 )
        {
            withdrawal.gameObject.SetActive(true);
        }
        else
        {
            deposit.gameObject.SetActive(true);
        }

        
    }

    public void Back()
    {
        inOut.gameObject.SetActive(true);

        withdrawal.gameObject.SetActive(false);
        deposit.gameObject.SetActive(false);
    }

    public void UpdateUI()
    {
        cashtext.text = cash.ToString();
        balancetext.text = balance.ToString();
    }

    public void SetDeposit(int value)
    {
        //캐쉬가 벨류보다 크면
        if(cash >= value)
        {
            //캐쉬에서 벨류를 빼고 밸런스에 벨류만큼 더한다
            cash -= value;
            balance += value;
            UpdateUI();
        }
        else
        {
            nomoney.SetActives(true);
        }
    }

    public void SetWithdrawal(int value)
    {
        if(balance >= value)
        {
            //벨류에서 캐쉬를 빼고 밸런스에 벨류만큼 뺀다
            cash += value;
            balance -= value;
            UpdateUI();
        }
        else
        {
            nomoney.SetActives(true);
        }
    }
}
