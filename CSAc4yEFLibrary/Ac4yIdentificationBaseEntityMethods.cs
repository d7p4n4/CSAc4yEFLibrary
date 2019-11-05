using CSAc4y.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccess
{
    public class Ac4yIdentificationBaseEntityMethods : Ac4yIdentificationBaseAlgebra
    {
        public AllContext context { get; set; }

        public Ac4yIdentificationBaseEntityMethods() { }

        public Ac4yIdentificationBaseEntityMethods(AllContext allContext)
        {
            context = allContext;
        }


        public Ac4yIdentificationBase findFirstById(Int32 id)
        {
            Ac4yIdentificationBase a = null;

            using (context)
            {
                var query = context.Ac4yIdentificationBases
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4yIdentificationBase>();

                a = query;
            }
            return a;
        }
        public static Ac4yIdentificationBase findFirstByGUID(String GUID)
        {
            Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.GUID == GUID)
                                .FirstOrDefault<Ac4yIdentificationBase>();

                a = query;
            }
            return a;
        }
        public static Ac4yIdentificationBase findFirstByHumanId(String HumanId)
        {
            Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.HumanId == HumanId)
                                .FirstOrDefault<Ac4yIdentificationBase>();

                a = query;
            }
            return a;
        }
        public static Ac4yIdentificationBase findFirstByPublicHumanId(String PublicHumanId)
        {
            Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.PublicHumanId == PublicHumanId)
                                .FirstOrDefault<Ac4yIdentificationBase>();

                a = query;
            }
            return a;
        }
        public static Ac4yIdentificationBase findFirstByCreatedAt(DateTime CreatedAt)
        {
            Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.CreatedAt == CreatedAt)
                                .FirstOrDefault<Ac4yIdentificationBase>();

                a = query;
            }
            return a;
        }
        public static Ac4yIdentificationBase findFirstByUpdatedAt(String UpdatedAt)
        {
            Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.UpdatedAt == UpdatedAt)
                                .FirstOrDefault<Ac4yIdentificationBase>();

                a = query;
            }
            return a;
        }

        public static List<Ac4yIdentificationBase> findListById(Int32 id)
        {
            List<Ac4yIdentificationBase> a = new List<Ac4yIdentificationBase>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.id == id).ToList();

                a = query;
            }
            return a;
        }
        public static List<Ac4yIdentificationBase> findListByGUID(String GUID)
        {
            List<Ac4yIdentificationBase> a = new List<Ac4yIdentificationBase>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.GUID == GUID).ToList();

                a = query;
            }
            return a;
        }
        public static List<Ac4yIdentificationBase> findListByHumanId(String HumanId)
        {
            List<Ac4yIdentificationBase> a = new List<Ac4yIdentificationBase>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.HumanId == HumanId).ToList();

                a = query;
            }
            return a;
        }
        public static List<Ac4yIdentificationBase> findListByPublicHumanId(String PublicHumanId)
        {
            List<Ac4yIdentificationBase> a = new List<Ac4yIdentificationBase>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.PublicHumanId == PublicHumanId).ToList();

                a = query;
            }
            return a;
        }
        public static List<Ac4yIdentificationBase> findListByCreatedAt(DateTime CreatedAt)
        {
            List<Ac4yIdentificationBase> a = new List<Ac4yIdentificationBase>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.CreatedAt == CreatedAt).ToList();

                a = query;
            }
            return a;
        }
        public static List<Ac4yIdentificationBase> findListByUpdatedAt(String UpdatedAt)
        {
            List<Ac4yIdentificationBase> a = new List<Ac4yIdentificationBase>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.UpdatedAt == UpdatedAt).ToList();

                a = query;
            }
            return a;
        }

	public Boolean existsInAc4yIdentificationBaseById(Int32 id)
	{
		Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4yIdentificationBase>();

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
	public Boolean existsInAc4yIdentificationBaseByGUID(String GUID)
	{
		Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.GUID == GUID)
                                .FirstOrDefault<Ac4yIdentificationBase>();

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
	public Boolean existsInAc4yIdentificationBaseByHumanId(String HumanId)
	{
		Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.HumanId == HumanId)
                                .FirstOrDefault<Ac4yIdentificationBase>();

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
	public Boolean existsInAc4yIdentificationBaseByPublicHumanId(String PublicHumanId)
	{
		Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.PublicHumanId == PublicHumanId)
                                .FirstOrDefault<Ac4yIdentificationBase>();

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
	public Boolean existsInAc4yIdentificationBaseByCreatedAt(DateTime CreatedAt)
	{
		Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.CreatedAt == CreatedAt)
                                .FirstOrDefault<Ac4yIdentificationBase>();

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
	public Boolean existsInAc4yIdentificationBaseByUpdatedAt(String UpdatedAt)
	{
		Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.UpdatedAt == UpdatedAt)
                                .FirstOrDefault<Ac4yIdentificationBase>();

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
	
		public void updateAc4yIdentificationBase(Ac4yIdentificationBase updatedAc4yIdentificationBase)
        {
            using(var ctx = new AllContext())
            {
                var _Ac4yIdentificationBase = ctx.Ac4yIdentificationBases
				.Where(ss => ss.id == updatedAc4yIdentificationBase.id).FirstOrDefault();

                _Ac4yIdentificationBase.id = updatedAc4yIdentificationBase.id;
                _Ac4yIdentificationBase.GUID = updatedAc4yIdentificationBase.GUID;
                _Ac4yIdentificationBase.HumanId = updatedAc4yIdentificationBase.HumanId;
                _Ac4yIdentificationBase.PublicHumanId = updatedAc4yIdentificationBase.PublicHumanId;
                _Ac4yIdentificationBase.CreatedAt = updatedAc4yIdentificationBase.CreatedAt;
                _Ac4yIdentificationBase.UpdatedAt = updatedAc4yIdentificationBase.UpdatedAt;
                ctx.SaveChanges();
            }
        }


        public static void deleteById(Int32 id)
        {
            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentificationBases
                                .Remove(ctx.Ac4yIdentificationBases.Single(ss => ss.id == id));

                ctx.SaveChanges();
            }
        }

	public void addNewAc4yIdentificationBase(Ac4yIdentificationBase _Ac4yIdentificationBase)
	{
		using (context)
            {
                context.Ac4yIdentificationBases.Add(_Ac4yIdentificationBase);

                context.SaveChanges();
            }
	}
    }
}
