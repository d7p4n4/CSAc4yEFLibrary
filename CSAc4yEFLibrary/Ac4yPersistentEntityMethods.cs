using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ac4yNamespace.Algebra.Class;
using ac4yNamespace.Final.Class;
using ac4yNamespace.Context.Class;


namespace ac4yNamespace.EFMethods.Class
{
    public class Ac4yPersistentEntityMethods : Ac4yPersistentAlgebra
    {
		public string baseName { get; set; }

        public Ac4yPersistentEntityMethods() { }

        public Ac4yPersistentEntityMethods(string newBaseName)
        {
            baseName = newBaseName;
        }
	
        public Ac4yPersistent findFirstByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
        {
            Ac4yPersistent a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yPersistents
                                .Where(ss => ss.Ac4yIdentification == Ac4yIdentification)
                                .FirstOrDefault<Ac4yPersistent>();

                a = query;
            }
            return a;
        }
        public Ac4yPersistent findFirstById(Int32 id)
        {
            Ac4yPersistent a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yPersistents
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4yPersistent>();

                a = query;
            }
            return a;
        }

        public List<Ac4yPersistent> findListByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
        {
            List<Ac4yPersistent> a = new List<Ac4yPersistent>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yPersistents
                                .Where(ss => ss.Ac4yIdentification == Ac4yIdentification).ToList();

                a = query;
            }
            return a;
        }
        public List<Ac4yPersistent> findListById(Int32 id)
        {
            List<Ac4yPersistent> a = new List<Ac4yPersistent>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yPersistents
                                .Where(ss => ss.id == id).ToList();

                a = query;
            }
            return a;
        }

	public Boolean existsByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
	{
		Ac4yPersistent a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yPersistents
                                .Where(ss => ss.Ac4yIdentification == Ac4yIdentification)
                                .FirstOrDefault<Ac4yPersistent>();

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
		Ac4yPersistent a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yPersistents
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4yPersistent>();

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
	
		public void update(Ac4yPersistent updatedAc4yPersistent)
        {
            using(var ctx = new AllContext(baseName))
            {
                var _Ac4yPersistent = ctx.Ac4yPersistents
				.Where(ss => ss.id == updatedAc4yPersistent.id).FirstOrDefault();

                _Ac4yPersistent.Ac4yIdentification = updatedAc4yPersistent.Ac4yIdentification;
                _Ac4yPersistent.id = updatedAc4yPersistent.id;
                ctx.SaveChanges();
            }
        }


        public void deleteById(Int32 id)
        {
            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yPersistents
                                .Remove(ctx.Ac4yPersistents.Single(ss => ss.id == id));

                ctx.SaveChanges();
            }
        }

	public void addNew(Ac4yPersistent _Ac4yPersistent)
	{
		using (var ctx = new AllContext(baseName))
            {
                ctx.Ac4yPersistents.Add(_Ac4yPersistent);

                ctx.SaveChanges();
            }
	}
    }
}
