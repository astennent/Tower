using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	// A plane that is parallel to the grid, used for calculating click information.
	private Plane groundPlane = new Plane(Vector3.zero, new Vector3(1, 0, 0), new Vector3(0, 0, 1)); 
	
	// Update is called once per frame
	void OnMouseDown() {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		float rayDistance;

		if (groundPlane.Raycast(ray, out rayDistance)) {
			Vector3 position = ray.GetPoint(rayDistance);

			int x = (int) (position.x+.5f);
			int z = - (int) (position.z-.5f);

			SelectionController.OnClickCell(x, z);
		}
	}
}
