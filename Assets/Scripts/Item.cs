using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public static float TheDistance;
    public GameObject ActionText;
    public string itemName;
    public GameObject item;
    public GameObject GuideArrow;
    public GameObject ExtraCross;

    public GameObject player;

    [Header("NAMES")]
    public string saatName;
    public string muzName;
    public string goldName;
    public string dollarName;
    public string etiCangaName;

    void Start()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }


    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<Text>().text = itemName + " KALDIRMAK İÇİN BAS [E] ";
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                if (itemName == saatName)
                {
                    player.GetComponent<PlayerMovementTutorial>().saatInt += 1;

                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionText.SetActive(false);
                    item.SetActive(false);
                    ExtraCross.SetActive(false);
                }

                if (itemName == dollarName)
                {
                    player.GetComponent<PlayerMovementTutorial>().dollarInt += 1;

                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionText.SetActive(false);
                    item.SetActive(false);
                    ExtraCross.SetActive(false);
                }
                if (itemName == goldName)
                {
                    player.GetComponent<PlayerMovementTutorial>().goldInt += 1;

                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionText.SetActive(false);
                    item.SetActive(false);
                    ExtraCross.SetActive(false);
                }
                if (itemName == muzName)
                {
                    player.GetComponent<PlayerMovementTutorial>().muzInt += 1;

                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionText.SetActive(false);
                    item.SetActive(false);
                    ExtraCross.SetActive(false);
                }
                if (itemName == etiCangaName)
                {
                    player.GetComponent<PlayerMovementTutorial>().etiCanga += 1;

                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionText.SetActive(false);
                    item.SetActive(false);
                    ExtraCross.SetActive(false);
                }
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
