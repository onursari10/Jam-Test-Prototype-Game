using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUpItem : MonoBehaviour
{
    public static float TheDistance;
    public GameObject ActionText;
    public string itemName;
    public GameObject crystal;
    public GameObject GuideArrow;
    public GameObject ExtraCross;

    public GameObject player;

    void Start()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;

    }


    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "KALDIRMAK İÇİN BAS [E] " + itemName;
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionText.SetActive(false);
                crystal.SetActive(false);
                ExtraCross.SetActive(false);
            }
        }
    }


    void OnMouseExit()
    {
        ActionText.SetActive(false);
        ExtraCross.SetActive(false);
    }

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }
}
