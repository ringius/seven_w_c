﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script;
using System.Web.Script.Serialization;

namespace SevenW.Models
{
    public class Playcard
    {
        public enum Type { RawMaterial, Goods, CivilianStructure, ScienceStructure, CommercialStructure, Wonder, MilitaryStructure, Guild };
        private int id;
        private string name;
        private int age;
        //private Player;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Playcard()
        {
            id = -1;
            name = @"hata Göteborg";
            age = 0;
        }

        public Playcard(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            string res = "id: " + id + " age: " + age + " Name: " + name;
            return res;
            //return base.ToString();
        }
        static public Playcard ReadTest()
        {
            string test_string = @"{""Id"" : 50, ""Name"" : ""Lumber Yard"", ""Age"" : 1}"; // , ""type"" : ""RawMaterial""}";

            Playcard card = new JavaScriptSerializer().Deserialize<Playcard> (test_string);
            Console.WriteLine(card.ToString());

            return new Playcard(1, "test", 1);
        }

		/// <summary>
		/// TODO: IMPLEMENT
		/// </summary>
		/// <param name="p"></param>
		internal bool updatePlayer(Player p)
		{
			/// Should return false is something goes wrong so that the caller can throw an exception
			/// (as per original design)
			return true;
		}
	}

    public class CardFactory
    {

    }


}
