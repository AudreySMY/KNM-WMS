using Microsoft.AspNetCore.Authorization;

namespace UserSAP.Authorization;

public class IdadeMinima : IAuthorizationRequirement
{
	public IdadeMinima(int idade)
	{
		Idade = idade;
	}
    public int Idade { get; set; }
}
