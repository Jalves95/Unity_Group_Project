using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishArea : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("UIManager").SendMessage("Finish"); 
    }
}
