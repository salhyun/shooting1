﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	public Transform muzzle;
	public Projectile projectile;
	public float msBetweenShots = 100.0f;
	public float muzzleVelocity = 35.0f;

	float nextShotTime;

	public void Shoot()
	{
		if (Time.time > nextShotTime) {

			Projectile newProjectile = Instantiate (projectile, muzzle.position, muzzle.rotation) as Projectile;
			newProjectile.setSpeed (muzzleVelocity);

			nextShotTime = Time.time + msBetweenShots / 1000.0f;

		}
	}

}
