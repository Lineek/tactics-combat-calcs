using System.Collections.Generic;
using TacticsCombatCalcs.Classes.Interfaces;

namespace TacticsCombatCalcs.Classes.Job
{
    public class CharJob : IJob
    {
        private List<int> listSkills;

        public int BaseStrength { get; set; }
        public int BaseResistance { get; set; }
        public int BaseAgility { get; set; }
        public int BaseIntelligence { get; set; }
        public int BaseWisdom { get; set; }
        public int BaseDexterity { get; set; }

        public double StrengthModifier { get; set; }
        public double ResistanceModifier { get; set; }
        public double AgilityModifier { get; set; }
        public double IntelligenceModifier { get; set; }
        public double WisdomModifier { get; set; }
        public double DexterityModifier { get; set; }

        public List<int> ListSkills { get => listSkills; set => listSkills = value; }
    }
}