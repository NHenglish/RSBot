﻿using RSBot.Core;
using RSBot.Core.Components;

namespace RSBot.Bot.Default.Bundle.Buff
{
    internal class BuffBundle : IBundle
    {
        /// <summary>
        /// Invokes this instance.
        /// </summary>
        public void Invoke()
        {
            if (Game.Player.Untouchable || Game.Player.HasActiveVehicle) return;

            //Imbue handling
            if (SkillManager.ImbueSkill != null &&
                Game.Player.State.GetActiveBuffBySkillId(SkillManager.ImbueSkill.Id) == null &&
                !Bundles.Loop.Running && Game.SelectedEntity != null
                && Game.SelectedEntity.Monster != null)
                Game.Player.CastBuff(SkillManager.ImbueSkill.Id);

            //Check for buffs
            var tempBuffs = SkillManager.Buffs.ToArray();

            foreach (var buff in tempBuffs)
            {
                var playerSkill = Game.Player.Skills.GetSkillInfoById(buff.Id);

                if (playerSkill == null)
                    continue;

                if (!playerSkill.CanBeCasted)
                    continue;

                if (Game.Player.State.GetActiveBuffBySkillId(buff.Id) != null)
                    continue;

                Game.Player.CastBuff(buff.Id);
            }
        }

        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        public void Refresh()
        {
            //Nothing to do here
        }
    }
}