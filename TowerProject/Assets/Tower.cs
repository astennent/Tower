using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

	int experience = 0;
	float baseDamage = 0f;
	float timeBetweenShots = 2f;

	// For display purposes only.
	float getRateOfFire() {
		return 1f / timeBetweenShots;
	}

}
