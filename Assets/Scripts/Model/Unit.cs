using System;
using UnityEngine;

public class Unit : Block
{
    int _hp;
    int _power;

    public int HP { 
        get { return _hp; }
        private set {
            _hp = value;
            _hp = Mathf.Clamp(value,0, Constants.Instance.MaxUnitHP);
        }
    }
    public int Power {
        get { return _power; }
        private set {
            _power = value;
            _power = Mathf.Clamp(value, 0, Constants.Instance.MaxUnitHP);
        }
    }

    public Genome Genome { get; private set; }

    public Unit()
    {
        Genome = new Genome();
        HP = Constants.Instance.DefaultUnitHP;
        Power = Constants.Instance.DefaultUnitPower;
    }

    public void Update()
    {

    }

    public void Eat(Food food)
    {
        if (food != null) {
            HP += food.hpBonus;
            food.Destroy();
        }
    }

    public void Rest()
    {
        Power += 10;
    }
}