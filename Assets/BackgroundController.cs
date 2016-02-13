using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        float worldScreenHeight = Camera.main.orthographicSize * 2;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        // set height and width to same value as actual camera
        transform.localScale = new Vector3(worldScreenWidth / sr.sprite.bounds.size.x, worldScreenHeight / sr.sprite.bounds.size.y, 1);
    }
	
	// Update is called once per frame
	void Update ()
    {	
	}
}
