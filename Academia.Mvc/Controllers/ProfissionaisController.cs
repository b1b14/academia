using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace academia;

[Authorize(Roles = "Admin")]
public class ProfissionaisController : Controller
{

}