using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpaceShip
{
    //שדה 
    internal class CrewMember
    {
        private int _firePower;


        //constrctor 
        public CrewMember(int firePower)
        {
            this._firePower = firePower;
        }
        // get and set to get value becouse the firepower is private
        public int FirePower
        {
            get { return _firePower; }
            set { _firePower = value; }
        }
        public override string ToString()
        {
            return _firePower.ToString();// to string becouse its int 
        }
    }
    class robot : CrewMember//פתיחת קלאס
    {
        private string _model;

        //constrctor 
        public robot(string model, int firePower) : base(firePower)
        {
            this._model = model;

        }
        public override string ToString()
        {
            return $" Robot Model {_model} " + base.ToString();
        }
        public string Model// set and get for model
        {
            get { return _model; }
            set { _model = value; }
        }

    }
    class soldier : CrewMember//open class 
    {
        private string _name;

        public soldier(string name, int firePower) : base(firePower)
        {
            this._name = name;
        }
        public string Name// set and get for Robot name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public override string ToString()
        {
            return $" The name soldier  {_name} " + base.ToString();
        }

    }
    class officer : CrewMember//open class
    {
        private string _rank;

        //cinstrator 
         public officer(string name,string rank ,int firePower) : base(firePower)
        {
           this._rank = rank ; 
        }
        public string Rank// set and get for Rank officer
        {
            get { return _rank; }
            set { _rank= value; }
        }
        public override string ToString()
        {
            return $" The officer rank  {_rank} " + base.ToString();
        }



    }
    

}
