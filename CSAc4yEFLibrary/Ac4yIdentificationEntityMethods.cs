using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using d7p4n4.Algebra.Class;
using d7p4n4.Final.Class;
using d7p4n4.Context.Class;


namespace d7p4n4.EFMethods.Class
{
    public class Ac4yIdentificationEntityMethods : Ac4yIdentificationAlgebra
    {
		public string baseName { get; set; }

        public Ac4yIdentificationEntityMethods() { }

        public Ac4yIdentificationEntityMethods(string newBaseName)
        {
            baseName = newBaseName;
        }
	
        public Ac4yIdentification findFirstByTemplate(Ac4yIdentificationBase template)
        {
            Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.template == template)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }
        public Ac4yIdentification findFirstById(Int32 id)
        {
            Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }
        public Ac4yIdentification findFirstByGUID(String GUID)
        {
            Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.GUID == GUID)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }
        public Ac4yIdentification findFirstByHumanId(String HumanId)
        {
            Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.HumanId == HumanId)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }
        public Ac4yIdentification findFirstByPublicHumanId(String PublicHumanId)
        {
            Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.PublicHumanId == PublicHumanId)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }
        public Ac4yIdentification findFirstByCreatedAt(DateTime CreatedAt)
        {
            Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.CreatedAt == CreatedAt)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }
        public Ac4yIdentification findFirstByUpdatedAt(String UpdatedAt)
        {
            Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.UpdatedAt == UpdatedAt)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }

        public List<Ac4yIdentification> findListByTemplate(Ac4yIdentificationBase template)
        {
            List<Ac4yIdentification> a = new List<Ac4yIdentification>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.template == template).ToList();

                a = query;
            }
            return a;
        }
        public List<Ac4yIdentification> findListById(Int32 id)
        {
            List<Ac4yIdentification> a = new List<Ac4yIdentification>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.id == id).ToList();

                a = query;
            }
            return a;
        }
        public List<Ac4yIdentification> findListByGUID(String GUID)
        {
            List<Ac4yIdentification> a = new List<Ac4yIdentification>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.GUID == GUID).ToList();

                a = query;
            }
            return a;
        }
        public List<Ac4yIdentification> findListByHumanId(String HumanId)
        {
            List<Ac4yIdentification> a = new List<Ac4yIdentification>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.HumanId == HumanId).ToList();

                a = query;
            }
            return a;
        }
        public List<Ac4yIdentification> findListByPublicHumanId(String PublicHumanId)
        {
            List<Ac4yIdentification> a = new List<Ac4yIdentification>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.PublicHumanId == PublicHumanId).ToList();

                a = query;
            }
            return a;
        }
        public List<Ac4yIdentification> findListByCreatedAt(DateTime CreatedAt)
        {
            List<Ac4yIdentification> a = new List<Ac4yIdentification>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.CreatedAt == CreatedAt).ToList();

                a = query;
            }
            return a;
        }
        public List<Ac4yIdentification> findListByUpdatedAt(String UpdatedAt)
        {
            List<Ac4yIdentification> a = new List<Ac4yIdentification>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.UpdatedAt == UpdatedAt).ToList();

                a = query;
            }
            return a;
        }

	public Boolean existsByTemplate(Ac4yIdentificationBase template)
	{
		Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
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
	public Boolean existsById(Int32 id)
	{
		Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
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
	public Boolean existsByGUID(String GUID)
	{
		Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
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
	public Boolean existsByHumanId(String HumanId)
	{
		Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
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
	public Boolean existsByPublicHumanId(String PublicHumanId)
	{
		Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
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
	public Boolean existsByCreatedAt(DateTime CreatedAt)
	{
		Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
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
	public Boolean existsByUpdatedAt(String UpdatedAt)
	{
		Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
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
	
		public void update(Ac4yIdentification updatedAc4yIdentification)
        {
            using(var ctx = new AllContext(baseName))
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


        public void deleteById(Int32 id)
        {
            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Remove(ctx.Ac4yIdentifications.Single(ss => ss.id == id));

                ctx.SaveChanges();
            }
        }

	public void addNew(Ac4yIdentification _Ac4yIdentification)
	{
		using (var ctx = new AllContext(baseName))
            {
                ctx.Ac4yIdentifications.Add(_Ac4yIdentification);

                ctx.SaveChanges();
            }
	}
    }
}
