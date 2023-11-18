using SalmasBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalmasBook.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType); //THIS CAN MAYBE BE AN ERROR LATER ON

    }
}
