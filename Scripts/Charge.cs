using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        Debug.Log("3");
        PlayerController.charge = true;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        Debug.Log("4");
        PlayerController.charge = false;
    }
}