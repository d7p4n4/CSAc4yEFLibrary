using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using d7p4n4.Algebra.Class;
using d7p4n4.Final.Class;
using d7p4n4.Context.Class;


namespace d7p4n4.EFMethods.Class
{
    public class Ac4yObjectEntityMethods : Ac4yObjectAlgebra
    {
		public string baseName { get; set; }

        public Ac4yObjectEntityMethods() { }

        public Ac4yObjectEntityMethods(string newBaseName)
        {
            baseName = newBaseName;
        }
	
        public Ac4yObject findFirstByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
        {
            Ac4yObject a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yObjects
                                .Where(ss => ss.Ac4yIdentification == Ac4yIdentification)
                                .FirstOrDefault<Ac4yObject>();

                a = query;
            }
            return a;
        }
        public Ac4yObject findFirstById(Int32 id)
        {
            Ac4yObject a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yObjects
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4yObject>();

                a = query;
            }
            return a;
        }

        public List<Ac4yObject> findListByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
        {
            List<Ac4yObject> a = new List<Ac4yObject>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yObjects
                                .Where(ss => ss.Ac4yIdentification == Ac4yIdentification).ToList();

                a = query;
            }
            return a;
        }
        public List<Ac4yObject> findListById(Int32 id)
        {
            List<Ac4yObject> a = new List<Ac4yObject>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yObjects
                                .Where(ss => ss.id == id).ToList();

                a = query;
            }
            return a;
        }

	public Boolean existsByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
	{
		Ac4yObject a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yObjects
                                .Where(ss => ss.Ac4yIdentification == Ac4yIdentification)
                                .FirstOrDefault<Ac4yObject>();

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
		Ac4yObject a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yObjects
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4yObject>();

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
	
		public void update(Ac4yObject updatedAc4yObject)
        {
            using(var ctx = new AllContext(baseName))
            {
                var _Ac4yObject = ctx.Ac4yObjects
				.Where(ss => ss.id == updatedAc4yObject.id).FirstOrDefault();

                _Ac4yObject.Ac4yIdentification = updatedAc4yObject.Ac4yIdentification;
                _Ac4yObject.id = updatedAc4yObject.id;
                ctx.SaveChanges();
            }
        }


        public void deleteById(Int32 id)
        {
            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yObjects
                                .Remove(ctx.Ac4yObjects.Single(ss => ss.id == id));

                ctx.SaveChanges();
            }
        }

	public void addNew(Ac4yObject _Ac4yObject)
	{
		using (var ctx = new AllContext(baseName))
            {
                ctx.Ac4yObjects.Add(_Ac4yObject);

                ctx.SaveChanges();
            }
	}
    }
}
