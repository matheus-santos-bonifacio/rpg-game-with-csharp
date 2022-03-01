using System.Collections.Generic;
using dotnet_poo.Entities.Enuns;

namespace dotnet_poo.Entities
{
   public class Knight : Hero<KnightWeapons>
   {
     public Knight(string name, int level, int resistance, int attack, int velocity, AttackWeapon<KnightWeapons> attackWeapon)
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
