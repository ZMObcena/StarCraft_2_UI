using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayScript : MonoBehaviour
{
    [SerializeField]
    private GameObject replay;

    public void OnClick()
    {
        this.replay.SetActive(true);
    }
}
