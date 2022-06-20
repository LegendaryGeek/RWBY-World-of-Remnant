using System;
using UnityEngine;
using VFECore.Abilities;
using Verse;

namespace RWBYRemnant
{
    public static class InitalizeAbilityAuraComp : InitalizeAbilityComp
    {
        //public Aura aura;

        static override InitalizeAbilityComp()
        {
            Aura aura;
            if (AbilityUser.health.hediffSet.HasHediff(RWBYDefOf.RWBY_SilverEyes)) // add silver eye ability if pawn has unlocked an Aura
            {
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Ability_SilverEyes)) AddPawnAbility(RWBYDefOf.Ability_SilverEyes);
            }

            if (AbilityUser.story.traits.HasTrait(RWBYDefOf.Semblance_Ruby)) // Ruby
            {
                aura = new Aura_Ruby
                {
                    pawn = AbilityUser,
                    maxEnergy = 1f,
                    currentEnergy = 1f
                };
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Ruby_BurstIntoRosePetals)) AddPawnAbility(RWBYDefOf.Ruby_BurstIntoRosePetals);
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Ruby_CarryPawn)) AddPawnAbility(RWBYDefOf.Ruby_CarryPawn);
            }
            else if (AbilityUser.story.traits.HasTrait(RWBYDefOf.Semblance_Yang)) // Yang
            {
                aura = new Aura_Yang
                {
                    pawn = AbilityUser,
                    maxEnergy = 1f,
                    currentEnergy = 1f
                };
                AddPawnAbility(RWBYDefOf.Yang_ReturnDamage);
            }
            else if (AbilityUser.story.traits.HasTrait(RWBYDefOf.Semblance_Weiss)) // Weiss
            {
                aura = new Aura_Weiss
                {
                    pawn = AbilityUser,
                    maxEnergy = 1f,
                    currentEnergy = 1f
                };
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Weiss_TimeDilationGlyph_Summon)) AddPawnAbility(RWBYDefOf.Weiss_TimeDilationGlyph_Summon);
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Weiss_SummonArmaGigas)) AddPawnAbility(RWBYDefOf.Weiss_SummonArmaGigas);
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Weiss_SummonArmaGigasSword)) AddPawnAbility(RWBYDefOf.Weiss_SummonArmaGigasSword);
            }
            else if (AbilityUser.story.traits.HasTrait(RWBYDefOf.Semblance_Blake)) // Blake
            {
                aura = new Aura_Blake
                {
                    pawn = AbilityUser,
                    maxEnergy = 1f,
                    currentEnergy = 1f
                };
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Blake_UseStoneClone)) AddPawnAbility(RWBYDefOf.Blake_UseStoneClone);
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Blake_UseIceClone)) AddPawnAbility(RWBYDefOf.Blake_UseIceClone);
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Blake_UseFireClone)) AddPawnAbility(RWBYDefOf.Blake_UseFireClone);
            }
            else if (AbilityUser.story.traits.HasTrait(RWBYDefOf.Semblance_Nora)) // Nora
            {
                aura = new Aura_Nora
                {
                    pawn = AbilityUser,
                    maxEnergy = 1f,
                    currentEnergy = 1f
                };
            }
            else if (AbilityUser.story.traits.HasTrait(RWBYDefOf.Semblance_Jaune)) // Jaune
            {
                aura = new Aura_Jaune
                {
                    pawn = AbilityUser,
                    maxEnergy = 1.5f,
                    currentEnergy = 1.5f
                };
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Jaune_AmplifyAura)) AddPawnAbility(RWBYDefOf.Jaune_AmplifyAura);
            }
            else if (AbilityUser.story.traits.HasTrait(RWBYDefOf.Semblance_Pyrrha)) // Pyrrha
            {
                aura = new Aura_Pyrrha
                {
                    pawn = AbilityUser,
                    maxEnergy = 1f,
                    currentEnergy = 1f
                };
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Pyrrha_UnlockAura)) AddPawnAbility(RWBYDefOf.Pyrrha_UnlockAura);
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Pyrrha_UseMagnetism)) AddPawnAbility(RWBYDefOf.Pyrrha_UseMagnetism);
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Pyrrha_MagneticPulse)) AddPawnAbility(RWBYDefOf.Pyrrha_MagneticPulse);
            }
            else if (AbilityUser.story.traits.HasTrait(RWBYDefOf.Semblance_Ren)) // Ren
            {
                aura = new Aura_Ren
                {
                    pawn = AbilityUser,
                    maxEnergy = 1f,
                    currentEnergy = 1f
                };
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Ren_MaskEmotions)) AddPawnAbility(RWBYDefOf.Ren_MaskEmotions);
            }
            else if (AbilityUser.story.traits.HasTrait(RWBYDefOf.Semblance_Qrow)) // Qrow
            {
                aura = new Aura_Qrow
                {
                    pawn = AbilityUser,
                    maxEnergy = 1.2f,
                    currentEnergy = 1.2f
                };
            }
            else if (AbilityUser.story.traits.HasTrait(RWBYDefOf.Semblance_Raven)) // Raven
            {
                aura = new Aura_Raven
                {
                    pawn = AbilityUser,
                    maxEnergy = 1.2f,
                    currentEnergy = 1.2f
                };
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Raven_FormBond)) AddPawnAbility(RWBYDefOf.Raven_FormBond);
            }
            else if (AbilityUser.story.traits.HasTrait(RWBYDefOf.Semblance_Cinder)) // Cinder
            {
                aura = new Aura_Cinder
                {
                    pawn = AbilityUser,
                    maxEnergy = 1.2f,
                    currentEnergy = 1.2f
                };
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Cinder_ShootFireCrystal)) AddPawnAbility(RWBYDefOf.Cinder_ShootFireCrystal);
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Cinder_SummonExplosives)) AddPawnAbility(RWBYDefOf.Cinder_SummonExplosives);
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Cinder_CreateBlades)) AddPawnAbility(RWBYDefOf.Cinder_CreateBlades);
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Cinder_CreateBow)) AddPawnAbility(RWBYDefOf.Cinder_CreateBow);
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Cinder_CreateScimitar)) AddPawnAbility(RWBYDefOf.Cinder_CreateScimitar);
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Cinder_CreateSpear)) AddPawnAbility(RWBYDefOf.Cinder_CreateSpear);
            }
            else if (AbilityUser.story.traits.HasTrait(RWBYDefOf.Semblance_Hazel)) // Hazel
            {
                aura = new Aura
                {
                    pawn = AbilityUser,
                    maxEnergy = 1f,
                    currentEnergy = 1f
                };
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Hazel_IgnorePain)) AddPawnAbility(RWBYDefOf.Hazel_IgnorePain);
            }
            else if (AbilityUser.story.traits.HasTrait(RWBYDefOf.Semblance_Velvet)) // Velvet
            {
                aura = new Aura_Velvet
                {
                    pawn = AbilityUser,
                    maxEnergy = 1f,
                    currentEnergy = 1f
                };
            }
            else if (AbilityUser.story.traits.HasTrait(RWBYDefOf.Semblance_Adam)) // Adam
            {
                aura = new Aura_Adam
                {
                    pawn = AbilityUser,
                    maxEnergy = 1f,
                    currentEnergy = 1f
                };
                if (!AbilityData.AllPowers.Any(p => p.Def == RWBYDefOf.Adam_UnleashDamage)) AddPawnAbility(RWBYDefOf.Adam_UnleashDamage);
            }
            else if (AbilityUser.story.traits.HasTrait(RWBYDefOf.RWBY_Aura)) // Aura
            {
                aura = new Aura
                {
                    pawn = AbilityUser,
                    maxEnergy = 0.7f,
                    currentEnergy = 0.7f
                };
            }
            else if (LoadedModManager.GetMod<RemnantMod>().GetSettings<RemnantModSettings>().everyoneHasAura) // Optional
            {
                aura = new Aura
                {
                    pawn = AbilityUser,
                    maxEnergy = 0.3f,
                    currentEnergy = 0.3f
                };
            }
        }
    }
}


