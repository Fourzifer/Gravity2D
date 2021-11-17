using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionStay2D(Collision2D collider)
    {
        PlayerController.charge = true;
    }

    private void OnCollisionExit2D(Collision2D collider)
    {
        PlayerController.charge = false;
    }
}