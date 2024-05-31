using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ep_2_Script : MonoBehaviour
{
    [SerializeField]
    private GameObject ep;

    public void OnClick()
    {
        this.ep.SetActive(true);
    }
}
