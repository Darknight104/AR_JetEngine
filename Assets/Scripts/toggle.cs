using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle : MonoBehaviour
{
    public GameObject jet;
    private bool isactive = true;
    public void Toggle()
    {
        if (isactive)
        {
            jet.SetActive(false);
            isactive = false;
        }
        else { 
        jet.SetActive(true);
            isactive = true;
        }
    }
}
