using DRPG;

public class Character : ITurn
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int AttackPower { get; set; }

    public Character(string name, int hp, int attackPower)
    {
        Name = name;
        HP = hp;
        AttackPower = attackPower;
    }

    public void Attack(Character target)
    {
        target.HP -= AttackPower;
        if (target.HP < 0) target.HP = 0;
    }

    public void YourTurn(Character target)
    {
        Attack(target);
    }

    public override string ToString()
    {
        return $"{Name} (HP: {HP}, 攻撃力: {AttackPower})";
    }
}
