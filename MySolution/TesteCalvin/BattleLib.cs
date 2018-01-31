using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanaRPG.Model
{
    class BattleLib
    {
        public static bool CheckIsDeath(decimal hp)
        {
            if (hp <= 0)
            {
                return true;
            }
            return false;
        }

        public static decimal DoAttack(decimal atkPts, decimal def, decimal hp, HavanaLib.AdvDvd EnemyAdvDvd)
        {
            decimal finalHp = 0;
            decimal totalAtkPts = 0;
            try
            {
                totalAtkPts = atkPts;
                finalHp = hp;
                if (EnemyAdvDvd == HavanaLib.AdvDvd.Resistance)
                {
                    totalAtkPts = Math.Floor(atkPts + (atkPts * (decimal)0.5));
                }
                else if (EnemyAdvDvd == HavanaLib.AdvDvd.Advantage)
                {
                    totalAtkPts = Math.Floor(atkPts + (atkPts * (decimal)0.25));
                }
                else if (EnemyAdvDvd == HavanaLib.AdvDvd.Disadvantage)
                {
                    totalAtkPts = Math.Floor(atkPts - (atkPts * (decimal)0.25));
                }
                else if (EnemyAdvDvd == HavanaLib.AdvDvd.Weakness)
                {
                    totalAtkPts = Math.Floor(atkPts - (atkPts * (decimal)0.5));
                }
                else
                {
                    totalAtkPts = atkPts;
                }

                if (totalAtkPts > def)
                {
                    finalHp = finalHp - (totalAtkPts - def);
                    if (finalHp < 0)
                    {
                        finalHp = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                HavanaLib.MsgBox("Erro ao aplicar a função 'DoAttack' \n" + ex.Message);
                return hp;
            }
            return finalHp;
        }

        public static void PlayerLoseHp(decimal lostValue)
        {
            var hp = RpgLib.GamePlayer.HealthPts;
            hp = hp - lostValue;
            if (hp < 0)
            {
                hp = 0;
            }
            RpgLib.GamePlayer.HealthPts = hp;
        }

        public static void PlayerGainHp(decimal value)
        {
            var hp = RpgLib.GamePlayer.HealthPts;
            hp = hp + value;
            if (hp > RpgLib.GamePlayer.MaxHealthPts)
            {
                hp = RpgLib.GamePlayer.MaxHealthPts;
            }
            RpgLib.GamePlayer.HealthPts = hp;
        }


        public static void PlayerLoseEnergy(decimal energyValue)
        {
            var ep = RpgLib.GamePlayer.EnergyPts;
            ep = ep - energyValue;
            if (ep < 0)
            {
                ep = 0;
            }
            RpgLib.GamePlayer.EnergyPts = ep;
        }

        public static void PlayerGainEnergy(decimal value)
        {
            var ep = RpgLib.GamePlayer.EnergyPts;
            ep = ep + value;
            if (ep > RpgLib.GamePlayer.MaxEnergyPts)
            {
                ep = RpgLib.GamePlayer.MaxEnergyPts;
            }
            RpgLib.GamePlayer.EnergyPts = ep;
        }

        public static void UseAbility(Ability ability)
        {
            UseAbility(ability, null, false);
        }

        public static void UseAbility(Ability ability, Creature enemy)
        {
            UseAbility(ability, enemy, false);
        }

        public static void UseAbility(Ability ability, Creature enemy, bool playerTarget)
        {
            dynamic target;
            if (playerTarget)
            {
                target = RpgLib.GamePlayer;
            }
            else
            {
                target = enemy;
            }

            if (ability.HasBasicEffect)
            {
                ability.BasicEffect();                
            }

            if (ability.HasSpecialEffect)
            {
                ability.SpecialEffect();
            }
            
            if (ability.HasStatusModifier)
            {
                ability.AddRemoveStatus();
            }
        }

        public static void UseWeapon(Item weapon, Creature target, bool playerTarget)
        {
            if (weapon.HasSpecialEffect)
            {
                weapon.OnSpecialEffect();
            }

            if (weapon.DiceRolls > 0 && weapon.DiceSides > 0)
            {

            }
        }

        public static void UseDefend()
        {
            decimal defPts = RpgLib.GamePlayer.DefensePts;
            defPts = defPts + (defPts * (decimal)0.5);
            RpgLib.GamePlayer.CurrentDefPts = defPts;
        }

        public static void OnBattleStart()
        {

        }

        public static void OnBattleEnd()
        {
        }

        public static void RestoreAllStats()
        {
            RpgLib.GamePlayer.Strenght = RpgLib.GamePlayer.MaxStrenght;
            RpgLib.GamePlayer.Dexterity = RpgLib.GamePlayer.MaxDexterity;
            RpgLib.GamePlayer.Magic = RpgLib.GamePlayer.MaxMagic;
            RpgLib.GamePlayer.Creativity = RpgLib.GamePlayer.MaxCreativity;
            RpgLib.GamePlayer.Winsdom = RpgLib.GamePlayer.MaxWinsdom;
            RpgLib.GamePlayer.StatusEffects.Clear();
            RpgLib.GamePlayer.CurrentDefPts = RpgLib.GamePlayer.DefensePts;
        }

    }
}
