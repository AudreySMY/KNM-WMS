using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace UserSAP.Authorization;

public class IdadeAuthorization : AuthorizationHandler<IdadeMinima>
{

    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IdadeMinima requirement)
    {
        var dateOfBirthClaim = context
            .User.FindFirst(claim =>
            claim.Type == ClaimTypes.DateOfBirth);

        if (dateOfBirthClaim is null)
            return Task.CompletedTask;

        var dateOfBirth = Convert
            .ToDateTime(dateOfBirthClaim.Value);

        var idadeUsuario =
            DateTime.Today.Year - dateOfBirth.Year;

        if (dateOfBirth >
            DateTime.Today.AddYears(-idadeUsuario))
            idadeUsuario--;


        if (idadeUsuario >= requirement.Idade)
            context.Succeed(requirement);

        return Task.CompletedTask;
    }
}
