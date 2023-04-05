using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinArtifactFarmer
{
    public class Artifact
    {
        private string name { get; set; }

        private float flatATK { get; set; }
        private float percentATK { get; set; }

        private float flatHP { get; set; }
        private float percentHP { get; set; }

        private float flatDEF { get; set; }
        private float percentDEF { get; set; }
        
        private float ER { get; set; }
        private float EM { get; set; }

        private float critRate { get; set; }
        private float critDMG { get; set; }

        private bool usesATK { get; set; }
        private bool usesHP { get; set; }
        private bool usesDEF { get; set; }
        private bool usesER { get; set; }
        private bool usesEM { get; set; }
        private bool usesCrit { get; set; }

        public Artifact() { }

        public Artifact(float flatATK, float percentATK, float flatHP, float percentHP, float flatDEF, float percentDEF, float ER, float EM, float critRate, float critDMG)
        {
            this.flatATK = flatATK;
            this.percentATK = percentATK;

            this.flatHP = flatHP;
            this.percentHP = percentHP;

            this.flatDEF = flatDEF;
            this.percentDEF = percentDEF;

            this.ER = ER;
            this.EM = EM;

            this.critRate = critRate;
            this.critDMG = critDMG;
        }

        public float[] rollValues(float f1, float f2, float f3, float f4)
        {
            float[] values = { 0, 0, 0, 0 };

            return values;

        }

        public float substatValue()
        {
            float sum = 0;

            if (usesATK)
            {
                sum += flatATK / 40;
                sum += percentATK / 5;
            }

            if (usesHP)
            {
                sum += flatHP / 254;
                sum += percentHP / 5;
            }

            if (usesDEF)
            {
                sum += flatDEF / 19;
                sum += percentDEF / (float)6.2;
            }

            if (usesER) sum += ER / 5;
            if (usesEM) sum += EM / 20;

            if (usesCrit)
            {
                sum += critRate / (float)3.3;
                sum += critDMG / (float)6.6;
            }

            return sum;
        }

        public float rollQuality()
        {
            if (flatATK > 0)
            {

            }

            if (percentATK > 0)
            {

            }

            if (flatHP > 0)
            {

            }

            if (percentHP > 0)
            {

            }

            if (flatDEF > 0)
            {

            }

            if (percentDEF > 0)
            {

            }

            if (ER > 0)
            {

            }

            if (EM > 0)
            {

            }

            if (critRate > 0)
            {

            }

            if (critDMG > 0)
            {

            }

            return 0;
        }
    }
}
