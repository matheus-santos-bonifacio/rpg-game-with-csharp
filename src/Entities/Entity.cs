using System.Collections.Generic;
using dotnet_poo.Entities.Enuns;

namespace dotnet_poo.Entities
{
   public abstract class Entity<WeaponType>
   {
     public string name;
     public int level;
     public int attack;
     public int resistance;
     public List<WeakTypes> weakTypes;
     public int velocity;
     public AttackWeapon<WeaponType> attackWeapon;

   }
}
