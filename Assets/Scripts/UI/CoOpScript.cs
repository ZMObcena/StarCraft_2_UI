using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoOpScript : MonoBehaviour
{
    [SerializeField]
    private GameObject coop;

    public void OnClick()
    {
        this.coop.SetActive(true);
    }
}
