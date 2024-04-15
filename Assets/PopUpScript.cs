using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUpScript : MonoBehaviour
{
    public GameObject text;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "Placable")
        {
            text.SetActive(true);
        }if(other.gameObject.CompareTag("Placable"))
        {
            text.gameObject.SetActive(false);   
        }
    }


}
