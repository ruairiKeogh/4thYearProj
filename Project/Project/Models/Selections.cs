﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
        public enum Positions
        {
            [field: Description("GKR")]
            GoalKeeper,
            [field: Description("RCB")]
            RightCornerBack,
            [field: Description("FLB")]
            FullBack,
            [field: Description("LCB")]
            LeftCornerBack,
            [field: Description("RWB")]
            RightWingBack,
            [field: Description("CNB")]
            CenterBack,
            [field: Description("LWB")]
            LeftWingBack,
            [field: Description("MD1")]
            MidfieldOne,
            [field: Description("MD2")]
            MidfieldTwo,
            [field: Description("RHF")]
            RightHalfForward,
            [field: Description("CNF")]
            CenterForward,
            [field: Description("LHF")]
            LeftHalfForward,
            [field: Description("RCF")]
            RightCornerForward,
            [field: Description("FLF")]
            FullForward,
            [field: Description("LCF")]
            LeftCornerForward,
            [field: Description("SB1")]
            SubstituteOne,
            [field: Description("SB2")]
            SubstituteTwo,
            [field: Description("SB3")]
            SubstituteThree,
            [field: Description("SB4")]
            SubstituteFour,
            [field: Description("SB5")]
            SubstituteFive,
        }
        public class Selections
        {
            public int SelectionID { get; set; }
            public int SquadID { get; set; }
            public int PlayerID { get; set; }
            public Positions position { get; set; }

            public virtual Player Players { get; set; }
            public virtual Squads Squad { get; set; }
        }
    
}