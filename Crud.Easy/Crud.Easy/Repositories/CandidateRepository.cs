using Crud.Easy.Domain.Entities;
using Crud.Easy.Domain.Interfaces.Repositories;
using NETCore.DapperKit.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Easy.Repositories
{
    public class CandidateRepository : RepositoryBase<Candidate>, ICandidateRepository
    {
        public override bool Insert(Candidate obj)
        {
            using (var cn = base.db.Connection)
            {
                cn.Open();
                using (var tran = cn.BeginTransaction())
                {


                    var insertBank = ((obj.BankId = cn.Insert(obj.Bank, tran)) > 0);
                    var insertKnowledgement = ((obj.KnowledgementId = cn.Insert(obj.Knowledgement, tran)) > 0);
                    var insertCandidate = ((obj.CandidateId = cn.Insert(obj, tran)) > 0);

                    var transactionResult = insertCandidate && insertKnowledgement && insertBank;

                    if (transactionResult)
                        tran.Commit();
                    else
                        tran.Rollback();

                    return transactionResult;

                }
            }
        }

        public override IEnumerable<Candidate> GetAll()
        {
            var sql = "SELECT * FROM";

            Dictionary<int, Candidate> candidates = new Dictionary<int, Candidate>();
            db.Connection.Query<Candidate, Bank, Candidate>(sql,
                                splitOn: "PathImage",
                                map: (c, b, k) =>
                                {
                                    Candidate can;
                                    if (!candidates.TryGetValue((int)c.CandidateId, out result))
                                    {
                                        pr = p;
                                        produtos.Add((int)pr.ProductId, pr);
                                    }
                                    if (g.IsPrincipal)
                                    {
                                        pr.GaleryProduct.Add(g);

                                    }
                                    return p;
                                }


                ).ToList();

            return produtos.Values;

        }
    }
}
