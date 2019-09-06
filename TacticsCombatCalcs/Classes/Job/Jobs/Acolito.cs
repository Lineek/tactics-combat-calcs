using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticsCombatCalcs.Classes.Job.Jobs
{
    class Acolito : CharJob
    {
        Acolito()
        {
            this.BaseStrength = 5;
            this.BaseResistance = 9;
            this.BaseAgility = 4;
            this.BaseIntelligence = 10;
            this.BaseWisdom = 14;
            this.BaseDexterity = 8;

            this.StrengthModifier = 0.4;
            this.ResistanceModifier = 0.38;
            this.AgilityModifier = 0.29;
            this.IntelligenceModifier = 0.55;
            this.WisdomModifier = 0.48;
            this.DexterityModifier = 0.4;
        }
    }
}
