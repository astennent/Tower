using UnityEngine;
using System.Collections;

public class TowerController : MonoBehaviour {

	static Tower[,] towers;

	public Tower towerPrefab;
	public static Tower s_towerPrefab;

	// Use this for initialization
	void Start () {
		s_towerPrefab = towerPrefab;
		towers = new Tower[9,9];
		addTower(3, 5);
	}

	static Tower addTower(int x, int z) {
		if (towers[x,z] != null) {
			Debug.LogError("Overwriting a tower.");
		}

		Tower tower = Tower.Instantiate(x, z);
		towers[x,z] = tower;
		return tower;
	}

}
