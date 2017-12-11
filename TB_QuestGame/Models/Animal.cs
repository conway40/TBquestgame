using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    public class Animal : Npc, IScavenge
    {
        public override int Id { get; set; }
        public override string Description { get; set; }

        public SurvivorObject ScavengeForObjects(List<SurvivorObject> scavengerObjects)
        {
            SurvivorObject foundObject = new SurvivorObject();
            Random rnd = new Random();
            if (scavengerObjects.Count > 0)
            {
                int scavengerObjectId = rnd.Next(1, scavengerObjects.Count);
                foundObject = scavengerObjects[scavengerObjectId -1];
            }

            return foundObject;
        }
    }
}
