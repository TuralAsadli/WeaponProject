using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShooterProject.Models
{
    internal class Weapon
    {
        public int MaxBullet { get; set; }

        public int BulletNow { get; set; }

        public int FullShootingTime { get; set; }

        public bool ShootingTipe { get; set; }

        public Weapon(int maxBullet, int bulletNow, int fullShootingTime, bool shootingType)
        {
            MaxBullet = maxBullet;
            BulletNow = bulletNow;
            FullShootingTime = fullShootingTime;
            ShootingTipe = shootingType;

        }

        public void Shoot()
        {
            if (ShootingTipe == true)
            {
                if (BulletNow > 0)
                {
                    Fire();
                    Console.WriteLine("Weapon is empty");
                }
                else
                {
                    Console.WriteLine("Weapon is empty");
                }
            }
            else
            {
                if (BulletNow > 0)
                {
                    BulletNow = BulletNow - 1;
                    Console.WriteLine($"Now you have {BulletNow}");
                }
                else
                {
                    Console.WriteLine("Weapon is empty");
                }
                
            }
            
        }

        public void Fire()
        {
            var time = MaxBullet / FullShootingTime * BulletNow;
            BulletNow = 0;
            Console.WriteLine(time);
        }

        public void GetRemainBulletCount()
        {
            Console.WriteLine(MaxBullet - BulletNow);
        }

        public void Reload()
        {
            BulletNow = MaxBullet;
            Console.WriteLine("you reoladed weapon");
        }

        public void ChangeFireMode()
        {
            ShootingTipe = !ShootingTipe;
            if (ShootingTipe == true)
            {
                Console.WriteLine("you use Fire shooting type");
            }
            if (ShootingTipe == false)
            {
                Console.WriteLine("you use Fire shooting type");
            }
        }
    }
}
