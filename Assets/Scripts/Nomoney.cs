using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nomoney : MonoBehaviour
{
    public void OnClick()
    {
        SetActives(false);
    }

    public void SetActives(bool isactive)
    {
        gameObject.SetActive(isactive);
    }
}
