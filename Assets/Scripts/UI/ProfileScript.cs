using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileScript : MonoBehaviour
{
    [SerializeField]
    private GameObject profile;

    public void OnClick()
    {
        this.profile.SetActive(true);
    }
}
