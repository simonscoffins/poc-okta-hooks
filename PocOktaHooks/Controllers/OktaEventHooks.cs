using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace PocOktaHooks.Controllers;

[Route("api/oktaeventhooks")]
[ApiController]
public class OktaEventHooks : ControllerBase {


    private readonly ILogger<OktaEventHooks> _logger;

    public OktaEventHooks(ILogger<OktaEventHooks> logger) {
        _logger = logger;
    }


    [HttpGet]
    [Route("testhook")]
    public IActionResult GetTestHook() {

        var oktaVerificationChallenge = Request.Headers["x-okta-verification-challenge"];
        var response = new { Verification = oktaVerificationChallenge };
        return Ok(response);
    }


    [HttpPost]
    [Route("testhook")]
    public IActionResult PostTestHook([FromBody] string data) {

        //Debug.WriteLine(data.ToString());
        Debug.WriteLine(data);
        return Ok();
    }

}