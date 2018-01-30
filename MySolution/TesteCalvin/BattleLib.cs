using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanaRPG.Model
{
    class BattleLib
    {
        public static bool CheckIsDeath(int hp)
        {
            if (hp <= 0)
            {
                return true;
            }
            return false;
        }
        
        public static float DoAttack(int atkPts, int def, int hp, HavanaLib.AdvDvd EnemyAdvDvd)
        {
            float finalHp = 0;
            float totalAtkPts = 0;
            try
            {
                totalAtkPts = (float)atkPts;
                finalHp = (float)hp;
                if (EnemyAdvDvd == HavanaLib.AdvDvd.Resistance)
                {
                    totalAtkPts = (float)Math.Floor(atkPts + (atkPts * 0.5f));
                }
                else if (EnemyAdvDvd == HavanaLib.AdvDvd.Advantage)
                {
                    totalAtkPts = (float)Math.Floor(atkPts + (atkPts * 0.25f));
                }
                else if (EnemyAdvDvd == HavanaLib.AdvDvd.Disadvantage)
                {
                    totalAtkPts = (float)Math.Floor(atkPts - (atkPts * 0.25f));
                }
                else if (EnemyAdvDvd == HavanaLib.AdvDvd.Weakness)
                {
                    totalAtkPts = (float)Math.Floor(atkPts - (atkPts * 0.5f));
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

    }
}
