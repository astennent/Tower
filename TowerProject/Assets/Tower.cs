using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

	int experience = 0;
	float baseDamage = 10f;

	float timeBetweenShots = 2f;
	float bulletSpeed = 4f;
	float lastShotTime;

	public static Tower Instantiate(int xPosition, int zPosition) {
		Vector3 position = new Vector3(xPosition, 0, zPosition);
		Tower tower = (Tower)GameObject.Instantiate(TowerController.s_towerPrefab, position, new Quaternion(0,0,0,0));
		return tower;
	}

	// For display purposes only.
	public float getRateOfFire() {
		return 1f / timeBetweenShots;
	}

	void Update() {
		// fires a shot, if possible.
		handleFiring();
	}

	Transform findTarget() {
		return GameObject.FindGameObjectsWithTag("PracticeTarget")[0].transform;
	}

	void handleFiring() {
		bool canFire = (Time.time - lastShotTime >= timeBetweenShots);
		if (!canFire) {
			return;
		}

		Transform target = findTarget();

		if (!target) {
			return;
		}

		Bullet.Instantiate(bulletSpeed, transform.position, target);
		lastShotTime = Time.time;
	}

}
