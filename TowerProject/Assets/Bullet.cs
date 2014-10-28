using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public Vector3 origin;
	public Transform target;
	public float lifespan;
	public float startTime;

	public static Bullet Instantiate(float bulletSpeed, Vector3 _origin, Transform _target) {
		Bullet bullet = (Bullet)GameObject.Instantiate(BulletController.s_bulletPrefab, _origin, _target.rotation);
		bullet.origin = _origin;
		bullet.target = _target;
		bullet.startTime = Time.time;

		float lifespan = Vector3.Distance(_origin, _target.position) / bulletSpeed;
		bullet.lifespan = lifespan;

		return bullet;
	}

	void Update() {
		handleMovement();
		handleImpact();
	}

	void handleMovement() {
		print(lifespan);
		float progress = (Time.time - startTime) / lifespan;
		Vector3 movement =  (target.position - origin) * progress;
		transform.position = origin + movement;
	}

	void handleImpact() {
		if (Time.time - startTime > lifespan) {
			impact();
		}
	}

	void impact() {
		Destroy(gameObject);
	}
}
