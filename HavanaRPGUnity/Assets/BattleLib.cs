using HavanaRPG.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//

namespace HavanaRPG.Model
{  
    class BattleLib
    {
        public static Player TempPlayer = new Player("", HavanaLib.ClassNames.Warrior, HavanaLib.Gender.None); //usado durante uma batalha
        public static Player BeforeBattlePlayer = new Player("", HavanaLib.ClassNames.Warrior, HavanaLib.Gender.None); //salva o estado atual do player antes da batalha, caso precise voltar os dados depois

        public static bool CheckIsDeath(decimal hp)
        {
            if (hp <= 0)
            {
                return true;
            }
            return false;
        }

        public static decimal DoAttack(decimal atkPts, decimal def, decimal hp, HavanaLib.AdvDvd enemyAdvDvd)
        {
            decimal finalHp = 0;
            decimal totalAtkPts = 0;
            try
            {
                totalAtkPts = atkPts;
                finalHp = hp;
                if (enemyAdvDvd == HavanaLib.AdvDvd.Resistance)
                {
                    totalAtkPts = Math.Floor(atkPts + (atkPts * (decimal)0.5));
                }
                else if (enemyAdvDvd == HavanaLib.AdvDvd.Advantage)
                {
                    totalAtkPts = Math.Floor(atkPts + (atkPts * (decimal)0.25));
                }
                else if (enemyAdvDvd == HavanaLib.AdvDvd.Disadvantage)
                {
                    totalAtkPts = Math.Floor(atkPts - (atkPts * (decimal)0.25));
                }
                else if (enemyAdvDvd == HavanaLib.AdvDvd.Weakness)
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
                HavanaLib.MsgBox("Error applying function: 'DoAttack' \n" + ex.Message);
                return hp;
            }
            return finalHp;
        }
        
        //Temp Player//
        public static void IncreasePlayerStatTemp(decimal value, HavanaLib.StatsNames stat)
        {
            switch (stat)
            {
                case HavanaLib.StatsNames.Strenght:
                    TempPlayer.Strenght += value;
                    break;

                case HavanaLib.StatsNames.Magic:
                    TempPlayer.Magic += value;
                    break;

                case HavanaLib.StatsNames.Dexterity:
                    TempPlayer.Dexterity += value;
                    break;

                case HavanaLib.StatsNames.Creativity:
                    TempPlayer.Creativity += value;
                    break;

                case HavanaLib.StatsNames.Winsdom:
                    TempPlayer.Winsdom += value;
                    break;
            }
        }

        public static void TempPlayerLoseHP(decimal lostValue)
        {
            var hp = TempPlayer.HealthPts;
            hp = hp - lostValue;
            if (hp < 0)
            {
                hp = 0;
            }
            TempPlayer.HealthPts = hp;
        }

        public static void TempPlayerGainHp(decimal value)
        {
            var hp = TempPlayer.HealthPts;
            hp = hp + value;
            if (hp > TempPlayer.MaxHealthPts)
            {
                hp = TempPlayer.MaxHealthPts;
            }
            TempPlayer.HealthPts = hp;
        }


        public static void TempPlayerLoseEnergy(decimal energyValue)
        {
            var ep = TempPlayer.EnergyPts;
            ep = ep - energyValue;
            if (ep < 0)
            {
                ep = 0;
            }
            TempPlayer.EnergyPts = ep;
        }

        public static void TempPlayerGainEnergy(decimal value)
        {
            var ep = TempPlayer.EnergyPts;
            ep = ep + value;
            if (ep > TempPlayer.MaxEnergyPts)
            {
                ep = TempPlayer.MaxEnergyPts;
            }
            TempPlayer.EnergyPts = ep;
        }


        //Real Player//
        public static void IncreasePlayerStatReal(decimal value, HavanaLib.StatsNames stat)
        {
            switch (stat)
            {
                case HavanaLib.StatsNames.Strenght:
                    GameController.GamePlayer.Strenght += value;
                    break;

                case HavanaLib.StatsNames.Magic:
                    GameController.GamePlayer.Magic += value;
                    break;

                case HavanaLib.StatsNames.Dexterity:
                    GameController.GamePlayer.Dexterity += value;
                    break;

                case HavanaLib.StatsNames.Creativity:
                    GameController.GamePlayer.Creativity += value;
                    break;

                case HavanaLib.StatsNames.Winsdom:
                    GameController.GamePlayer.Winsdom += value;
                    break;
            }
        }

        public static void RealPlayerLoseHP(decimal lostValue)
        {
            var hp = GameController.GamePlayer.HealthPts;
            hp = hp - lostValue;
            if (hp < 0)
            {
                hp = 0;
            }
            GameController.GamePlayer.HealthPts = hp;
        }

        public static void RealPlayerGainHp(decimal value)
        {
            var hp = GameController.GamePlayer.HealthPts;
            hp = hp + value;
            if (hp > GameController.GamePlayer.MaxHealthPts)
            {
                hp = GameController.GamePlayer.MaxHealthPts;
            }
            GameController.GamePlayer.HealthPts = hp;
        }


        public static void RealPlayerLoseEnergy(decimal energyValue)
        {
            var ep = GameController.GamePlayer.EnergyPts;
            ep = ep - energyValue;
            if (ep < 0)
            {
                ep = 0;
            }
            GameController.GamePlayer.EnergyPts = ep;
        }

        public static void RealPlayerGainEnergy(decimal value)
        {
            var ep = GameController.GamePlayer.EnergyPts;
            ep = ep + value;
            if (ep > GameController.GamePlayer.MaxEnergyPts)
            {
                ep = GameController.GamePlayer.MaxEnergyPts;
            }
            GameController.GamePlayer.EnergyPts = ep;
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
            //dynamic target;
            //if (playerTarget)
            //{
            //    target = GameController.GamePlayer;
            //}
            //else
            //{
            //    target = enemy;
            //}

            //if (ability.HasBasicEffect)
            //{
            //    ability.BasicEffect();                
            //}

            //if (ability.HasSpecialEffect)
            //{
            //    ability.SpecialEffect();
            //}
            
            //if (ability.HasStatusModifier)
            //{
            //    ability.AddRemoveStatus();
            //}
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

        public static void RealPlayerUseDefend()
        {
            decimal defPts = GameController.GamePlayer.DefensePts;
            defPts = defPts + (defPts * (decimal)0.5);
            GameController.GamePlayer.CurrentDefPts = defPts;
        }

        public static void OnBattleStart()
        {
            BeforeBattlePlayer = GameController.GamePlayer;
            TempPlayer = GameController.GamePlayer;
        }

        public static void OnBattleEnd()
        {
            GameController.GamePlayer.HealthPts = TempPlayer.HealthPts;
            GameController.GamePlayer.EnergyPts = TempPlayer.EnergyPts;
        }

        public static void RestoreAllStats()
        {
            GameController.GamePlayer.Strenght = GameController.GamePlayer.MaxStrenght;
            GameController.GamePlayer.Dexterity = GameController.GamePlayer.MaxDexterity;
            GameController.GamePlayer.Magic = GameController.GamePlayer.MaxMagic;
            GameController.GamePlayer.Creativity = GameController.GamePlayer.MaxCreativity;
            GameController.GamePlayer.Winsdom = GameController.GamePlayer.MaxWinsdom;
            GameController.GamePlayer.StatusEffects.Clear();
            GameController.GamePlayer.CurrentDefPts = GameController.GamePlayer.DefensePts;
        }

    }
}
