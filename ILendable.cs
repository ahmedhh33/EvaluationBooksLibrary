using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEvaluation
{
    public interface ILendable
    {
        public void BorrowBook(object MemberID);
        public void ReturnBook(object MemberID);
    }
}
