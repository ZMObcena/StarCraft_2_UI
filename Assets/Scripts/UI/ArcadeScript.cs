using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeScript : MonoBehaviour
{
    [SerializeField]
    private GameObject arcade;

    public void OnClick()
    {
        this.arcade.SetActive(true);
    }
}
