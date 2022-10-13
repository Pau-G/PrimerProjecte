using Microsoft.AspNetCore.Mvc;

namespace PrimerProjecte.Controllers;

[ApiController]
[Route("[controller]")]
public class CounterController : ControllerBase
{
    private readonly ICounterService<CounterController> _counter;

    public CounterController(ICounterService<CounterController> counter)
    {
        _counter = counter;
    }

    [HttpGet]
    public ICounterService<Counter> get()
    {
        return GetAndIncrement();
    }

    public GetAndIncrement()
    {
        return _counter++;
    }
}