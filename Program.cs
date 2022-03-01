using System;
using dotnet_poo.Entities;
using dotnet_poo.Entities.Enuns;

namespace dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
          AttackWeapon<KnightWeapons> knightWeapon = new AttackWeapon<KnightWeapons>()
          {
            weaponName = "Thor axe",
            weaponType = KnightWeapons.Axe,
            attack = 20
          };

          AttackWeapon<WizardWeapons> wizardWeapon = new AttackWeapon<WizardWeapons>()
          {
            weaponName = "Bless Staff",
            weaponType = WizardWeapons.Staff,
            attack = 40
          };

          Knight arus = new Knight("Stevem", 20, 30, 25, 15, knightWeapon);
          Wizard wizard = new Wizard("Jennica", 20, 22, 18, 28, wizardWeapon);

          Console.WriteLine(arus.Attack(135, 40, 30));
          Console.WriteLine(wizard.Attack(140, 40, 20));
        }
    }
}
