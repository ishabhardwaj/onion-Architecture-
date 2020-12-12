using System;
using System.Collections.Generic;
using System.Text;
using ApiColor.Api.DB;
using ApiColor.Repository;
using ApiColor.Repository.DB;
using ApiColor.Repository.IRepository;

namespace ApiColor.Repository.Repository
{
    class Repository : RepositoryBase
    {
       
        private readonly TestDBContext _context;
        public Repository(TestDBContext context)
        {
            _context = context;
        }
    }
    }

