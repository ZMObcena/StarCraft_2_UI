using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScript : MonoBehaviour
{
    [SerializeField]
    private GameObject add;

    public void OnClick()
    {
        this.add.SetActive(true);
    }
}
