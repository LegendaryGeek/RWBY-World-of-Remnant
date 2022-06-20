using System;
using System.Collections.Generic;
using RimWorld;
using Verse;

namespace AbilityUser
{
	public class VerbProperties_Ability : VerbProperties
	{
		public AbilityDef abilityDef;
		public AbilityTargetCategory AbilityTargetCategory = AbilityTargetCategory.TargetThing;
		public bool AlwaysHits = true;
		public bool mustHaveTarget;
		public bool refundsPointsAfterFailing;
		public bool canCastInMelee = true;
		public List<ExtraDamage> extraDamages;
		public List<ApplyHediffs> hediffsToApply;
		public bool isViolent = true;
		public List<ApplyMentalStates> mentalStatesToApply;
		public bool requiresLineOfSight = true;
		public float SecondsToRecharge = 10f;
		public List<StatModifier> statModifiers;
		public TargetAoEProperties TargetAoEProperties;
		public List<SpawnThings> thingsToSpawn;
		public bool tooltipShowExtraDamages = true;
		public bool tooltipShowHediffsToApply = true;
		public bool tooltipShowMentalStatesToApply = true;
		public bool tooltipShowProjectileDamage = true;
	}
}
