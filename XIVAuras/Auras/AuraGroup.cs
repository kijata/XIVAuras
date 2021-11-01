﻿using System.Collections.Generic;
using System.Numerics;
using XIVAuras.Config;

namespace XIVAuras.Auras
{
    public class AuraGroup : IAuraListItem
    {
        public AuraType Type => AuraType.Group;

        public string Name { get; init; }

        public IEnumerable<IConfigPage> ConfigPages { get; init; }

        public List<IAuraListItem> Auras { get; set; }

        public AuraGroup(string name)
        {
            this.Auras = new List<IAuraListItem>();
            this.Name = name;
            this.ConfigPages = new List<IConfigPage>();
        }

        public void Draw(Vector2 pos)
        {
            foreach (IAuraListItem aura in this.Auras)
            {
                aura.Draw(pos);
            }
        }
    }
}