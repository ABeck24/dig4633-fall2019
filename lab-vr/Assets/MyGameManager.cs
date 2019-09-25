using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool handlePickedUp = false;
    public bool bucketFilled = false;
    public bool byWell = false;

    
    public void PickupHandle()
    {
        this.handlePickedUp = true;
        Debug.Log("Nice Job, Buckeroo");
    }
    public void IsPlayerByWell(){
        this.byWell = true;
        Debug.Log("Water you waiting for?");
    }

    public void checkForEnd(){
        if(handlePickedUp = true &&  byWell == true){
            Debug.Log("You did it!");
        }

    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
