using UnityEngine;
using System.Collections;

public class TileTouch : MonoBehaviour {

    public Camera worldCamera;
    public BoxCollider2D boxCollider;
    public GameObject player;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            print(Input.mousePosition.x + ", " + Input.mousePosition.y);
            Vector3 asdf = Input.mousePosition;
            asdf.z = 7.0f;
            print(Camera.main.ScreenToWorldPoint(asdf));
            player.transform.position = Camera.main.ScreenToWorldPoint(asdf);
        }

    }
}
