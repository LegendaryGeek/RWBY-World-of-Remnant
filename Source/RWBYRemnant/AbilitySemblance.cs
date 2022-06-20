using VFECore.Abilities;
using System.Linq;
using Verse;

namespace RWBYRemnant
{
    class AbilitySemblance : Ability
    {
        public AbilitySemblance()
        {
        }

        // public AbilitySemblance(CompAbilities abilityUser) : base(abilityUser)
        // {
            
        //     this.abilityUser = (abilityUser as CompAbilitiesAura);
        // }

        // public AbilitySemblance(AbilityData abilityData) : base(abilityData)
        // {
        //     this.abilityUser = (abilityData.Pawn.AllComps.FirstOrDefault((ThingComp x) => x.GetType() == abilityData.AbilityClass) as CompAbilitiesAura);
        // }

        // public AbilitySemblance(Pawn user, SemblanceDef pdef) : base(user, pdef)
        // {
        // }

        public CompAbilitiesAura AbilityUserAura
        {
            get
            {
                CompAbilitiesAura result;
                if ((result = (base.CasterPawn.GetComp<CompAbilitiesAura>())) != null)
                {
                    return result;
                }
                return null;
            }
        }

        public SemblanceDef SemblanceDef
        {
            get
            {
                return this.def as SemblanceDef;
            }
        }

        //public override void Notify_AbilityFailed(bool refund)
        //{
        //    base.Notify_AbilityFailed(refund);
        //    if (refund)
        //    {
        //        if (SemblanceDef.usesAmmunition != null && Pawn.inventory.GetDirectlyHeldThings().ToList().Find(s => s.def == SemblanceDef.usesAmmunition) == null)
        //        {
        //            Pawn.inventory.GetDirectlyHeldThings().TryAdd(ThingMaker.MakeThing(SemblanceDef.usesAmmunition), 1);
        //        }
        //        if (SemblanceDef.auraCost > 0f)
        //        {
        //            AbilityUserAura.aura.currentEnergy += SemblanceDef.auraCost;
        //        }
        //    }
        //}

        public /*override*/ bool CanCastPowerCheck(/*AbilityContext context, out string reason*/)
        {
            bool baseResult = true/*= base.CanCastPowerCheck(context, out reason)*/;
            TaggedString reason;
            //if (baseResult)
            //{
                if (SemblanceDef.usesAmmunition != null && base.CasterPawn.inventory.GetDirectlyHeldThings().ToList().Find(s => s.def == SemblanceDef.usesAmmunition) == null)
                {
                    baseResult = false;
                    reason = "DisabledNoDustPowderAmmunition".Translate(SemblanceDef.usesAmmunition.label).CapitalizeFirst();
                }
                if (SemblanceDef.auraCost > 0f && SemblanceDef.auraCost >= AbilityUserAura.aura.currentEnergy)
                {
                    baseResult = false;
                    reason = "DisabledNotEnoughAura".Translate(base.CasterPawn.Name.ToStringShort);
                }
                if (SemblanceDef == RWBYDefOf.Adam_UnleashDamage && base.CasterPawn.TryGetComp<CompAbilitiesAura>() is CompAbilitiesAura comp1 && comp1.aura is Aura_Adam aura_Adam && aura_Adam.absorbedDamage == 0)
                {
                    baseResult = false;
                    reason = "DisabledNoDamageAbosrbed".Translate(base.CasterPawn.Name.ToStringShort);
                }
                if (SemblanceDef == RWBYDefOf.Adam_UnleashDamage && (base.CasterPawn.equipment.Primary == null || !base.CasterPawn.equipment.Primary.def.IsMeleeWeapon))
                {
                    baseResult = false;
                    reason = "DisabledNoMeleeWeapon".Translate(base.CasterPawn.Name.ToStringShort);
                }
                if (SemblanceDef == RWBYDefOf.Yang_ReturnDamage && base.CasterPawn.TryGetComp<CompAbilitiesAura>() is CompAbilitiesAura comp2 && comp2.aura is Aura_Yang aura_Yang && aura_Yang.absorbedDamage == 0)
                {
                    baseResult = false;
                    reason = "DisabledNoDamageAbosrbed".Translate(base.CasterPawn.Name.ToStringShort);
                }
            //}
            return baseResult;
        }
    }
}
