using CSAc4y.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccess
{
    public class Ac4yPersistentEntityMethods : Ac4yPersistentAlgebra
    {/*
        public static Ac4yPersistent findFirstByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
        {
            Ac4yPersistent a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yPersistents
                                .Where(ss => ss.Ac4yIdentification == Ac4yIdentification)
                                .FirstOrDefault<Ac4yPersistent>();

                a = query;
            }
            return a;
        }
        public static Ac4yPersistent findFirstById(Int32 id)
        {
            Ac4yPersistent a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yPersistents
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4yPersistent>();

                a = query;
            }
            return a;
        }

        public static List<Ac4yPersistent> findListByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
        {
            List<Ac4yPersistent> a = new List<Ac4yPersistent>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yPersistents
                                .Where(ss => ss.Ac4yIdentification == Ac4yIdentification).ToList();

                a = query;
            }
            return a;
        }
        public static List<Ac4yPersistent> findListById(Int32 id)
        {
            List<Ac4yPersistent> a = new List<Ac4yPersistent>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yPersistents
                                .Where(ss => ss.id == id).ToList();

                a = query;
            }
            return a;
        }

	public Boolean existsInAc4yPersistentByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
	{
		Ac4yPersistent a = null;

            using (var ctx = new AllContext())
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
	public Boolean existsInAc4yPersistentById(Int32 id)
	{
		Ac4yPersistent a = null;

            using (var ctx = new AllContext())
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
	
		public void updateAc4yPersistent(Ac4yPersistent updatedAc4yPersistent)
        {
            using(var ctx = new AllContext())
            {
                var _Ac4yPersistent = ctx.Ac4yPersistents
				.Where(ss => ss.id == updatedAc4yPersistent.id).FirstOrDefault();

                _Ac4yPersistent.Ac4yIdentification = updatedAc4yPersistent.Ac4yIdentification;
                _Ac4yPersistent.id = updatedAc4yPersistent.id;
                ctx.SaveChanges();
            }
        }


        public static void deleteById(Int32 id)
        {
            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yPersistents
                                .Remove(ctx.Ac4yPersistents.Single(ss => ss.id == id));

                ctx.SaveChanges();
            }
        }

	public static void addNewAc4yPersistent(Ac4yPersistent _Ac4yPersistent)
	{
		using (var ctx = new AllContext())
            {
                ctx.Ac4yPersistents.Add(_Ac4yPersistent);

                ctx.SaveChanges();
            }
	}*/
    }
}
