using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using d7p4n4.Algebra.Class;
using d7p4n4.Final.Class;
using d7p4n4.Context.Class;


namespace d7p4n4.EFMethods.Class
{
    public class Ac4yEntityMethods : Ac4yAlgebra
    {
		public string baseName { get; set; }

        public Ac4yEntityMethods() { }

        public Ac4yEntityMethods(string newBaseName)
        {
            baseName = newBaseName;
        }
	
        public Ac4y findFirstByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
        {
            Ac4y a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4ys
                                .Where(ss => ss.Ac4yIdentification == Ac4yIdentification)
                                .FirstOrDefault<Ac4y>();

                a = query;
            }
            return a;
        }
        public Ac4y findFirstById(Int32 id)
        {
            Ac4y a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4ys
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4y>();

                a = query;
            }
            return a;
        }

        public List<Ac4y> findListByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
        {
            List<Ac4y> a = new List<Ac4y>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4ys
                                .Where(ss => ss.Ac4yIdentification == Ac4yIdentification).ToList();

                a = query;
            }
            return a;
        }
        public List<Ac4y> findListById(Int32 id)
        {
            List<Ac4y> a = new List<Ac4y>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4ys
                                .Where(ss => ss.id == id).ToList();

                a = query;
            }
            return a;
        }

	public Boolean existsByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
	{
		Ac4y a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4ys
                                .Where(ss => ss.Ac4yIdentification == Ac4yIdentification)
                                .FirstOrDefault<Ac4y>();

                a = query;
            }
                if(a != null)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	public Boolean existsById(Int32 id)
	{
		Ac4y a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4ys
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4y>();

                a = query;
            }
                if(a != null)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	
		public void update(Ac4y updatedAc4y)
        {
            using(var ctx = new AllContext(baseName))
            {
                var _Ac4y = ctx.Ac4ys
				.Where(ss => ss.id == updatedAc4y.id).FirstOrDefault();

                _Ac4y.Ac4yIdentification = updatedAc4y.Ac4yIdentification;
                _Ac4y.id = updatedAc4y.id;
                ctx.SaveChanges();
            }
        }


        public void deleteById(Int32 id)
        {
            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4ys
                                .Remove(ctx.Ac4ys.Single(ss => ss.id == id));

                ctx.SaveChanges();
            }
        }

	public void addNew(Ac4y _Ac4y)
	{
		using (var ctx = new AllContext(baseName))
            {
                ctx.Ac4ys.Add(_Ac4y);

                ctx.SaveChanges();
            }
	}
    }
}
