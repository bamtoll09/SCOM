using UnityEngine;
using System.Collections;

public class MapManager : MonoBehaviour {

    public int tile_width = 0;
    public int tile_height = 0;
    public GameObject[,] tiles;

	// Use this for initialization
    void Start() {
        tiles = new GameObject[tile_width, tile_height];
        //new MapMaker(tile_width, tile_height);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
