using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

	int experience = 0;
	float baseDamage = 10f;

	float timeBetweenShots = 2f;
	float bulletSpeed = 4f;
	float range = 3.5f;
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
		Transform target = GameObject.FindGameObjectsWithTag("PracticeTarget")[0].transform;
		bool isValidTarget = (isInRange(target) && isInLOS(target));
		if (isValidTarget) {
			return target;
		}
		return null;
	}

	bool isInRange(Transform target) {
		float dist = Vector3.Distance(target.position, transform.position);
		return (dist <= range);
	}

	bool isInLOS(Transform target) {
		RaycastHit hit;
		Vector3 direction = target.transform.position - transform.position;
		if (Physics.Raycast(transform.position, direction.normalized, out hit)) {
			return (hit.collider.transform == target);
		}
		return false;
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

		Vector3 bulletPositionAdjust = 1 * Vector3.up;
		Bullet.Instantiate(bulletSpeed, transform.position + bulletPositionAdjust, target);
		lastShotTime = Time.time;
	}

}
