using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShooterProject.Models
{
    internal class ShooterManager
    {
        private readonly string MenuTitle = "**************      MENU     ************\n" +
                                            "C - if you want create Weapon\n" +
                                            "0 - If you want get Info About waepon\n" +
                                            "1 - If you want to Shoot\n" +
                                            "2 _ if you want to want how many bullets you need\n" +
                                            "3 - If you want reload\n" +
                                            "4 - If you want change Fire Mode\n" +
                                            "5 - If you want to stop\n";

        private string[] CreateMenu =
        {
            "Write max bullet count of your weapon",
            "Write your existence bullet count",
            "Write you weapon shooting time with full magazine",
            "Write your fire method S/M"
        };

        public void Menu()
        {
            byte menucount = 0;
            Weapon weapon = null;
            bool repit = true;
            while (repit)
            {
                if (menucount == 5) { Console.Clear(); }
                Console.WriteLine(MenuTitle);
                string input = Console.ReadLine();
                if (input.ToLower() == "c")
                {
                    weapon = CreateWeapon();
                    
                }

                if (input == "0")
                {
                    if (weapon != null)
                    {
                        WriteInfo(weapon);
                        menucount++;
                    }
                }

                if (input == "1")
                {
                    if (weapon != null)
                    {
                        weapon.Fire();
                        menucount++;
                    }
                }

                if (input == "2")
                {
                    if (weapon != null) 
                    { 
                        weapon.GetRemainBulletCount();
                        menucount++;
                    }
                    
                }

                if (input == "3")
                {
                    if (weapon != null)
                    {
                        weapon.Reload();
                        menucount++;
                    }
                }

                if (input == "4")
                {
                    if (weapon != null)
                    {
                        weapon.ChangeFireMode();
                        menucount++;
                    }
                }

                if (input == "5")
                {
                    repit = false;
                    
                }
            }
        }

        public Weapon CreateWeapon()
        {
            int maxBullet;
            while (true)
            {
                Console.WriteLine(CreateMenu[0]);
                maxBullet = Convert.ToInt32(Console.ReadLine());
                if (maxBullet > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("wrong input");
                }
            }
            

            int bulletE;
            while (true)
            {
                Console.WriteLine(CreateMenu[1]);
                bulletE = Convert.ToInt32(Console.ReadLine());
                if (bulletE > maxBullet)
                {
                    Console.WriteLine("Not enought place, write again");
                }
                else
                {
                    break;
                }
            }
            
            

            Console.WriteLine(CreateMenu[2]);
            int fireTime = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CreateMenu[3]);
            string FireInput = Console.ReadLine();
            bool mode = false;
            if (FireInput.ToLower() == "m")
            {
                mode = true;
            }

            var weapon = new Weapon(maxBullet, bulletE, fireTime, mode);
            return weapon;
        }

        public void WriteInfo(Weapon weapon)
        {
            Console.WriteLine($"weapon magazine max bullet - {weapon.MaxBullet}" +
                                          $"weapon existence bullet count - {weapon.BulletNow}" +
                                          $"shooting time with full magazine - {weapon.FullShootingTime}" +
                                          $"fire method - {weapon.ShootingTipe}");
            
        }
    }

   
}
