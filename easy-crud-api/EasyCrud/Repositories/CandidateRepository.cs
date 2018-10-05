using EasyCrud.Context;
using EasyCrud.Domain.Entities;
using EasyCrud.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyCrud.Repositories
{
    public class CandidateRepository  : ICandidateRepository
    {
		private readonly ApplicationDbContext _context;
		private readonly DbSet<Candidate> _dbSet;

		public CandidateRepository(ApplicationDbContext context)
		{
			_context = context;
			_dbSet = _context.Set<Candidate>();
		}

		public Candidate Get(params object[] keyValues) => _dbSet.Find(keyValues);

		public IEnumerable<Candidate> GetAll() => _dbSet.ToList();

		public Candidate Insert(Candidate candidate)
		{
			_dbSet.Add(candidate);
            _context.SaveChanges();
            
			return candidate;
		}

		public Candidate Update(Candidate candidate)
		{
			_dbSet.Update(candidate);
            _context.SaveChanges();
            return candidate;
		}

		public void Delete(Candidate candidate)
		{
			_dbSet.Remove(candidate);
            _context.SaveChanges();
        }
	
	}
}
