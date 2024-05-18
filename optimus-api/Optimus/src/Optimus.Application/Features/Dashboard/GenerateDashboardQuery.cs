using MediatR;

namespace Optimus.Application.Features.Dashboard;

public sealed record GenerateDashboardQuery : IRequest<DashboardResponse>;