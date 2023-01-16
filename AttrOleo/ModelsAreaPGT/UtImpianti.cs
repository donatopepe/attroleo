using System;
using System.Collections.Generic;

namespace AttrOleo.ModelsAreaPGT
{
    public partial class UtImpianti
    {
        public UtImpianti()
        {
            UtCentrali = new HashSet<UtCentrali>();
        }

        public int Id { get; set; }
        public string Codice { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }

        public virtual ICollection<UtCentrali> UtCentrali { get; set; }
    }
}
