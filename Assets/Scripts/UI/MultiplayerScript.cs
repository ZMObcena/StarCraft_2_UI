using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject multiplayer;

    public void OnClick()
    {
        this.multiplayer.SetActive(true);
    }
}
