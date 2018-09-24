using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGSAIWriter
{
    class CreatureData
    {
        string name;
        int entry, saiCount;
        bool saiEnabled;

        public string Name { get => name; set => name = value; }
        public int Entry { get => entry; set => entry = value; }
        public int SaiCount { get => saiCount; set => saiCount = value; }
        public bool SaiEnabled { get => saiEnabled; set => saiEnabled = value; }
    }
}
