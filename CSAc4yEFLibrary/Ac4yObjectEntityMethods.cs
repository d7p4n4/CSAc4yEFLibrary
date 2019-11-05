using CSAc4y.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccess
{
    public class Ac4yObjectEntityMethods : Ac4yObjectAlgebra
    {/*
        public static Ac4yObject findFirstByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
        {
            Ac4yObject a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yObjects
                                .Where(ss => ss.Ac4yIdentification == Ac4yIdentification)
                                .FirstOrDefault<Ac4yObject>();

                a = query;
            }
            return a;
        }
        public static Ac4yObject findFirstById(Int32 id)
        {
            Ac4yObject a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yObjects
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4yObject>();

                a = query;
            }
            return a;
        }

        public static List<Ac4yObject> findListByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
        {
            List<Ac4yObject> a = new List<Ac4yObject>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yObjects
                                .Where(ss => ss.Ac4yIdentification == Ac4yIdentification).ToList();

                a = query;
            }
            return a;
        }
        public static List<Ac4yObject> findListById(Int32 id)
        {
            List<Ac4yObject> a = new List<Ac4yObject>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yObjects
                                .Where(ss => ss.id == id).ToList();

                a = query;
            }
            return a;
        }

	public Boolean existsInAc4yObjectByAc4yIdentification(Ac4yIdentification Ac4yIdentification)
	{
		Ac4yObject a = null;

            using (var ctx = new AllContext())
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
	public Boolean existsInAc4yObjectById(Int32 id)
	{
		Ac4yObject a = null;

            using (var ctx = new AllContext())
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
	
		public void updateAc4yObject(Ac4yObject updatedAc4yObject)
        {
            using(var ctx = new AllContext())
            {
                var _Ac4yObject = ctx.Ac4yObjects
				.Where(ss => ss.id == updatedAc4yObject.id).FirstOrDefault();

                _Ac4yObject.Ac4yIdentification = updatedAc4yObject.Ac4yIdentification;
                _Ac4yObject.id = updatedAc4yObject.id;
                ctx.SaveChanges();
            }
        }


        public static void deleteById(Int32 id)
        {
            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yObjects
                                .Remove(ctx.Ac4yObjects.Single(ss => ss.id == id));

                ctx.SaveChanges();
            }
        }

	public static void addNewAc4yObject(Ac4yObject _Ac4yObject)
	{
		using (var ctx = new AllContext())
            {
                ctx.Ac4yObjects.Add(_Ac4yObject);

                ctx.SaveChanges();
            }
	}*/
    }
}
