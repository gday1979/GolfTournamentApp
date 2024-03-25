namespace GolfTournamentApp.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBaseDataService
    {
        Task<T> GetViewModelByIdAsync<T>(int id);

        Task DeleteByIdAsync(int id);
    }
}
