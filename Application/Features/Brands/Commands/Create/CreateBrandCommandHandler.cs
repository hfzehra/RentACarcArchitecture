using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        //Handler -> Alıcı demek 
        public Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new CreatedBrandResponse { Name = request.Name });
        }
    }

   // public static class ApplicationServiceRegistration { public static IServiceCollection AddApplicationServices(this IServiceCollection services) { services.AddMe diatR(configuration => { configuration.Regis terServicesFromAssembly(Assembly.GetExecutingAssembly()); }); return services; } }
}
