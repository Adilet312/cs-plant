using System;
namespace PlantNameSpace
{
    public class Plant
    {
        private string namePlant;
        private int growth;
        public Plant(string name_plant)
        {
            this.namePlant = name_plant;
            this.growth = 0;
        }
        public int getGrowth()
        {
            return this.growth;
        }
        public string getPlant()
        {
            return this.namePlant;
        }
        public void setPlant(string name_p)
        {
            this.namePlant = name_p;
        }
        /*  We are going to give the life for aour plant, 
        so we manage our plant's growth by calculating theinstance variable total.*/
        public void Water()
        {
            this.growth = this.growth + 1;
        }
        public void Feed()
        {
            this.growth = this.growth + 2;
        }

        public void GiveSunShine()
        {
            this.growth = this.growth + 2;
        }

        public void Winsdom(){
            this.growth-=1;
        }
        public void Windstrom(){
            this.growth-=1;
        }

        public void AphidAttack()
        {
            this.growth=-2;
        }

        public void SlugBite()
        {
            this.growth=-1;
        }

        public bool CheckStatus()
        {
            if(this.growth<0)
            {
                return false;
            }
            return true;
        }
        
        public void RestorePlant()
        {
            this.growth = 0;
        }

        public string PrintPlant()
        {
            string output="Plant: "+this.namePlant+", Growth: "+this.growth;
            return output;
        }


    }
}