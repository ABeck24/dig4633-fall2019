using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject WellSpindle;
    public GameObject WellWellWell;
    public GameObject HintMessage;
    private Component[] Renderers;
    public bool spindleOn = false;



    public void AllDone()
    {
        //if (spindleOn == true)
        //{
            HintMessage.GetComponent<TextMeshPro>().SetText("You got the water! The End [fade to black]");
            Debug.Log("Spin Spin Sugar");
       // }
    }

    public void HandleOn(){

        spindleOn = true;
        WellSpindle.SetActive(false);
        foreach (Renderer on in Renderers)
        {
            on.enabled = true;
        }
        Debug.Log("You did it!");
        HintMessage.GetComponent<TextMeshPro>().SetText("Good Job! Now Turn the Handle to get water!");

    }
    
    void Start()
    {
        Renderers = WellWellWell.GetComponentsInChildren<Renderer>();
        foreach (Renderer on in Renderers)
        {
            on.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
