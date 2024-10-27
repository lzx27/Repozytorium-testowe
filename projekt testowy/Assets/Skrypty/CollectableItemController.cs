using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CollectableItemController : MonoBehaviour
{
    public PlayerControl playercontroller;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
     

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playercontroller.zebranePunkty++;
            Debug.Log(playercontroller.zebranePunkty);

            Destroy(this.gameObject);
           

        }
    }
}   
    
 