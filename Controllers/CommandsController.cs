using Commander.Models;
using Commander.Data;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers{

    //api/commands
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase{

        private readonly ICommanderRepo _repository; 
        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands(){
            var a = 3;
            a = 1;
            a = 2;
            Console.WriteLine("Hello " + a);
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{Id}")]
        public ActionResult <Command> GetCommandById(int id){
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}