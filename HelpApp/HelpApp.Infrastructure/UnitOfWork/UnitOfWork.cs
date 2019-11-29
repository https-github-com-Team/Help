using HelpApp.Core.Contracts;
using HelpApp.Infrastructure.Db;
using HelpApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpApp.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region MyRegion
        public HelpDbContext _db { get; set; }
        public UnitOfWork(HelpDbContext db)
        {
            _db = db;
        }
        public ICountryRepository CountryRepository
        {
            get => CountryRepository = new CountryRepository(_db);
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
            }
        }

        public ICityRepository CityRepository
        {
            get => CityRepository = new CityRepository(_db);
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
            }
        }

        public IPersonRepository PersonRepository
        {
            get => PersonRepository = new PersonRepository(_db);
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
            }
        }

        public IProductRepository ProductRepository
        {
            get => ProductRepository = new ProductRepository(_db);
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
            }
        }

        public ICategoryRepository CategoryRepository
        {
            get => CategoryRepository = new CategoryRepository(_db);
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
            }
        }

        public ISubCategoryRepository SubCategoryRepository
        {
            get => SubCategoryRepository = new SubCategoryRepository(_db);
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
            }
        }








        #endregion
    }
}
