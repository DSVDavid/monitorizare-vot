﻿using System;
using System.Collections.Generic;

namespace VotingIrregularities.Domain.Models
{
    public partial class Observator
    {
        public Observator()
        {
            AccesObservatoriPerDevice = new HashSet<AccesObservatoriPerDevice>();
            DispozitivObservator = new HashSet<DispozitivObservator>();
            Nota = new HashSet<Nota>();
            Raspuns = new HashSet<Raspuns>();
            RaspunsFormular = new HashSet<RaspunsFormular>();
        }

        public int IdObservator { get; set; }
        public bool EsteDinEchipa { get; set; }
        public int IdOng { get; set; }
        public string NumarTelefon { get; set; }
        public string NumeIntreg { get; set; }
        public string Pin { get; set; }

        public virtual ICollection<AccesObservatoriPerDevice> AccesObservatoriPerDevice { get; set; }
        public virtual ICollection<DispozitivObservator> DispozitivObservator { get; set; }
        public virtual ICollection<Nota> Nota { get; set; }
        public virtual ICollection<Raspuns> Raspuns { get; set; }
        public virtual ICollection<RaspunsFormular> RaspunsFormular { get; set; }
        public virtual Ong IdOngNavigation { get; set; }
    }
}
