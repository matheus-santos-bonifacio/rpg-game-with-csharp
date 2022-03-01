namespace dotnet_poo.Entities
{
  public abstract class Hero<WeaponType> : Entity<WeaponType>
  {
    public override string ToString()
    {
      return $"{this.name} {this.level}";
    }

    public string Attack(int enemyLife, int enemyResistance, int enemyVelocity)
    {
      int totalAttack = this.attack + this.attackWeapon.attack - enemyResistance;

      if (this.velocity > enemyVelocity)
        return $@"
        {this.name} ataca primeiro e deu um dano de {totalAttack}
        com {this.attackWeapon.weaponName}";
      else
        return $@"
          inimigo ataca primeiro {this.name},
          no final {this.name} da um dano de {totalAttack} com {this.attackWeapon.weaponName}";
     }
  }
}
