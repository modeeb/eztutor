using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using EZTutor.Data.Remote.Entities;
using NHibernate;
using NHibernate.Cfg;

namespace EZTutor.Data.Remote.Domain
{
    public class Provider
    {
        private ISessionFactory sessionFactory = null;

        private ISessionFactory SQLiteSessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    Configuration cfg = new Configuration();
                        //.SetDefaultAssembly(typeof(Lectures).Assembly.FullName);
                        //.SetDefaultNamespace(typeof(Lectures).Namespace);

                    cfg.Configure(@"C:\Project\EZTutor\EZTutor.Data.Remote\hibernate.cfg.xml");

                    cfg.AddDirectory(new DirectoryInfo(@"C:\Project\EZTutor\EZTutor.Data.Remote\Mappings"));
                    //cfg.AddClass(typeof(Lectures));
                    //cfg.AddClass(typeof(Topics));
                    //cfg.AddClass(typeof(Slides));

                    sessionFactory = cfg.BuildSessionFactory();
                }
                return sessionFactory;
            }
        }

        public ISession GetSession()
        {
            return SQLiteSessionFactory.OpenSession();
        }
    }
}
