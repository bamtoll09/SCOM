using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileTouch : MonoBehaviour {

	public Sprite tile;
	public Sprite tile_onMouse;

	RaycastHit hit;
	SpriteRenderer sr = null;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (Input.GetMouseButton(0))
        {
			if (Physics.Raycast(ray, out hit)) // 충돌 했을 때(true, false) 값을 hit에 넣어줌
			{
				Debug.Log(hit.collider.name);
			}
		}

		if (Physics.Raycast(ray, out hit)) // 충돌 했을 때(true, false) 값을 hit에 넣어줌
		{
			if (sr != null)
				sr.sprite = tile;

			sr = hit.transform.GetComponent<SpriteRenderer>();
			sr.sprite = tile_onMouse;
		}
    }
}
