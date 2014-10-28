using UnityEngine;
using System.Collections;

public class SelectionController : MonoBehaviour {

	private static Tower selectedTower;

	public static void OnClickCell(int x, int z) {
		Debug.Log(x + "  " + z);
	}

	public static void OnClickTower(Tower tower) {
		selectedTower = tower;
		Debug.Log(selectedTower);
	}
}
