using System;
using System.Collections.Generic;
using System.Text;

namespace HelpApp.Core.Contracts
{
    public interface IUnitOfWork
    {
        ICountryRepository CountryRepository { get; set; }
    }
}
