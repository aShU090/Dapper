using System.Collections.Generic;

namespace Apttus.Assignment.MovieTicket.Interface
{
    public interface ITicket
    {
        int GetTotalCost(List<Person> per);
    }
}