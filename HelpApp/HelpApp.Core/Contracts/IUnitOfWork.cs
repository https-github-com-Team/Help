using System;
using System.Collections.Generic;
using System.Text;

namespace HelpApp.Core.Contracts
{
    public interface IUnitOfWork
    {
        ICountryRepository CountryRepository { get; set; }
        ICityRepository CityRepository { get; set; }
        IPersonRepository PersonRepository { get; set; }
        IProductRepository ProductRepository { get; set; }
        ICategoryRepository CategoryRepository { get; set; }
        ISubCategoryRepository SubCategoryRepository { get; set; }


    }
}
