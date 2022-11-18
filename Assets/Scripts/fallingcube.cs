using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingcube : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision) 
    {

      // when collides with Floor
      //print("Ouch the Floor");
      // deletes any gameObject upon collision
      // Destroy(collision.gameObject);

      // destroys player gameObject upon collision

      if(collision.gameObject.name == "Dummy")
      {
      Destroy(collision.gameObject);
      print("ouch i hit " + collision.gameObject.tag);
      }  
    }
}
