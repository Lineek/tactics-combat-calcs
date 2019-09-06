using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticsCombatCalcs.Classes.Job.Jobs
{
    class Mercador : CharJob
    {
        Mercador()
        {
            this.BaseStrength = 7;
            this.BaseResistance = 16;
            this.BaseAgility = 3;
            this.BaseIntelligence = 7;
            this.BaseWisdom = 9;
            this.BaseDexterity = 8;

            this.StrengthModifier = 0.38;
            this.ResistanceModifier = 0.42;
            this.AgilityModifier = 0.24;
            this.IntelligenceModifier = 0.27;
            this.WisdomModifier = 0.85;
            this.DexterityModifier = 0.34;
        }
    }
}
