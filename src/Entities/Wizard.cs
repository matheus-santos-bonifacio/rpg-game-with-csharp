using dotnet_poo.Entities.Enuns;
using System.Collections.Generic;

namespace dotnet_poo.Entities
{
   public class Wizard : Hero<WizardWeapons>
   {
      public Wizard(string name, int level, int resistance, int attack, int velocity, AttackWeapon<WizardWeapons> attackWeapon)
      {
        this.name = name;
        this.level = level;
        this.resistance = resistance;
        this.attack = attack;
        this.velocity = velocity;
        this.attackWeapon = attackWeapon;

        this.weakTypes = new List<WeakTypes>()
        {
          WeakTypes.Magic,
          WeakTypes.Water
        };
      }
   } 
}
