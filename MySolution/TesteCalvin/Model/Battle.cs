﻿using HavanaRPG.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavanaRPG.Model
{
    class Battle
    {
        public string Description { get; set; }
        public List<Creature> Enemys { get; set; } //inicialmente limitar a 3
        public Form SpecificView { get; set; }

        public Battle()
        {
            //SpecificView = new BattleView();
            Description = "";
        }

        public virtual void OnStartBattle()
        {
            ViewsController.CloseForm(ViewsController._MainContainerView.ActiveMdiChild);
            ViewsController.OpenNewForm(SpecificView);
        }

        public virtual void OnEndBattle()
        {
            foreach(var enemy in Enemys)
            {
                var enemyName = enemy.Name;
                var xp = enemy.ExperienceGiven;
                GameplayLib.ShowLogStatusMsg(enemyName + " XP recompense: " + xp);
                GameplayLib.GamePlayer.OnXpGain(xp);
                if (enemy.Recompenses != null && enemy.Recompenses.Count > 0)
                {
                    foreach (var item in enemy.Recompenses)
                    {
                        GameplayLib.ShowLogStatusMsg(enemyName + " item recompense: " + item.ItemName);
                        GameplayLib.GamePlayer.BackpackEquips.Add(item);
                    }
                    GameplayLib.GamePlayer.AdjustCarryingWeight();
                }
            }
            ViewsController.CloseForm(SpecificView);
            ViewsController.OpenNewForm(ViewsController.LastForm);
        }
    }
}
