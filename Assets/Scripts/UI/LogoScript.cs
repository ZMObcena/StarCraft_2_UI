using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoScript : MonoBehaviour
{
    [SerializeField]
    private GameObject logo;

    public void OnClick()
    {
        this.logo.SetActive(true);
    }
}
