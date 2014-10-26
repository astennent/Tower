using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	Bullet Instantiate(float lifeTime, Transform origin, Transform target) {
		Bullet bullet = (Bullet)GameObject.Instantiate(BulletController.s_bulletPrefab, origin.position, origin.rotation);
		return bullet;
	}
}
