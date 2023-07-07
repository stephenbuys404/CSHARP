using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOODB_CL.classfiles
{
    public class ZooAnimals
    {
        #region Properties
        [Browsable(false)]
        public int ZooAnimalID { get; set; }
        [Browsable(false)]
        public int ZooID { get; set; }
        [Browsable(false)]
        public int AnimalID { get; set; }
        public Animal anAnimal { get; set; }
        public Zoo aZoo { get; set; }
        #endregion
        #region Constructors
        public ZooAnimals(){ZooAnimalID = 0;ZooID = 0;AnimalID = 0;anAnimal = new Animal();aZoo = new Zoo();}
        public ZooAnimals(int zooanimalid, int zooid, int animalid, Animal ani, Zoo zo){ZooAnimalID = zooanimalid;ZooID = zooid;AnimalID = animalid;anAnimal = ani;aZoo = zo;}
        #endregion
    }
}
