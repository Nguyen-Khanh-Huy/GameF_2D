using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PIS.PlatformGame
{
    public class FireBullet : MonoBehaviour
    {
        public Player player;
        public Transform firePoint;
        public Bullet bulletPb;

        private float _curSpeed;
        public void Fire()
        {
            if (!bulletPb || !player || !firePoint) return;
            _curSpeed = player.IsFaceLeft ? -bulletPb.speed : bulletPb.speed;
            var bulletClone = Instantiate(bulletPb, firePoint.position, Quaternion.identity);
            bulletClone.speed = _curSpeed;
            // giam SL dan xuong 1
        }
    }

}