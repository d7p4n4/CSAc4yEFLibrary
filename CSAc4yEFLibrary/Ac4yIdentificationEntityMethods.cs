using CSAc4y.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccess
{
    public class Ac4yIdentificationEntityMethods : Ac4yIdentificationAlgebra
    {/*
        public static Ac4yIdentification findFirstByTemplate(Ac4yIdentificationBase template)
        {
            Ac4yIdentification a = null;

            using (context)
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.template == template)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }
        public static Ac4yIdentification findFirstById(Int32 id)
        {
            Ac4yIdentification a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }
        public static Ac4yIdentification findFirstByGUID(String GUID)
        {
            Ac4yIdentification a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.GUID == GUID)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }
        public static Ac4yIdentification findFirstByHumanId(String HumanId)
        {
            Ac4yIdentification a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.HumanId == HumanId)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }
        public static Ac4yIdentification findFirstByPublicHumanId(String PublicHumanId)
        {
            Ac4yIdentification a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.PublicHumanId == PublicHumanId)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }
        public static Ac4yIdentification findFirstByCreatedAt(DateTime CreatedAt)
        {
            Ac4yIdentification a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.CreatedAt == CreatedAt)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }
        public static Ac4yIdentification findFirstByUpdatedAt(String UpdatedAt)
        {
            Ac4yIdentification a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.UpdatedAt == UpdatedAt)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }

        public static List<Ac4yIdentification> findListByTemplate(Ac4yIdentificationBase template)
        {
            List<Ac4yIdentification> a = new List<Ac4yIdentification>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.template == template).ToList();

                a = query;
            }
            return a;
        }
        public static List<Ac4yIdentification> findListById(Int32 id)
        {
            List<Ac4yIdentification> a = new List<Ac4yIdentification>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.id == id).ToList();

                a = query;
            }
            return a;
        }
        public static List<Ac4yIdentification> findListByGUID(String GUID)
        {
            List<Ac4yIdentification> a = new List<Ac4yIdentification>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.GUID == GUID).ToList();

                a = query;
            }
            return a;
        }
        public static List<Ac4yIdentification> findListByHumanId(String HumanId)
        {
            List<Ac4yIdentification> a = new List<Ac4yIdentification>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.HumanId == HumanId).ToList();

                a = query;
            }
            return a;
        }
        public static List<Ac4yIdentification> findListByPublicHumanId(String PublicHumanId)
        {
            List<Ac4yIdentification> a = new List<Ac4yIdentification>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.PublicHumanId == PublicHumanId).ToList();

                a = query;
            }
            return a;
        }
        public static List<Ac4yIdentification> findListByCreatedAt(DateTime CreatedAt)
        {
            List<Ac4yIdentification> a = new List<Ac4yIdentification>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.CreatedAt == CreatedAt).ToList();

                a = query;
            }
            return a;
        }
        public static List<Ac4yIdentification> findListByUpdatedAt(String UpdatedAt)
        {
            List<Ac4yIdentification> a = new List<Ac4yIdentification>();

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.UpdatedAt == UpdatedAt).ToList();

                a = query;
            }
            return a;
        }

	public Boolean existsInAc4yIdentificationByTemplate(Ac4yIdentificationBase template)
	{
		Ac4yIdentification a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.template == template)
                                .FirstOrDefault<Ac4yIdentification>();

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
	public Boolean existsInAc4yIdentificationById(Int32 id)
	{
		Ac4yIdentification a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4yIdentification>();

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
	public Boolean existsInAc4yIdentificationByGUID(String GUID)
	{
		Ac4yIdentification a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.GUID == GUID)
                                .FirstOrDefault<Ac4yIdentification>();

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
	public Boolean existsInAc4yIdentificationByHumanId(String HumanId)
	{
		Ac4yIdentification a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.HumanId == HumanId)
                                .FirstOrDefault<Ac4yIdentification>();

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
	public Boolean existsInAc4yIdentificationByPublicHumanId(String PublicHumanId)
	{
		Ac4yIdentification a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.PublicHumanId == PublicHumanId)
                                .FirstOrDefault<Ac4yIdentification>();

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
	public Boolean existsInAc4yIdentificationByCreatedAt(DateTime CreatedAt)
	{
		Ac4yIdentification a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.CreatedAt == CreatedAt)
                                .FirstOrDefault<Ac4yIdentification>();

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
	public Boolean existsInAc4yIdentificationByUpdatedAt(String UpdatedAt)
	{
		Ac4yIdentification a = null;

            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.UpdatedAt == UpdatedAt)
                                .FirstOrDefault<Ac4yIdentification>();

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
	
		public void updateAc4yIdentification(Ac4yIdentification updatedAc4yIdentification)
        {
            using(var ctx = new AllContext())
            {
                var _Ac4yIdentification = ctx.Ac4yIdentifications
				.Where(ss => ss.id == updatedAc4yIdentification.id).FirstOrDefault();

                _Ac4yIdentification.template = updatedAc4yIdentification.template;
                _Ac4yIdentification.id = updatedAc4yIdentification.id;
                _Ac4yIdentification.GUID = updatedAc4yIdentification.GUID;
                _Ac4yIdentification.HumanId = updatedAc4yIdentification.HumanId;
                _Ac4yIdentification.PublicHumanId = updatedAc4yIdentification.PublicHumanId;
                _Ac4yIdentification.CreatedAt = updatedAc4yIdentification.CreatedAt;
                _Ac4yIdentification.UpdatedAt = updatedAc4yIdentification.UpdatedAt;
                ctx.SaveChanges();
            }
        }


        public static void deleteById(Int32 id)
        {
            using (var ctx = new AllContext())
            {
                var query = ctx.Ac4yIdentifications
                                .Remove(ctx.Ac4yIdentifications.Single(ss => ss.id == id));

                ctx.SaveChanges();
            }
        }

	public static void addNewAc4yIdentification(Ac4yIdentification _Ac4yIdentification)
	{
		using (var ctx = new AllContext())
            {
                ctx.Ac4yIdentifications.Add(_Ac4yIdentification);

                ctx.SaveChanges();
            }
	}*/
    }
}
