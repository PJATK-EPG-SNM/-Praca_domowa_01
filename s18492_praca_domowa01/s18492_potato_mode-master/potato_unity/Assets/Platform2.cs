using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2 : MonoBehaviour
{
Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody2D>();
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
     {
      if(collision.gameObject.name.Equals("player"))
      {
      Invoke("FallPlatform",2f);
      Destroy(gameObject, 2f);
	  }
	 }
  void FallPlatform()
  {
  rb.isKinematic = false;
  }

   
}
