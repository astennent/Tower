using UnityEngine;
using System.Collections;

public class TowerClickHandler : MonoBehaviour {
	private Tower tower;
	void Start() {
		tower = transform.parent.GetComponent<Tower>();
	}

	void OnMouseDown() {
		SelectionController.OnClickTower(tower);
	}
}
