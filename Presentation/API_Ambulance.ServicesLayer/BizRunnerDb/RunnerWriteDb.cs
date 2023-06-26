using APi_Ambulance.Persistens.CodeEfCore;
using API_Ambulance.Application.GenericInterfaces;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace API_Ambulance.ServicesLayer.BizRunnerDb
{
    public class RunnerWriteDb<TIn, TOut>
    {
        private readonly IBizAction<TIn, TOut> _action;
        private readonly EfCoreDbContext _context;

        public IImmutableList<ValidationResult> Errors => _action.Errors;
        public bool HasErrors => _action.HasError;
        public RunnerWriteDb(IBizAction<TIn, TOut> action, EfCoreDbContext context)
        {
            _action = action;
            _context = context;
        }
        public TOut RunAction(TIn add)
        {
            var result = _action.Action(add);
            if(!HasErrors)
            {
                _context.SaveChangesAsync();
            }
            return result;
        }
    }
}
