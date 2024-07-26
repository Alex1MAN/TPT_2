using FSH.WebApi.Application.Common.Interfaces;

namespace FSH.WebApi.Application.Common.Exporters;

public interface IExcelWriter : ITransientService
{
    Stream WriteToStream<T>(IList<T> data);
}