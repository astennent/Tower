using UnityEngine;
using System.Collections;

public class SelectionController : MonoBehaviour {

	private static Tower selectedTower;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public static void OnClickCell(int x, int z) {
		Debug.Log(x + "  " + z);
	}

	public static void OnClickTower(Tower tower) {
		selectedTower = tower;
		Debug.Log(selectedTower);
	}
}
