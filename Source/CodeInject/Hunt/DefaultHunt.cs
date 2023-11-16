﻿using CodeInject.Actors;
using CodeInject.MemoryTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CodeInject.Hunt
{
    [Serializable]
    public unsafe class DefaultHunt : EmptyHuntSetting
    {
        public int SkillIndex = 0;
        public IObject Target;
        public Vector3 HuntingAreaCenter { get; set; }

        public int Radius { get; set; } = 50;
        private cBot WinFormMenu;
        public DefaultHunt()
        {
        }

        public DefaultHunt(List<MobInfo> monstersToAttackList, Vector3 huntingAreaCenter, int radius, List<Skills> skillList,bool normalAttack, cBot WinForm)
        {
            HuntingAreaCenter = huntingAreaCenter;
            Radius = radius;
            ListOfMonstersToAttack = monstersToAttackList;
            WinFormMenu = WinForm;
            BotSkills = skillList;
            NormalAttack = normalAttack;
            Target = null;
        }

        public override void AddSkill(Skills skill, SkillTypes type)
        {
            base.AddSkill(skill, type);
            WinFormMenu.SkillListUpdate();
        }

        public override void RemoveSkill(Skills skill)
        {
            base.RemoveSkill(skill);
            WinFormMenu.SkillListUpdate();
        }

        public override void Update()
        {
            if (this.SkillIndex < this.BotSkills.Count - 1)
            {
                this.SkillIndex++;
            }
            else
            {
                this.SkillIndex = 0;
            }

            Player player = GameFunctionsAndObjects.DataFetch.GetPlayer();
            List<ushort> buffs = player.GetBuffsIDs();
            List<Skills> BotBuff2Use = BotSkills.Where(x => x.SkillType == SkillTypes.Buff && !buffs.Any(b => b == x.skillInfo.ID)).ToList();

            if (BotBuff2Use.Count > 0)
            {
                GameFunctionsAndObjects.Actions.CastSpell(GetSkillIndex(BotBuff2Use.FirstOrDefault().skillInfo.ID));
                Thread.Sleep(100);
            }
            else
            {
                if (Target == null || !GameFunctionsAndObjects.DataFetch.GetNPCs().Where(x => x.GetType() == typeof(NPC)).Any(x => (long)x.ObjectPointer == (long)Target.ObjectPointer) || *((NPC)Target).Hp <= 0)
                {
                    this.Target = GameFunctionsAndObjects.DataFetch.GetNPCs().Where(x => x.GetType() == typeof(NPC))
                    .Where(x => ListOfMonstersToAttack.Cast<MobInfo>().Any(y => ((NPC)x).Info != null && y.ID == ((NPC)x).Info.ID))
                    .Where(x => ((NPC)x).CalcDistance(HuntingAreaCenter.X, HuntingAreaCenter.Y, HuntingAreaCenter.Z) < Radius).FirstOrDefault(x => *(((NPC)x).Hp) > 0);
                }


                if (this.Target == null)
                {
                    GoToHuntingAreaCenter();
                    return;
                }

                if (this.BotSkills.Count > 0)
                {
                    Skills Skill2Cast = PlayerCharacter.GetPlayerSkills.FirstOrDefault(x => x.skillInfo.ID == this.BotSkills[this.SkillIndex].skillInfo.ID);
                    if (this.BotSkills[this.SkillIndex].SkillType == SkillTypes.AttackSkill)
                    {
                        GameFunctionsAndObjects.Actions.CastSpell(*this.Target.ID, GetSkillIndex(Skill2Cast.skillInfo.ID));
                    }
                }
                if(NormalAttack == true)
                  GameFunctionsAndObjects.Actions.Attack(*this.Target.ID);
            }
        }
 


        private void GoToHuntingAreaCenter()
        {
            if (((int)*GameFunctionsAndObjects.DataFetch.GetPlayer().X) != (int)HuntingAreaCenter.X &&
                 ((int)*GameFunctionsAndObjects.DataFetch.GetPlayer().Y) != (int)HuntingAreaCenter.Y)
            {
                GameFunctionsAndObjects.Actions.MoveToPoint(new Vector2(HuntingAreaCenter.X / 100, HuntingAreaCenter.Y / 100));
            }
        }
    }
}
