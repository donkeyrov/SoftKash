using LoanMgt.SHARED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class SequenceRepository : GenericRepository<Sequence>, ISequenceRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public SequenceRepository(ApplicationDbContext db) : base(db)
        {

        }

        public Sequence GetByName(string name)
        {
            return dbContext.Set<Sequence>().Where(s => s.Name.ToUpper() == name.ToUpper()).FirstOrDefault();
        }

        public Sequence Increment(Sequence sequence)
        {
            //int len = sequence.SeqNumber.Length;

            //float seq = float.Parse(sequence.SeqNumber);
            int step = sequence.Step;

            //float newSeq = seq + step;
            //sequence.SeqNumber = newSeq.ToString($"D{len}");
            //--------------------------------------------------
            string ManNo = sequence.SeqNumber;
            int manNoLength = ManNo.Length;

            string suffix = new String(ManNo.Where(Char.IsDigit).ToArray());
            int suffixLength = suffix.Length;

            string preFix = ManNo.Replace(suffix, string.Empty);
            int preFixLength = preFix.Length;

            

            string OldEmployeNo = int.Parse(suffix).ToString();
            string NewEmployeeNo = (int.Parse(suffix) + step).ToString($"D{suffixLength}");

            sequence.SeqNumber = $"{preFix}{NewEmployeeNo}";

            return sequence;
        }
    }
}
