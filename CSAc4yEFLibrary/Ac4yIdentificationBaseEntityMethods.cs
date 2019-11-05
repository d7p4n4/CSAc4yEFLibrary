using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using d7p4n4.Algebra.Class;
using d7p4n4.Final.Class;
using d7p4n4.Context.Class;


namespace d7p4n4.EFMethods.Class
{
    public class Ac4yIdentificationBaseEntityMethods : Ac4yIdentificationBaseAlgebra
    {
		public string baseName { get; set; }

        public Ac4yIdentificationBaseEntityMethods() { }

        public Ac4yIdentificationBaseEntityMethods(string newBaseName)
        {
            baseName = newBaseName;
        }
	
        public Ac4yIdentificationBase findFirstById(Int32 id)
        {
            Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4yIdentificationBase>();

                a = query;
            }
            return a;
        }
        public Ac4yIdentificationBase findFirstByGUID(String GUID)
        {
            Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.GUID == GUID)
                                .FirstOrDefault<Ac4yIdentificationBase>();

                a = query;
            }
            return a;
        }
        public Ac4yIdentificationBase findFirstByHumanId(String HumanId)
        {
            Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.HumanId == HumanId)
                                .FirstOrDefault<Ac4yIdentificationBase>();

                a = query;
            }
            return a;
        }
        public Ac4yIdentificationBase findFirstByPublicHumanId(String PublicHumanId)
        {
            Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.PublicHumanId == PublicHumanId)
                                .FirstOrDefault<Ac4yIdentificationBase>();

                a = query;
            }
            return a;
        }
        public Ac4yIdentificationBase findFirstByCreatedAt(DateTime CreatedAt)
        {
            Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.CreatedAt == CreatedAt)
                                .FirstOrDefault<Ac4yIdentificationBase>();

                a = query;
            }
            return a;
        }
        public Ac4yIdentificationBase findFirstByUpdatedAt(String UpdatedAt)
        {
            Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.UpdatedAt == UpdatedAt)
                                .FirstOrDefault<Ac4yIdentificationBase>();

                a = query;
            }
            return a;
        }

        public List<Ac4yIdentificationBase> findListById(Int32 id)
        {
            List<Ac4yIdentificationBase> a = new List<Ac4yIdentificationBase>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.id == id).ToList();

                a = query;
            }
            return a;
        }
        public List<Ac4yIdentificationBase> findListByGUID(String GUID)
        {
            List<Ac4yIdentificationBase> a = new List<Ac4yIdentificationBase>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.GUID == GUID).ToList();

                a = query;
            }
            return a;
        }
        public List<Ac4yIdentificationBase> findListByHumanId(String HumanId)
        {
            List<Ac4yIdentificationBase> a = new List<Ac4yIdentificationBase>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.HumanId == HumanId).ToList();

                a = query;
            }
            return a;
        }
        public List<Ac4yIdentificationBase> findListByPublicHumanId(String PublicHumanId)
        {
            List<Ac4yIdentificationBase> a = new List<Ac4yIdentificationBase>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.PublicHumanId == PublicHumanId).ToList();

                a = query;
            }
            return a;
        }
        public List<Ac4yIdentificationBase> findListByCreatedAt(DateTime CreatedAt)
        {
            List<Ac4yIdentificationBase> a = new List<Ac4yIdentificationBase>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.CreatedAt == CreatedAt).ToList();

                a = query;
            }
            return a;
        }
        public List<Ac4yIdentificationBase> findListByUpdatedAt(String UpdatedAt)
        {
            List<Ac4yIdentificationBase> a = new List<Ac4yIdentificationBase>();

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.UpdatedAt == UpdatedAt).ToList();

                a = query;
            }
            return a;
        }

	public Boolean existsById(Int32 id)
	{
		Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext(baseName))
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
	public Boolean existsByGUID(String GUID)
	{
		Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext(baseName))
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
	public Boolean existsByHumanId(String HumanId)
	{
		Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext(baseName))
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
	public Boolean existsByPublicHumanId(String PublicHumanId)
	{
		Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext(baseName))
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
	public Boolean existsByCreatedAt(DateTime CreatedAt)
	{
		Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext(baseName))
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
	public Boolean existsByUpdatedAt(String UpdatedAt)
	{
		Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext(baseName))
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
	
		public void update(Ac4yIdentificationBase updatedAc4yIdentificationBase)
        {
            using(var ctx = new AllContext(baseName))
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


        public void deleteById(Int32 id)
        {
            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentificationBases
                                .Remove(ctx.Ac4yIdentificationBases.Single(ss => ss.id == id));

                ctx.SaveChanges();
            }
        }

	public void addNew(Ac4yIdentificationBase _Ac4yIdentificationBase)
	{
		using (var ctx = new AllContext(baseName))
            {
                ctx.Ac4yIdentificationBases.Add(_Ac4yIdentificationBase);

                ctx.SaveChanges();
            }
	}
    }
}
