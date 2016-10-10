using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileTouch : MonoBehaviour {

    public Camera worldCamera;
    public BoxCollider2D boxCollider;
    public GameObject player;
    public GameObject tile;
    List<BoxCollider2D> collider = new List<BoxCollider2D>();
    Transform trans;

	// Use this for initialization
	void Start () {
        for (int i=0; i<tile.GetComponents<BoxCollider2D>().Length; i++)
        {
            collider.Add(tile.GetComponents<BoxCollider2D>()[i]);
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0))
        {
            //print(Input.mousePosition.x + ", " + Input.mousePosition.y);
            //Vector3 asdf = Input.mousePosition;
            //asdf.z = 7.0f;
            //print(Camera.main.ScreenToWorldPoint(asdf));
            //player.transform.position = Camera.main.ScreenToWorldPoint(asdf);
            //player.transform.LookAt(Camera.main.transform);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            hit.transform.LookAt(Camera.main.transform);
            
        }

    }
}
