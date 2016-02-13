using UnityEngine;
using System.Collections;

public class DepthChrage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("Bottom"))
        {
            Debug.Log("Colided with gorund");
            //... then set the other object we just collided with to inactive.
            other.gameObject.SetActive(false); 
                       
        }
    }
}
