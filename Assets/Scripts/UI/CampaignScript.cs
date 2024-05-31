using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampaignScript : MonoBehaviour
{
    [SerializeField]
    private GameObject campaign;

    public void OnClick()
    {
        this.campaign.SetActive(true);
    }
}
