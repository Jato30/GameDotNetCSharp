using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameDotNetCSharp.src.Entities
{
	public class Hero
	{
		public string Name;
		public int Level;
		public string HeroType;

		public Hero (){}

		public virtual string Attack(){
			return this.Name + " atacou com uma espada!";
		}
	}
}