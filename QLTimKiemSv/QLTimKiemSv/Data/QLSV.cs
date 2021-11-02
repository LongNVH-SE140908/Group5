using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTimKiemSv.Data
{
    public class QLSV
    {
        QLSVienEntities sv;
        public QLSV() {
            sv = new QLSVienEntities();
        }
        public int[] GetAllIdSv()
        {
            return sv.SVIENs.Select(x=>x.MASV).ToArray();
        }
        public SVIEN GetSvienById(int id)
        {
            if (id > 0)
            {
                return sv.SVIENs.Where(x => x.MASV==id).FirstOrDefault();
            }
            return null;
        }
    }
}
