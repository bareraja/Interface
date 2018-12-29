using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Maskine : IId
    {
        public string MaskinId;
        public string Type;

        public Maskine(string maskinId, string type)
        {
            this.MaskinId = maskinId;
            this.Type = type;
        }

        public string Id()
        {
            return Type + " " + MaskinId;
        }
    }
}
