using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public Bullet bulletPrefab;
	public static Bullet s_bulletPrefab;

	// Use this for initialization
	void Start () {
		s_bulletPrefab = bulletPrefab;
	}

}
